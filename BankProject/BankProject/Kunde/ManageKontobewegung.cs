using BankProject.utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Kunde
{
    internal class ManageKontobewegung
    {
        public ManageKontobewegung()
        {

        }

        public void SetBalance(string mail, Label kontostand)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT Account.CurrentBalance " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE Person.Email = @Mail";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mail", mail);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Nur wenn ein Datensatz vorhanden ist
                        {
                            kontostand.Text = reader["CurrentBalance"].ToString();
                        }
                        else
                        {
                            CustomSoundPlayer.PlayErrorSound();
                            MessageBox.Show("Error: Userinformationen konnten nicht gefunden werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                connection.Close();
            }
        }

        public void ManageZahlung(string mail, ComboBox zahlungsart, TextBox betrag)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            decimal betragValue;

            // Betrag prüfen
            if (!decimal.TryParse(betrag.Text, out betragValue) || betragValue <= 0)
            {
                CustomSoundPlayer.PlayWarningSound();
                MessageBox.Show("Bitte einen gültigen Betrag eingeben.", "Ungültiger Betrag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // PersonID und AccountID ermitteln
                string getIdsQuery =
                    "SELECT Person.PersonID, Account.AccountID, Account.CurrentBalance " +
                    "FROM Person " +
                    "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                    "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                    "WHERE Person.Email = @Mail";

                long personId = 0, accountId = 0;
                decimal currentBalance = 0;

                using (SQLiteCommand getIdsCommand = new SQLiteCommand(getIdsQuery, connection))
                {
                    getIdsCommand.Parameters.AddWithValue("@Mail", mail);

                    using (SQLiteDataReader reader = getIdsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personId = Convert.ToInt64(reader["PersonID"]);
                            accountId = Convert.ToInt64(reader["AccountID"]);
                            currentBalance = Convert.ToDecimal(reader["CurrentBalance"]);
                        }
                        else
                        {
                            CustomSoundPlayer.PlayErrorSound();
                            MessageBox.Show("Konto konnte nicht gefunden werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (zahlungsart.Text == "Einzahlen" || zahlungsart.Text == "Auszahlen")
                {
                    // Kontostand aktualisieren
                    string updateBalanceQuery = string.Empty;

                    if (zahlungsart.Text == "Einzahlen")
                    {
                        updateBalanceQuery =
                            "UPDATE Account " +
                            "SET CurrentBalance = CurrentBalance + @Amount " +
                            "WHERE AccountID = @AccountID";
                    }
                    else if (zahlungsart.Text == "Auszahlen")
                    {
                        // Prüfen, ob der Betrag verfügbar ist
                        if (currentBalance < betragValue)
                        {
                            CustomSoundPlayer.PlayWarningSound();
                            MessageBox.Show("Der Kontostand ist nicht ausreichend.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        updateBalanceQuery =
                            "UPDATE Account " +
                            "SET CurrentBalance = CurrentBalance - @Amount " +
                            "WHERE AccountID = @AccountID";
                    }
                        

                    using (SQLiteCommand updateBalanceCommand = new SQLiteCommand(updateBalanceQuery, connection))
                    {
                        updateBalanceCommand.Parameters.AddWithValue("@Amount", betragValue);
                        updateBalanceCommand.Parameters.AddWithValue("@AccountID", accountId);
                        updateBalanceCommand.ExecuteNonQuery();
                    }

                    // Letzte TransactionID auslesen
                    string getLastTransactionIdQuery =
                        "SELECT MAX(TransactionID) " +
                        "FROM Überweisung";

                    long lastTransactionId = 0;
                    using (SQLiteCommand getLastTransactionCommand = new SQLiteCommand(getLastTransactionIdQuery, connection))
                    {
                        var result = getLastTransactionCommand.ExecuteScalar();
                        lastTransactionId = result != DBNull.Value ? Convert.ToInt64(result) : 0;
                    }

                    // Neue Überweisung hinzufügen
                    string addTransactionQuery =
                        "INSERT INTO Überweisung (TransactionID, AccountID, TransactionType, Amount, TransactionDate) " +
                        "VALUES (@TransactionID, @AccountID, @TransactionType, @Amount, @TransactionDate)";

                    using (SQLiteCommand addTransactionCommand = new SQLiteCommand(addTransactionQuery, connection))
                    {
                        addTransactionCommand.Parameters.AddWithValue("@TransactionID", lastTransactionId + 1); // +1 zur letzten ID
                        addTransactionCommand.Parameters.AddWithValue("@AccountID", accountId);
                        addTransactionCommand.Parameters.AddWithValue("@TransactionType", zahlungsart.SelectedItem?.ToString() ?? "Unbekannt");
                        addTransactionCommand.Parameters.AddWithValue("@Amount", betragValue);
                        addTransactionCommand.Parameters.AddWithValue("@TransactionDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        addTransactionCommand.ExecuteNonQuery();
                    }

                    CustomSoundPlayer.PlaySuccessSound();
                    MessageBox.Show("Zahlung erfolgreich verarbeitet.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();

                    Kontobewegungen kontobewegungen = Kontobewegungen.GetInstance();
                    kontobewegungen.Close();
                }
                else
                {
                    CustomSoundPlayer.PlayInformationSound();
                    MessageBox.Show("Wähle bitte erst die Zahlungsart aus!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void ShowRestbetrag(string mail, ComboBox zahlungsart, TextBox betrag, Label restbetrag)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT Account.CurrentBalance " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE Person.Email = @Mail";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                if (zahlungsart.Text == "Einzahlen" || zahlungsart.Text == "Auszahlen")
                {
                    try
                    {
                        connection.Open();

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Mail", mail);

                            object result = command.ExecuteScalar();
                            if (result != null)
                            {
                                // Aktuellen Kontostand holen
                                decimal currentBalance = Convert.ToDecimal(result);

                                // Eingabewert prüfen und umrechnen
                                if (decimal.TryParse(betrag.Text, out decimal eingegebenerBetrag))
                                {
                                    decimal rest = 0;

                                    if (zahlungsart.Text == "Einzahlen")
                                    {
                                        // Restbetrag berechnen
                                        rest = currentBalance + eingegebenerBetrag;
                                    }
                                    else if (zahlungsart.Text == "Auszahlen")
                                    {
                                        // Restbetrag berechnen
                                        rest = currentBalance - eingegebenerBetrag;
                                    }

                                    // Restbetrag anzeigen
                                    restbetrag.Text = rest.ToString("F2");
                                }
                                else
                                {
                                    restbetrag.Text = "Ungültiger Betrag";
                                }
                            }
                            else
                            {
                                restbetrag.Text = "0";

                                CustomSoundPlayer.PlayErrorSound();
                                MessageBox.Show("Fehler: Restbetrag konnte nicht berechnet werden.\n\nKontodaten nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        restbetrag.Text = "0";

                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Fehler: Restbetrag konnte nicht berechnet werden.\nGrund:\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    restbetrag.Text = "0";
                }
            }
        }
    }
}

using BankProject.utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Kunde
{
    internal class ManageKontoverwaltung
    {
        string userMail = string.Empty;
        public ManageKontoverwaltung(string mail) 
        { 
            userMail = mail;
        }

        public void SetUserData(TextBox vorname, TextBox nachname, TextBox gebDatum, TextBox mail, TextBox phoneNumber, TextBox adress, TextBox tax, Button safeChanges)
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            string query =
                "SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, TaxIdentifier " +
                "FROM Person " +
                "WHERE Email = @Mail";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mail", userMail);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Nur wenn ein Datensatz vorhanden ist
                        {
                            vorname.Text = reader["FirstName"].ToString();
                            nachname.Text = reader["LastName"].ToString();

                            // Konvertiere Datum ins gewünschte Anzeigeformat (DD.MM.YYYY)
                            if (DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime dateOfBirth))
                            {
                                gebDatum.Text = dateOfBirth.ToString("dd.MM.yyyy");
                            }
                            else
                            {
                                gebDatum.Text = string.Empty; // Wenn kein gültiges Datum vorhanden ist
                            }

                            mail.Text = reader["Email"].ToString();
                            phoneNumber.Text = reader["PhoneNumber"].ToString();
                            adress.Text = reader["Address"].ToString();
                            tax.Text = reader["TaxIdentifier"].ToString();

                            safeChanges.Visible = false;

                            Kontoverwaltung_Kunde kontoverwaltung_Kunde = Kontoverwaltung_Kunde.GetInstance();
                            kontoverwaltung_Kunde.isSettingData = false;
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

        public void SafeChanges(TextBox vorname, TextBox nachname, TextBox gebDatum, TextBox mail, TextBox phoneNumber, TextBox adress, TextBox tax)
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            string query =
                "UPDATE Person SET " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "DateOfBirth = @BirthDate, " +
                "PhoneNumber = @PhoneNumber, " +
                "Address = @Address, " +
                "TaxIdentifier = @TaxNumber " +
                "WHERE Email = @Mail";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parameter aus den TextBoxen setzen
                    command.Parameters.AddWithValue("@FirstName", vorname.Text);
                    command.Parameters.AddWithValue("@LastName", nachname.Text);

                    // Konvertiere Datum ins gewünschte Speicherformat (YYYY-MM-DD)
                    if (DateTime.TryParseExact(gebDatum.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        command.Parameters.AddWithValue("@BirthDate", parsedDate.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        MessageBox.Show("Ungültiges Datum. Bitte verwenden Sie das Format DD.MM.YYYY.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                    command.Parameters.AddWithValue("@Address", adress.Text);
                    command.Parameters.AddWithValue("@TaxNumber", tax.Text);
                    command.Parameters.AddWithValue("@Mail", userMail);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Kontoverwaltung_Kunde kontoverwaltung_Kunde = Kontoverwaltung_Kunde.GetInstance();
                            kontoverwaltung_Kunde.userMail = userMail;

                            CustomSoundPlayer.PlayInformationSound();
                            MessageBox.Show("Änderungen wurden erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            CustomSoundPlayer.PlayWarningSound();
                            MessageBox.Show("Keine Änderungen vorgenommen. Überprüfen Sie die Daten.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show($"Fehler beim Speichern: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();
            }
        }

        public void CloseKonto()
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // 1. PersonID anhand der Email auslesen
                string getPersonIDQuery = "SELECT PersonID FROM Person WHERE Email = @Mail";
                int personID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getPersonIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mail", userMail);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        personID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 2. CustomerID anhand der PersonID auslesen
                string getCustomerIDQuery = "SELECT CustomerID FROM Customer WHERE PersonID = @PersonID";
                int customerID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getCustomerIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayWarningSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3. AccountStatus auf 'Closed' setzen und CurrentBalance auf 0 setzen
                string updateAccountQuery =
                    "UPDATE Account " +
                    "SET AccountStatus = 'Closed', CurrentBalance = 0 " +
                    "WHERE CustomerID = @CustomerID";

                using (SQLiteCommand command = new SQLiteCommand(updateAccountQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            CustomSoundPlayer.PlaySuccessSound();
                            MessageBox.Show("Das Konto wurde erfolgreich geschlossen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Kontoverwaltung_Kunde kontoverwaltung_Kunde = Kontoverwaltung_Kunde.GetInstance();
                            kontoverwaltung_Kunde.Close();
                            Konto konto = Konto.GetInstance();
                            konto.Close();

                            LoginForm loginForm = LoginForm.GetInstance();
                            loginForm.Show();
                        }
                        else
                        {
                            CustomSoundPlayer.PlayWarningSound();
                            MessageBox.Show("Fehler: Dein Konto konnte nicht geschlossen werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show($"Fehler beim Schließen des Kontos: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();
            }
        }

        public void FindPassword(Label oldPass)
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // 1. PersonID anhand der Email auslesen
                string getPersonIDQuery = "SELECT PersonID FROM Person WHERE Email = @Mail";
                int personID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getPersonIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mail", userMail);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        personID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 2. CustomerID anhand der PersonID auslesen
                string getCustomerIDQuery = "SELECT CustomerID FROM Customer WHERE PersonID = @PersonID";
                int customerID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getCustomerIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayWarningSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3. AccountPin auslesen
                string updateAccountQuery =
                    "SELECT AccountPin " +
                    "FROM Account " +
                    "WHERE CustomerID = @CustomerID";

                using (SQLiteCommand command = new SQLiteCommand(updateAccountQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        oldPass.Text = result.ToString();
                    }
                }

                connection.Close();
            }
        }

        public void PasswortÄndern(Label oldPass, TextBox newPass)
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // 1. PersonID anhand der Email auslesen
                string getPersonIDQuery = "SELECT PersonID FROM Person WHERE Email = @Mail";
                int personID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getPersonIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@Mail", userMail);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        personID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 2. CustomerID anhand der PersonID auslesen
                string getCustomerIDQuery = "SELECT CustomerID FROM Customer WHERE PersonID = @PersonID";
                int customerID = 0;

                using (SQLiteCommand command = new SQLiteCommand(getCustomerIDQuery, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", personID);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        customerID = Convert.ToInt32(result);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayWarningSound();
                        MessageBox.Show("Error: Dein Konto wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3. AccountPin auslesen
                string updateAccountQuery =
                    "UPDATE Account " +
                    "SET AccountPin = @NewPin " +
                    "WHERE CustomerID = @CustomerID";

                using (SQLiteCommand command = new SQLiteCommand(updateAccountQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewPin", newPass.Text);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        command.ExecuteNonQuery();

                        CustomSoundPlayer.PlaySuccessSound();
                        MessageBox.Show("Passwort erfolgreich geändert!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChangePassword changePassword = ChangePassword.GetInstance();
                        changePassword.Close();
                    }
                    catch (Exception ex)
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Error: Passwort konnte nicht geändert werden!\nGrund:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ChangePassword changePassword = ChangePassword.GetInstance();
                        changePassword.Close();
                    }                    
                }
                connection.Close();
            }
        }
    }
}

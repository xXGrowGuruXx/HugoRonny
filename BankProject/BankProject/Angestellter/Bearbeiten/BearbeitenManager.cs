using BankProject.utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Angestellter.Bearbeiten
{
    internal class BearbeitenManager
    {
        public BearbeitenManager() { }

        public void FillComboBoxMitarbeiter(ComboBox bearbeiten_ChooseMitarbeiter)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query = 
                "SELECT DISTINCT FirstName || ' ' || LastName AS FullName FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "WHERE Customer.CustomerType = 'Mitarbeiter'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bearbeiten_ChooseMitarbeiter.Items.Add(reader["FullName"].ToString());
                    }
                }
            }
        }

        public void FillComboBoxBranch(ComboBox bearbeiten_branch)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query = "SELECT DISTINCT BranchName FROM Branch";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string branchName = reader["BranchName"].ToString();
                        if (!bearbeiten_branch.Items.Contains(branchName))
                        {
                            bearbeiten_branch.Items.Add(branchName);
                        }
                    }
                }
            }
        }

        public void FillComboBoxPosition(ComboBox bearbeiten_position)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query = "SELECT DISTINCT Position FROM Mitarbeiter";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string position = reader["Position"].ToString();
                        if (!bearbeiten_position.Items.Contains(position))
                        {
                            bearbeiten_position.Items.Add(position);
                        }
                    }
                }
            }
        }

        public void SetDetails(ComboBox bearbeiten_branch, ComboBox bearbeiten_position, string selectedMitarbeiter)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query = @"
                SELECT Branch.BranchName, Mitarbeiter.Position 
                FROM Person
                JOIN Mitarbeiter ON Person.PersonID = Mitarbeiter.PersonID
                JOIN Branch ON Mitarbeiter.BranchID = Branch.BranchID
                WHERE FirstName || ' ' || LastName = @FullName";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", selectedMitarbeiter);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Aktuellen Branch setzen
                            string branchName = reader["BranchName"].ToString();
                            bearbeiten_branch.SelectedItem = bearbeiten_branch.Items.Contains(branchName) ? branchName : null;

                            // Aktuelle Position setzen
                            string position = reader["Position"].ToString();
                            bearbeiten_position.SelectedItem = bearbeiten_position.Items.Contains(position) ? position : null;
                        }
                    }
                }
            }
        }

        public void Save(ComboBox mitarbeiter, ComboBox branch, ComboBox position)
        {
            string selectedMitarbeiter = mitarbeiter.SelectedItem.ToString();
            string selectedBranch = branch.SelectedItem.ToString();
            string selectedPosition = position.SelectedItem.ToString();

            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            // SQL-Abfrage, um Branch und Position zu aktualisieren
            string query = @"
                UPDATE Mitarbeiter
                SET BranchID = (SELECT BranchID FROM Branch WHERE BranchName = @BranchName),
                    Position = @Position
                WHERE PersonID = (SELECT PersonID FROM Person WHERE FirstName || ' ' || LastName = @FullName)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Parameter binden
                    command.Parameters.AddWithValue("@FullName", selectedMitarbeiter);
                    command.Parameters.AddWithValue("@BranchName", selectedBranch);
                    command.Parameters.AddWithValue("@Position", selectedPosition);

                    // SQL-Befehl ausführen
                    int rowsAffected = command.ExecuteNonQuery();

                    // Rückmeldung an den Benutzer
                    if (rowsAffected > 0)
                    {
                        CustomSoundPlayer.PlaySuccessSound();
                        MessageBox.Show("Die Änderungen wurden erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CustomSoundPlayer.PlayWarningSound();
                        MessageBox.Show("Es wurden keine Änderungen vorgenommen. Bitte überprüfen Sie Ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void SaveNewMitarbeiter(
            string vorname,
            string nachname,
            string geburtsdatum,
            string email,
            string telefonnummer,
            string adresse,
            string steuerID,
            string branch,
            string position)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Person Tabelle aktuallisieren
                        string insertPersonQuery = @"
                            INSERT INTO Person (FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, TaxIdentifier)
                            VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @PhoneNumber, @Adress, @TaxIdentifier);
                            SELECT last_insert_rowid();";

                        long personId;
                        using (SQLiteCommand cmd = new SQLiteCommand(insertPersonQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", vorname);
                            cmd.Parameters.AddWithValue("@LastName", nachname);
                            cmd.Parameters.AddWithValue("@DateOfBirth", geburtsdatum);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@PhoneNumber", telefonnummer);
                            cmd.Parameters.AddWithValue("@Adress", adresse);
                            cmd.Parameters.AddWithValue("@TaxIdentifier", steuerID);

                            personId = (long)cmd.ExecuteScalar();
                        }

                        // 2. Customer Tabelle aktuallisieren
                        string insertCustomerQuery = @"
                            INSERT INTO Customer (PersonID, CustomerType)
                            VALUES (@PersonID, @CustomerType);
                            SELECT last_insert_rowid();";

                        long customerId;
                        using (SQLiteCommand cmd = new SQLiteCommand(insertCustomerQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@PersonID", personId);
                            cmd.Parameters.AddWithValue("@CustomerType", "Mitarbeiter");
                            cmd.ExecuteNonQuery();

                            customerId = (long)cmd.ExecuteScalar();
                        }

                        // 3. BranchID aus der Branch Tabelle auslesen
                        string getBranchIdQuery = "SELECT BranchID FROM Branch WHERE BranchName = @BranchName;";
                        long branchId;

                        using (SQLiteCommand cmd = new SQLiteCommand(getBranchIdQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@BranchName", branch);
                            object result = cmd.ExecuteScalar();
                            if (result == null)
                            {
                                throw new Exception($"Branch '{branch}' not found.");
                            }
                            branchId = (long)result;
                        }

                        // 4. Mitarbeiter Tabelle aktuallisieren
                        string insertMitarbeiterQuery = @"
                            INSERT INTO Mitarbeiter (PersonID, Position, BranchID)
                            VALUES (@PersonID, @Position, @BranchID);";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertMitarbeiterQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@PersonID", personId);
                            cmd.Parameters.AddWithValue("@Position", position);
                            cmd.Parameters.AddWithValue("@BranchID", branchId);
                            cmd.ExecuteNonQuery();
                        }

                        Random randomPin = new Random();
                        int pin = randomPin.Next(1000, 10000);
                        DateTime dateTime = DateTime.Today;
                        string insertAccountQuery = @"
                            INSERT INTO Account (CustomerID, AccountNumber, AccountType, CurrentBalance, DateOpened, DateClosed, AccountStatus, AccountPin)
                            VALUES (@CustomerID, 'AC0' || @CustomerID, 'Mitarbeiter', 0, @DATE, '', 'Active', @PIN);";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertAccountQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerId);
                            cmd.Parameters.AddWithValue("@DATE", dateTime);
                            cmd.Parameters.AddWithValue("@PIN", pin);
                            cmd.ExecuteNonQuery();
                        }

                        // Vorgang als erfolgreich beenden
                        transaction.Commit();

                        CustomSoundPlayer.PlaySuccessSound();
                        MessageBox.Show("Neuer Mitarbeiter hinzugefügt", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Einträge rückgängig machen
                        transaction.Rollback();

                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Error: Mitarbeiter konnte nicht hinzugefügt werden\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void DeleteMitarbeiter(string selectedMitarbeiter)
        {
            string[] parts = selectedMitarbeiter.Split(" ");
            if (parts.Length != 2)
            {
                CustomSoundPlayer.PlayWarningSound();
                MessageBox.Show("Ungültiger Name angegeben. Bitte Vor- und Nachnamen verwenden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vorname = parts[0];
            string nachname = parts[1];

            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Finde die PersonID, die gelöscht werden soll
                string findPersonIdQuery = "SELECT PersonID FROM Person WHERE FirstName = @Vorname AND LastName = @Nachname";
                using (SQLiteCommand personIDFindCommand = new SQLiteCommand(findPersonIdQuery, connection))
                {
                    personIDFindCommand.Parameters.AddWithValue("@Vorname", vorname);
                    personIDFindCommand.Parameters.AddWithValue("@Nachname", nachname);

                    object resultPersonID = personIDFindCommand.ExecuteScalar();
                    if (resultPersonID == null)
                    {
                        CustomSoundPlayer.PlayErrorSound();
                        MessageBox.Show("Die angegebene Person wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int personId = Convert.ToInt32(resultPersonID);


                    // Finden der CustomerID
                    int customerID = 0;
                    string findCustomerIdQuery =
                        "SELECT CustomerID " +
                        "From Customer " +
                        "JOIN Person ON Customer.CustomerID = Person.PersonID " +
                        "WHERE Person.PersonID = @PersonID";

                    using (SQLiteCommand customerIDFindCommand = new SQLiteCommand(findCustomerIdQuery, connection))
                    {
                        customerIDFindCommand.Parameters.AddWithValue("@PersonID", personId);

                        object resultCustomerID = customerIDFindCommand.ExecuteScalar();
                        if (resultPersonID == null)
                        {
                            CustomSoundPlayer.PlayErrorSound();
                            MessageBox.Show("Die angegebene Person wurde nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            customerID = Convert.ToInt32(resultCustomerID);
                        }
                    }
                    
                    // Löschen aus den Tabellen in der richtigen Reihenfolge (abhängige zuerst)
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Lösche aus Mitarbeiter
                            string deleteMitarbeiterQuery = "DELETE FROM Mitarbeiter WHERE PersonID = @PersonID";
                            using (SQLiteCommand deleteMitarbeiterCommand = new SQLiteCommand(deleteMitarbeiterQuery, connection, transaction))
                            {
                                deleteMitarbeiterCommand.Parameters.AddWithValue("@PersonID", personId);
                                deleteMitarbeiterCommand.ExecuteNonQuery();
                            }

                            // Lösche den Account
                            string deleteAccountQuery = "DELETE FROM Account WHERE CustomerID = @CustomerID";
                            using (SQLiteCommand deleteAccountCommand = new SQLiteCommand(deleteAccountQuery, connection, transaction))
                            {
                                deleteAccountCommand.Parameters.AddWithValue("@CustomerID", customerID);
                                deleteAccountCommand.ExecuteNonQuery();
                            }

                            // Lösche aus Customer
                            string deleteCustomerQuery = "DELETE FROM Customer WHERE PersonID = @PersonID";
                            using (SQLiteCommand deleteCustomerCommand = new SQLiteCommand(deleteCustomerQuery, connection, transaction))
                            {
                                deleteCustomerCommand.Parameters.AddWithValue("@PersonID", personId);
                                deleteCustomerCommand.ExecuteNonQuery();
                            }

                            // Lösche aus Person
                            string deletePersonQuery = "DELETE FROM Person WHERE PersonID = @PersonID";
                            using (SQLiteCommand deletePersonCommand = new SQLiteCommand(deletePersonQuery, connection, transaction))
                            {
                                deletePersonCommand.Parameters.AddWithValue("@PersonID", personId);
                                deletePersonCommand.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            CustomSoundPlayer.PlaySuccessSound();
                            MessageBox.Show("Der Mitarbeiter wurde erfolgreich gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();

                            CustomSoundPlayer.PlayErrorSound();
                            MessageBox.Show($"Fehler beim Löschen des Mitarbeiters: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}

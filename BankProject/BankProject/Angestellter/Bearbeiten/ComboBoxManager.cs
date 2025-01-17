﻿using BankProject.utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Angestellter.Bearbeiten
{
    internal class ComboBoxManager
    {
        public ComboBoxManager() { }

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
                        MessageBox.Show("Die Änderungen wurden erfolgreich gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
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
                            VALUES (@PersonID, @CustomerType);";

                        using (SQLiteCommand cmd = new SQLiteCommand(insertCustomerQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@PersonID", personId);
                            cmd.Parameters.AddWithValue("@CustomerType", "Mitarbeiter");
                            cmd.ExecuteNonQuery();
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
    }
}

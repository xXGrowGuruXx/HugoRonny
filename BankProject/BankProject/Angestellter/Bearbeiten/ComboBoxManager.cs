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
    }
}

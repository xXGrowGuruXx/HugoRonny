using BankProject.utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Angestellter.Bericht
{
    internal class BerichtManager
    {
        public BerichtManager() { }

        public void FillComboBoxKunde(ComboBox bearbeiten_ChooseMitarbeiter)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT DISTINCT FirstName || ' ' || LastName AS FullName " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE Customer.CustomerType = 'Kunde' " +
                "AND Account.AccountStatus = 'Active'";

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

                connection.Close();
            }
        }

        public void ShowKundenHistory(DataGridView grid, string fullName)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT Überweisung.TransactionType, Überweisung.Amount, DATE(Überweisung.TransactionDate) AS TransactionDate " +
                "FROM Überweisung " +
                "JOIN Account ON Überweisung.AccountID = Account.AccountID " +
                "JOIN Customer ON Customer.CustomerID = Account.CustomerID " +
                "JOIN Person ON Customer.PersonID = Person.PersonID " +
                "WHERE Person.FirstName || ' ' || Person.LastName = @Fullname " +
                "AND Account.AccountType = 'Kunde'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Fullname", fullName);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Leere das Grid
                        grid.Rows.Clear();
                        grid.Columns.Clear();

                        // Spalten aus der Query hinzufügen
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            grid.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }

                        // Datenzeilen hinzufügen
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[i] = reader.GetValue(i);
                            }
                            grid.Rows.Add(row);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}

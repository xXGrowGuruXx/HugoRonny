using BankProject.utils;
using BankProject.utils.export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject.Kunde
{
    public partial class KundenHistory : Form
    {
        string mail = string.Empty;
        public KundenHistory(string email)
        {
            mail = email;

            InitializeComponent();

            ShowKundenHistory(kundenHistory_Grid, mail);
        }

        private void KundenHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Konto konto = Konto.GetInstance();
            konto.Show();
        }

        private void kundenHistory_Zurück_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowKundenHistory(DataGridView grid, string mail)
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            string query =
                "SELECT Überweisung.TransactionType, Überweisung.Amount, DATE(Überweisung.TransactionDate) AS TransactionDate " +
                "FROM Überweisung " +
                "JOIN Account ON Überweisung.AccountID = Account.AccountID " +
                "JOIN Customer ON Customer.CustomerID = Account.CustomerID " +
                "JOIN Person ON Customer.PersonID = Person.PersonID " +
                "WHERE Person.Email = @Mail " +
                "AND Account.AccountType = 'Kunde'";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Mail", mail);

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

        private void kundenHistory_Export_Click(object sender, EventArgs e)
        {
            ExportToExcel exportToExcel = new ExportToExcel();
            exportToExcel.ExportToFile(kundenHistory_Grid, mail);
        }
    }
}

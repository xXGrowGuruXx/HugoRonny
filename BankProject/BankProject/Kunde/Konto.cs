using BankProject.Kunde;
using BankProject.utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankProject
{
    public partial class Konto : Form
    {
        string userMail = string.Empty;

        private static Konto instance;

        public static Konto GetInstance()
        {
            return instance;
        }

        public Konto(string email)
        {
            instance = this;
            userMail = email;

            InitializeComponent();

            SetDatas();
        }

        public void SetDatas()
        {
            string databasePath = Path.Combine(Path.GetTempPath(), "database.db");

            if (!File.Exists(databasePath))
            {
                databasePath = DatabaseHelper.ExtractDatabase();
            }

            string connectionString = $"Data Source={databasePath};Version=3;Read Only=False;";

            string query =
                "SELECT Account.AccountStatus, Account.CurrentBalance " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE Person.Email = @Mail";

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
                            kontostand.Text = reader["CurrentBalance"].ToString();
                            kontostatus.Text = reader["AccountStatus"].ToString();
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

        private void Konto_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verwaltung_Click(object sender, EventArgs e)
        {
            Kontoverwaltung_Kunde kontoverwaltung_Kunde = new Kontoverwaltung_Kunde(userMail);
            kontoverwaltung_Kunde.Show();
            this.Hide();
        }

        private void history_Click(object sender, EventArgs e)
        {
            KundenHistory kundenHistory = new KundenHistory(userMail);
            kundenHistory.Show();
        }

        private void einzahlen_Click(object sender, EventArgs e)
        {
            Kontobewegungen kontobewegungen = new Kontobewegungen(userMail);
            kontobewegungen.Show();
            this.Hide();
        }

        private void auszahlen_Click(object sender, EventArgs e)
        {
            Kontobewegungen kontobewegungen = new Kontobewegungen(userMail);
            kontobewegungen.Show();
            this.Hide();
        }

        private void kredite_Click(object sender, EventArgs e)
        {
            CustomSoundPlayer.PlayInformationSound();
            MessageBox.Show("...Coming Soon...\n...Maybe...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

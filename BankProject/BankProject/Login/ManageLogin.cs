using BankProject.utils;
using System.Data.SQLite;
using System.Media;
using System.Runtime.InteropServices;

namespace BankProject.Login
{
    internal class ManageLogin
    {
        public ManageLogin() { }

        public async Task<bool> CheckLogin(string mail, string pass, string accountType)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT Account.AccountPin " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE Customer.CustomerType = @AccountType " +
                "AND Person.Email = @Email";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    await conn.OpenAsync();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Parameter hinzufügen, um SQL-Injection zu verhindern
                        cmd.Parameters.AddWithValue("@AccountType", accountType);
                        cmd.Parameters.AddWithValue("@Email", mail);

                        object result = await cmd.ExecuteScalarAsync();

                        if (result != null)
                        {
                            string storedPass = result.ToString();

                            // Passwort vergleichen
                            return storedPass == pass;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging der Ausnahme
                MessageBox.Show("Error: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
        }

        public async Task<string> GetName(string mail)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query =
                "SELECT Person.FirstName, Person.LastName " +
                "FROM Person " +
                "WHERE Person.Email = @Email";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    await conn.OpenAsync();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Parameter hinzufügen, um SQL-Injection zu verhindern
                        cmd.Parameters.AddWithValue("@Email", mail);

                        using (SQLiteDataReader reader = (SQLiteDataReader)await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                return $"{firstName} {lastName}";
                            }
                            else
                            {
                                return ""; // Kein Ergebnis gefunden
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Logging der Ausnahme
                CustomSoundPlayer.PlayErrorSound();
                MessageBox.Show("Error: " + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }
    }
}

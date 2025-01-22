using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.utils.export
{
    internal class ExportToExcel
    {
        public ExportToExcel() { }

        public void ExportToFile(DataGridView grid, string mail = null, string fullname = null)
        {
            if (string.IsNullOrEmpty(mail) && string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Bitte geben Sie entweder eine E-Mail oder einen vollständigen Namen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "utils", "database", "database.db");
            string connectionString = $"Data Source={databasePath};Version=3;";

            string query = 
                "SELECT Person.FirstName, Person.LastName, Person.Email, Account.CurrentBalance " +
                "FROM Person " +
                "JOIN Customer ON Person.PersonID = Customer.PersonID " +
                "JOIN Account ON Customer.CustomerID = Account.CustomerID " +
                "WHERE ";

            if (!string.IsNullOrEmpty(mail))
            {
                query += "Person.Email = @Identifier";
            }
            else if (!string.IsNullOrEmpty(fullname))
            {
                query += "Person.FirstName = @FirstName AND Person.LastName = @LastName";
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(mail))
                    {
                        command.Parameters.AddWithValue("@Identifier", mail);
                    }
                    else if (!string.IsNullOrEmpty(fullname))
                    {
                        string[] names = fullname.Split(' ', 2);
                        if (names.Length != 2)
                        {
                            MessageBox.Show("Der vollständige Name muss Vor- und Nachname enthalten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        command.Parameters.AddWithValue("@FirstName", names[0]);
                        command.Parameters.AddWithValue("@LastName", names[1]);
                    }

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Benutzer nicht gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        string email = reader["Email"].ToString();
                        string currentBalance = reader["CurrentBalance"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel-Dateien (*.xlsx)|*.xlsx",
                            Title = "Speichern unter",
                            FileName = "Export.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                            using (ExcelPackage package = new ExcelPackage())
                            {                                
                                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Export");

                                // Benutzerinformationen hinzufügen
                                worksheet.Cells[1, 1].Value = "Vorname";
                                worksheet.Cells[1, 2].Value = "Nachname";
                                worksheet.Cells[1, 3].Value = "E-Mail";
                                worksheet.Cells[1, 4].Value = "Kontostand";
                                worksheet.Cells[2, 1].Value = firstName;
                                worksheet.Cells[2, 2].Value = lastName;
                                worksheet.Cells[2, 3].Value = email;
                                worksheet.Cells[2, 4].Value = currentBalance;

                                // Tabellenkopf hinzufügen
                                for (int i = 0; i < grid.Columns.Count; i++)
                                {
                                    worksheet.Cells[4, i + 1].Value = grid.Columns[i].HeaderText;
                                }

                                // Daten aus dem DataGridView hinzufügen
                                for (int row = 0; row < grid.Rows.Count; row++)
                                {
                                    for (int col = 0; col < grid.Columns.Count; col++)
                                    {
                                        worksheet.Cells[row + 5, col + 1].Value = grid.Rows[row].Cells[col].Value;
                                    }
                                }

                                // Datei speichern
                                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                                package.SaveAs(fileInfo);

                                CustomSoundPlayer.PlaySuccessSound();
                                MessageBox.Show("Export erfolgreich!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}

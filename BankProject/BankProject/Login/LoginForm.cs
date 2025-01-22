using BankProject.Angestellter.Main;
using BankProject.Login;
using BankProject.utils;
using System.Text;

namespace BankProject
{
    public partial class LoginForm : Form
    {
        private static LoginForm instance;

        public static LoginForm GetInstance()
        {
            return instance;
        }

        public LoginForm()
        {
            InitializeComponent();

            instance = this;

            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoginData");
            string fullPath = Path.Combine(directoryPath, "SavedLogin.txt");

            if (Directory.Exists(directoryPath))
            {
                string[] lines = File.ReadAllLines(fullPath);
                login_mail.Text = lines[0];
                login_password.Text = lines[1];
            }
        }

        private async void login_Click(object sender, EventArgs e)
        {
            string accountType = login_comboBox.Text;
            string mail = login_mail.Text;
            string pass = login_password.Text;
            bool safeData = remember_checkbox.Checked;

            ManageLogin manageLogin = new ManageLogin();

            if (await manageLogin.CheckLogin(mail, pass, accountType))
            {
                if (safeData)
                {
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoginData");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string fullPath = Path.Combine(directoryPath, "SavedLogin.txt");

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine(mail);
                    stringBuilder.AppendLine(pass);
                    File.WriteAllText(fullPath, stringBuilder.ToString());
                }

                if (accountType == "Kunde")
                {
                    CustomSoundPlayer.PlaySuccessSound();
                    Konto konto = new Konto(login_mail.Text);
                    konto.Show();
                    this.Hide();
                }
                else if (accountType == "Mitarbeiter")
                {
                    CustomSoundPlayer.PlaySuccessSound();
                    string name = await manageLogin.GetName(mail);
                    Mitarbeiter mitarbeiter = new Mitarbeiter(name);
                    mitarbeiter.Show();
                    this.Hide();
                }

                login_mail.Text = "";
                login_password.Text = "";
            }
            else
            {
                CustomSoundPlayer.PlayErrorSound();
                Thread.Sleep(500);
                MessageBox.Show("Fehler:\nAccounttyp, Email oder Passwort falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Frage den Benutzer, ob er die Datenbank löschen möchte
            DialogResult result = MessageBox.Show("Möchtest du die Datenbank löschen?\n\nOK = Ja\nCancel = Nein\n\nACHTUNG: Veränderte Daten gehen verloren!",
                                                  "Datenbank löschen?",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Question);

            // Überprüfe, welcher Button geklickt wurde
            if (result == DialogResult.OK)
            {
                // Löschen der Datenbank
                string databasePath = Path.Combine(Path.GetTempPath(), "database.db");
                File.Delete(databasePath);
                CustomSoundPlayer.PlaySuccessSound();
                MessageBox.Show("Datenbank wurde gelöscht...", "Datenbank gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                // Wenn Cancel (Nein) geklickt wurde, mach nichts oder schließe das Fenster
                CustomSoundPlayer.PlayInformationSound();
                MessageBox.Show("Datenbank bleibt erhalten.", "Datenbank nicht gelöscht", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

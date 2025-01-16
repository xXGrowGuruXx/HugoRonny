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

                login_mail.Text = "";
                login_password.Text = "";

                CustomSoundPlayer.PlaySuccessSound();
                if (accountType == "Kunde")
                {
                    Konto konto = new Konto();
                    konto.Show();
                    this.Hide();
                }
                else if (accountType == "Mitarbeiter")
                {
                    string name = await manageLogin.GetName(mail);
                    Mitarbeiter mitarbeiter = new Mitarbeiter(name);
                    mitarbeiter.Show();
                    this.Hide();
                }
            }
            else
            {
                CustomSoundPlayer.PlayErrorSound();
                Thread.Sleep(500);
                MessageBox.Show("Fehler:\nAccounttyp, Email oder Passwort falsch!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

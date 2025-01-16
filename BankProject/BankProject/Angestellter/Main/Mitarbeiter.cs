using BankProject.Angestellter.Bearbeiten;
using BankProject.utils;

namespace BankProject.Angestellter.Main
{
    public partial class Mitarbeiter : Form
    {
        private static Mitarbeiter instance;

        public static Mitarbeiter GetInstance()
        {
            return instance;
        }
        public Mitarbeiter(string name)
        {
            InitializeComponent();
            instance = this;
            mitarbeiter_Name.Text = name;

            CenterMitarbeiterName();
        }

        private void CenterMitarbeiterName()
        {
            // Zentriere das Label auf der X-Achse
            mitarbeiter_Name.Left = (this.ClientSize.Width - mitarbeiter_Name.Width) / 2;
        }

        private void Mitarbeiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
        }

        private void mitarbeiter_Mitarb_bearbeit_Click(object sender, EventArgs e)
        {
            Mitarbeiter_bearb mitarbeiter_Bearbeiten = new Mitarbeiter_bearb();
            mitarbeiter_Bearbeiten.Show();
            this.Hide();
        }

        private void mitarbeiter_Transaktionen_Click(object sender, EventArgs e)
        {
            mitarbeiter_Transaktionen.Show();
            this.Hide();
        }

        private void mitarbeiter_Berichte_Click(object sender, EventArgs e)
        {
            mitarbeiter_Berichte.Show();
            this.Hide();
        }

        private void mitarbeiter_Kreditverwaltung_Click(object sender, EventArgs e)
        {
            mitarbeiter_Kreditverwaltung.Show();
            this.Hide();
        }

        private void mitarbeiter_History_Click(object sender, EventArgs e)
        {
            mitarbeiter_History.Show();
            this.Hide();
        }

        private void mitarbeiter_Logout_Click(object sender, EventArgs e)
        {
            CustomSoundPlayer.PlaySuccessSound();
            this.Close();
        }
    }
}

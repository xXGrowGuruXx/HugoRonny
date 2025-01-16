using BankProject.Angestellter.Bearbeiten;

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
    }
}

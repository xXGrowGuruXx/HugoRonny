using BankProject.Kunde;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}

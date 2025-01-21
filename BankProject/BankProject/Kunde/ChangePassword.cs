using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject.Kunde
{
    public partial class ChangePassword : Form
    {
        private static ChangePassword instance;

        public static ChangePassword GetInstance()
        {
            return instance;
        }

        ManageKontoverwaltung manageKontoverwaltung;
        public ChangePassword(string mail)
        {
            instance = this;

            manageKontoverwaltung = new ManageKontoverwaltung(mail);
            InitializeComponent();

            manageKontoverwaltung.FindPassword(changePass_Aktuell);
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kontoverwaltung_Kunde kontoverwaltung_Kunde = Kontoverwaltung_Kunde.GetInstance();
            kontoverwaltung_Kunde.Show();
        }

        private void changePass_Abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePass_Anwenden_Click(object sender, EventArgs e)
        {
            manageKontoverwaltung.PasswortÄndern(changePass_Aktuell, changePass_NewPass);
        }
    }
}

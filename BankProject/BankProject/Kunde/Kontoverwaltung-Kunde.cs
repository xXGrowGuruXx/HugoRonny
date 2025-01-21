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
    public partial class Kontoverwaltung_Kunde : Form
    {
        ManageKontoverwaltung manageKontoverwaltung;
        public bool isSettingData = true;
        public string userMail = string.Empty;

        private static Kontoverwaltung_Kunde instance;

        public static Kontoverwaltung_Kunde GetInstance()
        {
            return instance;
        }

        public Kontoverwaltung_Kunde(string mail)
        {
            userMail = mail;
            instance = this;

            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += (sender, e) =>
                    {
                        if (!isSettingData)
                            kontoverwaltung_SafeChanges.Visible = true;
                    };
                }
            }

            manageKontoverwaltung = new ManageKontoverwaltung(mail);
            manageKontoverwaltung.SetUserData(kontoverwaltung_Vorname, kontoverwaltung_Nachname, kontoverwaltung_Geburtsdatum, kontoverwaltung_Mail, kontoverwaltung_PhoneNumber, kontoverwaltung_Address, kontoverwaltung_TaxID, kontoverwaltung_SafeChanges);
        }

        private void Kontoverwaltung_Kunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            Konto konto = Konto.GetInstance();
            konto.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kontoverwaltung_SafeChanges_Click(object sender, EventArgs e)
        {
            manageKontoverwaltung.SafeChanges(kontoverwaltung_Vorname, kontoverwaltung_Nachname, kontoverwaltung_Geburtsdatum, kontoverwaltung_Mail, kontoverwaltung_PhoneNumber, kontoverwaltung_Address, kontoverwaltung_TaxID);
        }

        private void del_konto_Click(object sender, EventArgs e)
        {
            manageKontoverwaltung.CloseKonto();
        }

        private void change_pass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(userMail);
            changePassword.Show();
        }
    }
}

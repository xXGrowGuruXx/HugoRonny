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
    public partial class Kontobewegungen : Form
    {
        private ManageKontobewegung manageKontobewegung;
        private string mail = string.Empty;

        private static Kontobewegungen instance;

        public static Kontobewegungen GetInstance()
        {
            return instance;
        }

        public Kontobewegungen(string email)
        {
            instance = this;

            manageKontobewegung = new ManageKontobewegung();
            InitializeComponent();
            mail = email;
            CenterLabels();

            InvisibleAll();
        }

        private void Kontobewegungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Konto konto = Konto.GetInstance();
            konto.SetDatas();
            konto.Show();
        }

        private void Kunde_Transaktionen_zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvisibleAll()
        {
            kontobewegung_Label_TargetIBAN.Visible = false;
            kontobewegung_TargetIBAN.Visible = false;

            kontobewegung_Label_Betrag.Visible = false;
            kontobewegung_Betrag.Visible = false;

            kontobewegung_Label_Restbetrag.Visible = false;
            kontobewegung_Restbetrag.Visible = false;
        }

        private void CenterLabels()
        {
            // Zentriere das Label auf der X-Achse
            kontobewegung_Kontostand.Left = (this.ClientSize.Width - kontobewegung_Kontostand.Width) / 2;
            kontobewegung_Label_TargetIBAN.Left = (this.ClientSize.Width - kontobewegung_Label_TargetIBAN.Width) / 2;
            kontobewegung_Name.Left = (this.ClientSize.Width - kontobewegung_Name.Width) / 2;
            kontobewegung_Label_Kontostand.Left = (this.ClientSize.Width - kontobewegung_Label_Kontostand.Width) / 2;

            kontobewegung_Label_Betrag.Left = (this.ClientSize.Width / 4) - (kontobewegung_Label_Betrag.Width / 2);

            kontobewegung_Label_Restbetrag.Left = (this.ClientSize.Width / 2) + ((this.ClientSize.Width / 2 - kontobewegung_Label_Restbetrag.Width) / 2);
            kontobewegung_Restbetrag.Left = (this.ClientSize.Width / 2) + ((this.ClientSize.Width / 2 - kontobewegung_Restbetrag.Width) / 2);

        }

        private void Kontobewegungen_Load(object sender, EventArgs e)
        {
            manageKontobewegung.SetBalance(mail, kontobewegung_Kontostand);
        }

        private void Kunde_Transaktionen_bestaetigen_Click(object sender, EventArgs e)
        {
            manageKontobewegung.ManageZahlung(mail, kontobewegung_Zahlungsart, kontobewegung_Betrag);
        }

        private void kontobewegung_Betrag_TextChanged(object sender, EventArgs e)
        {
            manageKontobewegung.ShowRestbetrag(mail, kontobewegung_Zahlungsart, kontobewegung_Betrag, kontobewegung_Restbetrag);
        }

        private void kontobewegung_Zahlungsart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kontobewegung_Zahlungsart.Text == "Einzahlen")
            {
                kontobewegung_Label_Betrag.Visible = true;
                kontobewegung_Betrag.Visible = true;

                kontobewegung_Label_Restbetrag.Visible = true;
                kontobewegung_Restbetrag.Visible = true;
            }
            else if (kontobewegung_Zahlungsart.Text == "Auszahlen")
            {
                kontobewegung_Label_TargetIBAN.Visible = true;
                kontobewegung_TargetIBAN.Visible = true;
            }
            else
            {
                InvisibleAll();
            }
        }

        private void kontobewegung_TargetIBAN_TextChanged(object sender, EventArgs e)
        {
            kontobewegung_Label_Betrag.Visible = true;
            kontobewegung_Betrag.Visible = true;

            kontobewegung_Label_Restbetrag.Visible = true;
            kontobewegung_Restbetrag.Visible = true;
        }
    }
}

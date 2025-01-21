using BankProject.Angestellter.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject.Angestellter.Bericht
{
    public partial class Mitarbeiter_Berichte : Form
    {
        private BerichtManager berichtManager;
        public Mitarbeiter_Berichte()
        {
            berichtManager = new BerichtManager();
            InitializeComponent();

            berichtManager.FillComboBoxKunde(bericht_Kunde);
        }

        private void Bericht_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter mitarbeiter = Mitarbeiter.GetInstance();
            mitarbeiter.Show();
        }

        private void bericht_zurueck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bericht_bericht_anzeigen_Click(object sender, EventArgs e)
        {
            string fullName = bericht_Kunde.Text.Trim();
            BerichtManager berichtManager = new BerichtManager();
            berichtManager.ShowKundenHistory(bericht_DataGrid, fullName);
        }
    }
}

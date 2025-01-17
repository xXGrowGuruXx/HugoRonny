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

namespace BankProject.Angestellter.Bearbeiten
{
    public partial class Mitarbeiter_bearb_auswahlmenu : Form
    {
        private static Mitarbeiter_bearb_auswahlmenu instance;

        public static Mitarbeiter_bearb_auswahlmenu GetInstance()
        {
            return instance;
        }

        public Mitarbeiter_bearb_auswahlmenu()
        {
            InitializeComponent();
            instance = this;
        }

        private void Mitarbeiter_bearb_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter mitarbeiter = Mitarbeiter.GetInstance();
            mitarbeiter.Show();
        }

        private void mitarbeiter_bearb_Bearbeiten_Click(object sender, EventArgs e)
        {
            BearbeitenForm bearbeitenForm = new BearbeitenForm();
            bearbeitenForm.Show();
            this.Hide();
        }

        private void mitarbeiter_bearb_Hinzufügen_Click(object sender, EventArgs e)
        {
            AddMitarbeiter addMitarbeiter = new AddMitarbeiter();
            addMitarbeiter.Show();
            this.Hide();
        }
    }
}

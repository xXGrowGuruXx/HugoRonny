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
    public partial class Mitarbeiter_bearb : Form
    {
        public Mitarbeiter_bearb()
        {
            InitializeComponent();
        }

        private void Mitarbeiter_bearb_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter mitarbeiter = Mitarbeiter.GetInstance();
            mitarbeiter.Show();
        }


    }
}

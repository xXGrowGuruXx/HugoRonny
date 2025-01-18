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
    public partial class LöschenForm : Form
    {
        private BearbeitenManager bearbeitenManager;
        public LöschenForm()
        {
            bearbeitenManager = new BearbeitenManager();
            InitializeComponent();

            bearbeitenManager.FillComboBoxMitarbeiter(löschen_MitarbeiterList);
        }

        private void LöschenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter_bearb_auswahlmenu mitarbeiter_Bearb_Auswahlmenu = Mitarbeiter_bearb_auswahlmenu.GetInstance();
            mitarbeiter_Bearb_Auswahlmenu.Show();
        }

        private void löschen_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void löschen_Anwenden_Click(object sender, EventArgs e)
        {
            string fullName = löschen_MitarbeiterList.Text.Trim();
            bearbeitenManager.DeleteMitarbeiter(fullName);
        }
    }
}

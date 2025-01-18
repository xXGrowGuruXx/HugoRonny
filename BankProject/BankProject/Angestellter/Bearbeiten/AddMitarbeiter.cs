using BankProject.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BankProject.Angestellter.Bearbeiten
{
    public partial class AddMitarbeiter : Form
    {
        private BearbeitenManager bearbeitenManager;
        public AddMitarbeiter()
        {
            bearbeitenManager = new BearbeitenManager();
            InitializeComponent();

            bearbeitenManager.FillComboBoxBranch(addMitarbeiter_Branch);
            bearbeitenManager.FillComboBoxPosition(addMitarbeiter_Position);
        }

        private void AddMitarbeiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter_bearb_auswahlmenu mitarbeiter_Bearb_Auswahlmenu = Mitarbeiter_bearb_auswahlmenu.GetInstance();
            mitarbeiter_Bearb_Auswahlmenu.Show();
        }

        private void addMitarbeiter_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMitarbeiter_Agree_Click(object sender, EventArgs e)
        {
            if (addMitarbeiter_Vorname != null && 
                addMitarbeiter_Geburtsdatum != null && 
                addMitarbeiter_Email != null && 
                addMitarbeiter_Phonenumber != null &&
                addMitarbeiter_Adress != null &&
                addMitarbeiter_Tax != null &&
                addMitarbeiter_Branch != null && 
                addMitarbeiter_Position != null)
            {
                string vorname = addMitarbeiter_Vorname.Text.Trim();
                string nachname = addMitarbeiter_Nachname.Text.Trim();
                string geburtsdatum = addMitarbeiter_Geburtsdatum.Text.Trim();
                string email = addMitarbeiter_Email.Text.Trim();
                string phoneNumer = addMitarbeiter_Phonenumber.Text.Trim();
                string adress = addMitarbeiter_Adress.Text.Trim();
                string tax = addMitarbeiter_Tax.Text.Trim();
                string selectedBranch = addMitarbeiter_Branch.SelectedItem.ToString().Trim();
                string selectedPosition = addMitarbeiter_Position.SelectedItem.ToString().Trim();

                bearbeitenManager.SaveNewMitarbeiter(vorname, nachname, geburtsdatum, email, phoneNumer, adress, tax, selectedBranch, selectedPosition);
            }
            else
            {
                CustomSoundPlayer.PlayWarningSound();
                MessageBox.Show("Trage zuerst die erforderlichen Daten ein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

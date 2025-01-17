using BankProject.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject.Angestellter.Bearbeiten
{
    public partial class BearbeitenForm : Form
    {
        private ComboBoxManager comboBoxManager;
        public BearbeitenForm()
        {
            comboBoxManager = new ComboBoxManager();
            InitializeComponent();

            comboBoxManager.FillComboBoxMitarbeiter(bearbeiten_ChooseMitarbeiter);
            comboBoxManager.FillComboBoxBranch(bearbeiten_branch);
            comboBoxManager.FillComboBoxPosition(bearbeiten_position);
        }

        private void BearbeitenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mitarbeiter_bearb_auswahlmenu mitarbeiter_AuswahlMenu = Mitarbeiter_bearb_auswahlmenu.GetInstance();
            mitarbeiter_AuswahlMenu.Show();
        }

        private void bearbeiten_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bearbeiten_ChooseMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bearbeiten_ChooseMitarbeiter.SelectedItem != null)
            {
                string selectedMitarbeiter = bearbeiten_ChooseMitarbeiter.SelectedItem.ToString();
                comboBoxManager.SetDetails(bearbeiten_branch, bearbeiten_position, selectedMitarbeiter);
            }
        }

        private void bearbeiten_SaveSettings_Click(object sender, EventArgs e)
        {
            if (bearbeiten_ChooseMitarbeiter.SelectedItem != null && bearbeiten_position.SelectedItem != null && bearbeiten_branch.SelectedItem != null)
            {
                comboBoxManager.Save(bearbeiten_ChooseMitarbeiter, bearbeiten_branch, bearbeiten_position);
            }
            else
            {
                CustomSoundPlayer.PlayWarningSound();
                MessageBox.Show("Bitte wählen Sie einen Mitarbeiter, eine Filiale und eine Position aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

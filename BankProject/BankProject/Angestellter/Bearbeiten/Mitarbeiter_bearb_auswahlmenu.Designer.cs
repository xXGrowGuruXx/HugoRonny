namespace BankProject.Angestellter.Bearbeiten
{
    partial class Mitarbeiter_bearb_auswahlmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_bearb_auswahlmenu));
            mitarbeiter_bearb_Bearbeiten = new Button();
            mitarbeiter_bearb_Hinzufügen = new Button();
            mitarbeiter_bearb_Loeschen = new Button();
            mitarbeiter_bearb_Zurueck = new Button();
            SuspendLayout();
            // 
            // mitarbeiter_bearb_Bearbeiten
            // 
            mitarbeiter_bearb_Bearbeiten.Location = new Point(95, 84);
            mitarbeiter_bearb_Bearbeiten.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_bearb_Bearbeiten.Name = "mitarbeiter_bearb_Bearbeiten";
            mitarbeiter_bearb_Bearbeiten.Size = new Size(232, 57);
            mitarbeiter_bearb_Bearbeiten.TabIndex = 0;
            mitarbeiter_bearb_Bearbeiten.Text = "Mitarbeiter bearbeiten";
            mitarbeiter_bearb_Bearbeiten.UseVisualStyleBackColor = true;
            mitarbeiter_bearb_Bearbeiten.Click += mitarbeiter_bearb_Bearbeiten_Click;
            // 
            // mitarbeiter_bearb_Hinzufügen
            // 
            mitarbeiter_bearb_Hinzufügen.Location = new Point(95, 189);
            mitarbeiter_bearb_Hinzufügen.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_bearb_Hinzufügen.Name = "mitarbeiter_bearb_Hinzufügen";
            mitarbeiter_bearb_Hinzufügen.Size = new Size(232, 56);
            mitarbeiter_bearb_Hinzufügen.TabIndex = 1;
            mitarbeiter_bearb_Hinzufügen.Text = "Mitarbeiter hinzufügen";
            mitarbeiter_bearb_Hinzufügen.UseVisualStyleBackColor = true;
            // 
            // mitarbeiter_bearb_Loeschen
            // 
            mitarbeiter_bearb_Loeschen.Location = new Point(95, 305);
            mitarbeiter_bearb_Loeschen.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_bearb_Loeschen.Name = "mitarbeiter_bearb_Loeschen";
            mitarbeiter_bearb_Loeschen.Size = new Size(232, 53);
            mitarbeiter_bearb_Loeschen.TabIndex = 2;
            mitarbeiter_bearb_Loeschen.Text = "Mitarbeiter löschen";
            mitarbeiter_bearb_Loeschen.UseVisualStyleBackColor = true;
            // 
            // mitarbeiter_bearb_Zurueck
            // 
            mitarbeiter_bearb_Zurueck.Location = new Point(157, 427);
            mitarbeiter_bearb_Zurueck.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_bearb_Zurueck.Name = "mitarbeiter_bearb_Zurueck";
            mitarbeiter_bearb_Zurueck.Size = new Size(86, 31);
            mitarbeiter_bearb_Zurueck.TabIndex = 3;
            mitarbeiter_bearb_Zurueck.Text = "Zurück";
            mitarbeiter_bearb_Zurueck.UseVisualStyleBackColor = true;
            // 
            // Mitarbeiter_bearb_auswahlmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 473);
            Controls.Add(mitarbeiter_bearb_Zurueck);
            Controls.Add(mitarbeiter_bearb_Loeschen);
            Controls.Add(mitarbeiter_bearb_Hinzufügen);
            Controls.Add(mitarbeiter_bearb_Bearbeiten);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mitarbeiter_bearb_auswahlmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter bearbeiten";
            FormClosing += Mitarbeiter_bearb_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button mitarbeiter_bearb_Bearbeiten;
        private Button mitarbeiter_bearb_Hinzufügen;
        private Button mitarbeiter_bearb_Loeschen;
        private Button mitarbeiter_bearb_Zurueck;
    }
}
namespace BankProject.Angestellter.Transaktionen
{
    partial class Transaktionen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaktionen));
            mitarb_transakt_Kunde = new ComboBox();
            transaktionen_einzahlen = new Button();
            mitarb_transakt_Auszahlen = new Button();
            mitarbeit_transakt_Ueberweisung = new Button();
            mitarbeit_transakt_Zurueck = new Button();
            SuspendLayout();
            // 
            // mitarb_transakt_Kunde
            // 
            mitarb_transakt_Kunde.FormattingEnabled = true;
            mitarb_transakt_Kunde.Location = new Point(134, 27);
            mitarb_transakt_Kunde.Margin = new Padding(3, 4, 3, 4);
            mitarb_transakt_Kunde.Name = "mitarb_transakt_Kunde";
            mitarb_transakt_Kunde.Size = new Size(138, 28);
            mitarb_transakt_Kunde.TabIndex = 0;
            mitarb_transakt_Kunde.Text = "Kunde";
            // 
            // transaktionen_einzahlen
            // 
            transaktionen_einzahlen.Location = new Point(134, 135);
            transaktionen_einzahlen.Margin = new Padding(3, 4, 3, 4);
            transaktionen_einzahlen.Name = "transaktionen_einzahlen";
            transaktionen_einzahlen.Size = new Size(138, 57);
            transaktionen_einzahlen.TabIndex = 1;
            transaktionen_einzahlen.Text = "Einzahlen";
            transaktionen_einzahlen.UseVisualStyleBackColor = true;
            // 
            // mitarb_transakt_Auszahlen
            // 
            mitarb_transakt_Auszahlen.Location = new Point(134, 220);
            mitarb_transakt_Auszahlen.Margin = new Padding(3, 4, 3, 4);
            mitarb_transakt_Auszahlen.Name = "mitarb_transakt_Auszahlen";
            mitarb_transakt_Auszahlen.Size = new Size(138, 57);
            mitarb_transakt_Auszahlen.TabIndex = 2;
            mitarb_transakt_Auszahlen.Text = "Auszahlen";
            mitarb_transakt_Auszahlen.UseVisualStyleBackColor = true;
            // 
            // mitarbeit_transakt_Ueberweisung
            // 
            mitarbeit_transakt_Ueberweisung.Location = new Point(134, 311);
            mitarbeit_transakt_Ueberweisung.Margin = new Padding(3, 4, 3, 4);
            mitarbeit_transakt_Ueberweisung.Name = "mitarbeit_transakt_Ueberweisung";
            mitarbeit_transakt_Ueberweisung.Size = new Size(138, 57);
            mitarbeit_transakt_Ueberweisung.TabIndex = 3;
            mitarbeit_transakt_Ueberweisung.Text = "Überweisung";
            mitarbeit_transakt_Ueberweisung.UseVisualStyleBackColor = true;
            // 
            // mitarbeit_transakt_Zurueck
            // 
            mitarbeit_transakt_Zurueck.Location = new Point(134, 427);
            mitarbeit_transakt_Zurueck.Margin = new Padding(3, 4, 3, 4);
            mitarbeit_transakt_Zurueck.Name = "mitarbeit_transakt_Zurueck";
            mitarbeit_transakt_Zurueck.Size = new Size(138, 31);
            mitarbeit_transakt_Zurueck.TabIndex = 4;
            mitarbeit_transakt_Zurueck.Text = "Zurück";
            mitarbeit_transakt_Zurueck.UseVisualStyleBackColor = true;
            // 
            // Transaktionen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 473);
            Controls.Add(mitarbeit_transakt_Zurueck);
            Controls.Add(mitarbeit_transakt_Ueberweisung);
            Controls.Add(mitarb_transakt_Auszahlen);
            Controls.Add(transaktionen_einzahlen);
            Controls.Add(mitarb_transakt_Kunde);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Transaktionen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaktionen";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox mitarb_transakt_Kunde;
        private Button transaktionen_einzahlen;
        private Button mitarb_transakt_Auszahlen;
        private Button mitarbeit_transakt_Ueberweisung;
        private Button mitarbeit_transakt_Zurueck;
    }
}
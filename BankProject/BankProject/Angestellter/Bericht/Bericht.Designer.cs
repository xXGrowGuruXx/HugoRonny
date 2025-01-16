namespace BankProject.Angestellter.Bericht
{
    partial class Bericht
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bericht));
            bericht_listBox = new ListBox();
            bericht_Kunde = new ComboBox();
            bericht_bericht_anzeigen = new Button();
            bericht_exportieren = new Button();
            bericht_zurueck = new Button();
            SuspendLayout();
            // 
            // bericht_listBox
            // 
            bericht_listBox.FormattingEnabled = true;
            bericht_listBox.Location = new Point(46, 83);
            bericht_listBox.Margin = new Padding(3, 4, 3, 4);
            bericht_listBox.Name = "bericht_listBox";
            bericht_listBox.Size = new Size(321, 324);
            bericht_listBox.TabIndex = 0;
            bericht_listBox.Tag = "Bericht";
            // 
            // bericht_Kunde
            // 
            bericht_Kunde.FormattingEnabled = true;
            bericht_Kunde.Location = new Point(46, 31);
            bericht_Kunde.Margin = new Padding(3, 4, 3, 4);
            bericht_Kunde.Name = "bericht_Kunde";
            bericht_Kunde.Size = new Size(138, 28);
            bericht_Kunde.TabIndex = 1;
            bericht_Kunde.Tag = "";
            bericht_Kunde.Text = "Kunde";
            // 
            // bericht_bericht_anzeigen
            // 
            bericht_bericht_anzeigen.Location = new Point(231, 31);
            bericht_bericht_anzeigen.Margin = new Padding(3, 4, 3, 4);
            bericht_bericht_anzeigen.Name = "bericht_bericht_anzeigen";
            bericht_bericht_anzeigen.Size = new Size(136, 31);
            bericht_bericht_anzeigen.TabIndex = 2;
            bericht_bericht_anzeigen.Text = "anzeigen";
            bericht_bericht_anzeigen.UseVisualStyleBackColor = true;
            // 
            // bericht_exportieren
            // 
            bericht_exportieren.Location = new Point(46, 424);
            bericht_exportieren.Margin = new Padding(3, 4, 3, 4);
            bericht_exportieren.Name = "bericht_exportieren";
            bericht_exportieren.Size = new Size(138, 31);
            bericht_exportieren.TabIndex = 3;
            bericht_exportieren.Text = "exportieren";
            bericht_exportieren.UseVisualStyleBackColor = true;
            // 
            // bericht_zurueck
            // 
            bericht_zurueck.Location = new Point(231, 424);
            bericht_zurueck.Margin = new Padding(3, 4, 3, 4);
            bericht_zurueck.Name = "bericht_zurueck";
            bericht_zurueck.Size = new Size(136, 31);
            bericht_zurueck.TabIndex = 4;
            bericht_zurueck.Text = "Zurück";
            bericht_zurueck.UseVisualStyleBackColor = true;
            // 
            // Bericht
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 473);
            Controls.Add(bericht_zurueck);
            Controls.Add(bericht_exportieren);
            Controls.Add(bericht_bericht_anzeigen);
            Controls.Add(bericht_Kunde);
            Controls.Add(bericht_listBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bericht";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bericht";
            ResumeLayout(false);
        }

        #endregion

        private ListBox bericht_listBox;
        private ComboBox bericht_Kunde;
        private Button bericht_bericht_anzeigen;
        private Button bericht_exportieren;
        private Button bericht_zurueck;
    }
}
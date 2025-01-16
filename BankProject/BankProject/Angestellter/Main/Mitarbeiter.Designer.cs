namespace BankProject.Angestellter.Main
{
    partial class Mitarbeiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter));
            mitarbeiter_Mitarb_bearbeit = new Button();
            mitarbeiter_Transaktionen = new Button();
            mitarbeiter_Berichte = new Button();
            mitarbeiter_Kreditverwaltung = new Button();
            mitarbeiter_Logout = new Button();
            mitarbeiter_Name = new Label();
            mitarbeiter_History = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // mitarbeiter_Mitarb_bearbeit
            // 
            mitarbeiter_Mitarb_bearbeit.Location = new Point(80, 131);
            mitarbeiter_Mitarb_bearbeit.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_Mitarb_bearbeit.Name = "mitarbeiter_Mitarb_bearbeit";
            mitarbeiter_Mitarb_bearbeit.Size = new Size(243, 31);
            mitarbeiter_Mitarb_bearbeit.TabIndex = 1;
            mitarbeiter_Mitarb_bearbeit.Text = "Mitarbeiter bearbeiten";
            mitarbeiter_Mitarb_bearbeit.UseVisualStyleBackColor = true;
            mitarbeiter_Mitarb_bearbeit.Click += mitarbeiter_Mitarb_bearbeit_Click;
            // 
            // mitarbeiter_Transaktionen
            // 
            mitarbeiter_Transaktionen.Location = new Point(80, 184);
            mitarbeiter_Transaktionen.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_Transaktionen.Name = "mitarbeiter_Transaktionen";
            mitarbeiter_Transaktionen.Size = new Size(243, 31);
            mitarbeiter_Transaktionen.TabIndex = 2;
            mitarbeiter_Transaktionen.Text = "Transaktionen";
            mitarbeiter_Transaktionen.UseVisualStyleBackColor = true;
            mitarbeiter_Transaktionen.Click += mitarbeiter_Transaktionen_Click;
            // 
            // mitarbeiter_Berichte
            // 
            mitarbeiter_Berichte.Location = new Point(80, 240);
            mitarbeiter_Berichte.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_Berichte.Name = "mitarbeiter_Berichte";
            mitarbeiter_Berichte.Size = new Size(243, 31);
            mitarbeiter_Berichte.TabIndex = 3;
            mitarbeiter_Berichte.Text = "Berichte";
            mitarbeiter_Berichte.UseVisualStyleBackColor = true;
            mitarbeiter_Berichte.Click += mitarbeiter_Berichte_Click;
            // 
            // mitarbeiter_Kreditverwaltung
            // 
            mitarbeiter_Kreditverwaltung.Location = new Point(80, 299);
            mitarbeiter_Kreditverwaltung.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_Kreditverwaltung.Name = "mitarbeiter_Kreditverwaltung";
            mitarbeiter_Kreditverwaltung.Size = new Size(243, 31);
            mitarbeiter_Kreditverwaltung.TabIndex = 4;
            mitarbeiter_Kreditverwaltung.Text = "Kreditverwaltung";
            mitarbeiter_Kreditverwaltung.UseVisualStyleBackColor = true;
            mitarbeiter_Kreditverwaltung.Click += mitarbeiter_Kreditverwaltung_Click;
            // 
            // mitarbeiter_Logout
            // 
            mitarbeiter_Logout.Location = new Point(80, 419);
            mitarbeiter_Logout.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_Logout.Name = "mitarbeiter_Logout";
            mitarbeiter_Logout.Size = new Size(243, 31);
            mitarbeiter_Logout.TabIndex = 5;
            mitarbeiter_Logout.Text = "Logout";
            mitarbeiter_Logout.UseVisualStyleBackColor = true;
            mitarbeiter_Logout.Click += mitarbeiter_Logout_Click;
            // 
            // mitarbeiter_Name
            // 
            mitarbeiter_Name.AutoSize = true;
            mitarbeiter_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mitarbeiter_Name.Location = new Point(110, 70);
            mitarbeiter_Name.Name = "mitarbeiter_Name";
            mitarbeiter_Name.Size = new Size(193, 37);
            mitarbeiter_Name.TabIndex = 6;
            mitarbeiter_Name.Text = "Mitarbeiter Name";
            mitarbeiter_Name.TextAlign = ContentAlignment.MiddleCenter;
            mitarbeiter_Name.UseCompatibleTextRendering = true;
            // 
            // mitarbeiter_History
            // 
            mitarbeiter_History.Location = new Point(80, 351);
            mitarbeiter_History.Margin = new Padding(3, 4, 3, 4);
            mitarbeiter_History.Name = "mitarbeiter_History";
            mitarbeiter_History.Size = new Size(243, 31);
            mitarbeiter_History.TabIndex = 7;
            mitarbeiter_History.Text = "History Mitarbeiter";
            mitarbeiter_History.UseVisualStyleBackColor = true;
            mitarbeiter_History.Click += mitarbeiter_History_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 41);
            label1.TabIndex = 8;
            label1.Text = "Mitarbeiter Hub";
            // 
            // Mitarbeiter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 477);
            Controls.Add(label1);
            Controls.Add(mitarbeiter_History);
            Controls.Add(mitarbeiter_Name);
            Controls.Add(mitarbeiter_Logout);
            Controls.Add(mitarbeiter_Kreditverwaltung);
            Controls.Add(mitarbeiter_Berichte);
            Controls.Add(mitarbeiter_Transaktionen);
            Controls.Add(mitarbeiter_Mitarb_bearbeit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Mitarbeiter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter";
            FormClosing += Mitarbeiter_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button mitarbeiter_Mitarb_bearbeit;
        private Button mitarbeiter_Transaktionen;
        private Button mitarbeiter_Berichte;
        private Button mitarbeiter_Kreditverwaltung;
        private Button mitarbeiter_Logout;
        private Label mitarbeiter_Name;
        private Button mitarbeiter_History;
        private Label label1;
    }
}
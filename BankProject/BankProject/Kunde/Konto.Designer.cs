namespace BankProject
{
    partial class Konto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konto));
            label1 = new Label();
            kontostatus = new Label();
            label2 = new Label();
            kontostand = new Label();
            history = new Button();
            einzahlen = new Button();
            auszahlen = new Button();
            logout = new Button();
            verwaltung = new Button();
            kredite = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(543, 35);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Kontostatus:";
            // 
            // kontostatus
            // 
            kontostatus.AutoSize = true;
            kontostatus.BackColor = SystemColors.HighlightText;
            kontostatus.Location = new Point(670, 35);
            kontostatus.Name = "kontostatus";
            kontostatus.Size = new Size(68, 28);
            kontostatus.TabIndex = 1;
            kontostatus.Text = "closed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 2;
            label2.Text = "Kontostand:";
            // 
            // kontostand
            // 
            kontostand.AutoSize = true;
            kontostand.BackColor = SystemColors.HighlightText;
            kontostand.Location = new Point(136, 35);
            kontostand.Name = "kontostand";
            kontostand.Size = new Size(56, 28);
            kontostand.TabIndex = 3;
            kontostand.Text = "1000";
            // 
            // history
            // 
            history.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.Location = new Point(558, 95);
            history.Name = "history";
            history.Size = new Size(180, 46);
            history.TabIndex = 4;
            history.Text = "History";
            history.UseVisualStyleBackColor = true;
            history.Click += history_Click;
            // 
            // einzahlen
            // 
            einzahlen.Location = new Point(12, 100);
            einzahlen.Name = "einzahlen";
            einzahlen.Size = new Size(180, 43);
            einzahlen.TabIndex = 6;
            einzahlen.Text = "Einzahlen";
            einzahlen.UseVisualStyleBackColor = true;
            // 
            // auszahlen
            // 
            auszahlen.Location = new Point(12, 164);
            auszahlen.Name = "auszahlen";
            auszahlen.Size = new Size(180, 43);
            auszahlen.TabIndex = 8;
            auszahlen.Text = "Auszahlen";
            auszahlen.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(558, 164);
            logout.Name = "logout";
            logout.Size = new Size(180, 43);
            logout.TabIndex = 11;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // verwaltung
            // 
            verwaltung.Location = new Point(283, 95);
            verwaltung.Name = "verwaltung";
            verwaltung.Size = new Size(209, 48);
            verwaltung.TabIndex = 12;
            verwaltung.Text = "Konto verwalten";
            verwaltung.UseVisualStyleBackColor = true;
            verwaltung.Click += verwaltung_Click;
            // 
            // kredite
            // 
            kredite.Location = new Point(283, 164);
            kredite.Name = "kredite";
            kredite.Size = new Size(209, 43);
            kredite.TabIndex = 13;
            kredite.Text = "Kredite";
            kredite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 22);
            label3.Name = "label3";
            label3.Size = new Size(231, 41);
            label3.TabIndex = 14;
            label3.Text = "Konto Übersicht";
            // 
            // Konto
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            ClientSize = new Size(767, 237);
            Controls.Add(label3);
            Controls.Add(kredite);
            Controls.Add(verwaltung);
            Controls.Add(logout);
            Controls.Add(auszahlen);
            Controls.Add(einzahlen);
            Controls.Add(history);
            Controls.Add(kontostand);
            Controls.Add(label2);
            Controls.Add(kontostatus);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Konto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Konto";
            FormClosing += Konto_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label kontostatus;
        private Label label2;
        private Label kontostand;
        private Button history;
        private Button einzahlen;
        private Button auszahlen;
        private Button logout;
        private Button verwaltung;
        private Button kredite;
        private Label label3;
    }
}
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
            überweisung = new Button();
            einzahlen = new Button();
            auszahlen = new Button();
            logout = new Button();
            change_pass = new Button();
            verwaltung = new Button();
            kredite = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Kontostatus:";
            // 
            // kontostatus
            // 
            kontostatus.AutoSize = true;
            kontostatus.BackColor = SystemColors.HighlightText;
            kontostatus.Location = new Point(136, 9);
            kontostatus.Name = "kontostatus";
            kontostatus.Size = new Size(68, 28);
            kontostatus.TabIndex = 1;
            kontostatus.Text = "closed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 2;
            label2.Text = "Kontostand:";
            // 
            // kontostand
            // 
            kontostand.AutoSize = true;
            kontostand.BackColor = SystemColors.HighlightText;
            kontostand.Location = new Point(136, 58);
            kontostand.Name = "kontostand";
            kontostand.Size = new Size(56, 28);
            kontostand.TabIndex = 3;
            kontostand.Text = "1000";
            // 
            // history
            // 
            history.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            history.Location = new Point(734, 9);
            history.Name = "history";
            history.Size = new Size(129, 46);
            history.TabIndex = 4;
            history.Text = "History";
            history.UseVisualStyleBackColor = true;
            // 
            // überweisung
            // 
            überweisung.Location = new Point(12, 113);
            überweisung.Name = "überweisung";
            überweisung.Size = new Size(180, 43);
            überweisung.TabIndex = 5;
            überweisung.Text = "Überweisung";
            überweisung.UseVisualStyleBackColor = true;
            // 
            // einzahlen
            // 
            einzahlen.Location = new Point(363, 113);
            einzahlen.Name = "einzahlen";
            einzahlen.Size = new Size(180, 43);
            einzahlen.TabIndex = 6;
            einzahlen.Text = "Einzahlen";
            einzahlen.UseVisualStyleBackColor = true;
            // 
            // auszahlen
            // 
            auszahlen.Location = new Point(683, 113);
            auszahlen.Name = "auszahlen";
            auszahlen.Size = new Size(180, 43);
            auszahlen.TabIndex = 8;
            auszahlen.Text = "Auszahlen";
            auszahlen.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(683, 186);
            logout.Name = "logout";
            logout.Size = new Size(180, 43);
            logout.TabIndex = 11;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            // 
            // change_pass
            // 
            change_pass.Location = new Point(12, 186);
            change_pass.Name = "change_pass";
            change_pass.Size = new Size(180, 43);
            change_pass.TabIndex = 10;
            change_pass.Text = "Passwort ändern";
            change_pass.UseVisualStyleBackColor = true;
            // 
            // verwaltung
            // 
            verwaltung.Location = new Point(352, 9);
            verwaltung.Name = "verwaltung";
            verwaltung.Size = new Size(209, 48);
            verwaltung.TabIndex = 12;
            verwaltung.Text = "Konto verwalten";
            verwaltung.UseVisualStyleBackColor = true;
            // 
            // kredite
            // 
            kredite.Location = new Point(363, 186);
            kredite.Name = "kredite";
            kredite.Size = new Size(180, 43);
            kredite.TabIndex = 13;
            kredite.Text = "Kredite";
            kredite.UseVisualStyleBackColor = true;
            // 
            // Konto
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(875, 237);
            Controls.Add(kredite);
            Controls.Add(verwaltung);
            Controls.Add(logout);
            Controls.Add(change_pass);
            Controls.Add(auszahlen);
            Controls.Add(einzahlen);
            Controls.Add(überweisung);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label kontostatus;
        private Label label2;
        private Label kontostand;
        private Button history;
        private Button überweisung;
        private Button einzahlen;
        private Button auszahlen;
        private Button logout;
        private Button change_pass;
        private Button verwaltung;
        private Button kredite;
    }
}
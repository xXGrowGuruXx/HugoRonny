namespace BankProject.Kunde
{
    partial class Kontoverwaltung_Kunde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kontoverwaltung_Kunde));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kontoverwaltung_Vorname = new TextBox();
            kontoverwaltung_Nachname = new TextBox();
            kontoverwaltung_Geburtsdatum = new TextBox();
            label4 = new Label();
            kontoverwaltung_PhoneNumber = new TextBox();
            label5 = new Label();
            kontoverwaltung_Mail = new TextBox();
            label6 = new Label();
            kontoverwaltung_TaxID = new TextBox();
            label7 = new Label();
            kontoverwaltung_Address = new TextBox();
            label8 = new Label();
            del_konto = new Button();
            back = new Button();
            change_pass = new Button();
            kontoverwaltung_SafeChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 0;
            label1.Text = "Kontoverwaltung";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(280, 28);
            label2.TabIndex = 1;
            label2.Text = "                   Vorname                   ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Location = new Point(6, 132);
            label3.Name = "label3";
            label3.Size = new Size(280, 28);
            label3.TabIndex = 2;
            label3.Text = "                 Nachname                  ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kontoverwaltung_Vorname
            // 
            kontoverwaltung_Vorname.BackColor = SystemColors.HighlightText;
            kontoverwaltung_Vorname.ImeMode = ImeMode.NoControl;
            kontoverwaltung_Vorname.Location = new Point(309, 83);
            kontoverwaltung_Vorname.Name = "kontoverwaltung_Vorname";
            kontoverwaltung_Vorname.Size = new Size(375, 34);
            kontoverwaltung_Vorname.TabIndex = 3;
            kontoverwaltung_Vorname.TextAlign = HorizontalAlignment.Center;
            // 
            // kontoverwaltung_Nachname
            // 
            kontoverwaltung_Nachname.BackColor = SystemColors.HighlightText;
            kontoverwaltung_Nachname.Location = new Point(309, 132);
            kontoverwaltung_Nachname.Name = "kontoverwaltung_Nachname";
            kontoverwaltung_Nachname.Size = new Size(375, 34);
            kontoverwaltung_Nachname.TabIndex = 4;
            kontoverwaltung_Nachname.TextAlign = HorizontalAlignment.Center;
            // 
            // kontoverwaltung_Geburtsdatum
            // 
            kontoverwaltung_Geburtsdatum.BackColor = SystemColors.HighlightText;
            kontoverwaltung_Geburtsdatum.Location = new Point(309, 180);
            kontoverwaltung_Geburtsdatum.Name = "kontoverwaltung_Geburtsdatum";
            kontoverwaltung_Geburtsdatum.ReadOnly = true;
            kontoverwaltung_Geburtsdatum.Size = new Size(375, 34);
            kontoverwaltung_Geburtsdatum.TabIndex = 6;
            kontoverwaltung_Geburtsdatum.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Location = new Point(6, 180);
            label4.Name = "label4";
            label4.Size = new Size(278, 28);
            label4.TabIndex = 5;
            label4.Text = "              Geburtsdatum              ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kontoverwaltung_PhoneNumber
            // 
            kontoverwaltung_PhoneNumber.BackColor = SystemColors.HighlightText;
            kontoverwaltung_PhoneNumber.Location = new Point(309, 274);
            kontoverwaltung_PhoneNumber.Name = "kontoverwaltung_PhoneNumber";
            kontoverwaltung_PhoneNumber.Size = new Size(375, 34);
            kontoverwaltung_PhoneNumber.TabIndex = 10;
            kontoverwaltung_PhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HighlightText;
            label5.Location = new Point(6, 274);
            label5.Name = "label5";
            label5.Size = new Size(276, 28);
            label5.TabIndex = 9;
            label5.Text = "            Telefon Nummer            ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kontoverwaltung_Mail
            // 
            kontoverwaltung_Mail.BackColor = SystemColors.HighlightText;
            kontoverwaltung_Mail.Location = new Point(309, 227);
            kontoverwaltung_Mail.Name = "kontoverwaltung_Mail";
            kontoverwaltung_Mail.Size = new Size(375, 34);
            kontoverwaltung_Mail.TabIndex = 8;
            kontoverwaltung_Mail.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.HighlightText;
            label6.Location = new Point(6, 227);
            label6.Name = "label6";
            label6.Size = new Size(277, 28);
            label6.TabIndex = 7;
            label6.Text = "              Email Adresse               ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kontoverwaltung_TaxID
            // 
            kontoverwaltung_TaxID.BackColor = SystemColors.HighlightText;
            kontoverwaltung_TaxID.Location = new Point(309, 370);
            kontoverwaltung_TaxID.Name = "kontoverwaltung_TaxID";
            kontoverwaltung_TaxID.ReadOnly = true;
            kontoverwaltung_TaxID.Size = new Size(375, 34);
            kontoverwaltung_TaxID.TabIndex = 14;
            kontoverwaltung_TaxID.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.HighlightText;
            label7.Location = new Point(6, 370);
            label7.Name = "label7";
            label7.Size = new Size(275, 28);
            label7.TabIndex = 13;
            label7.Text = "Steuerindentifikationsnummer";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kontoverwaltung_Address
            // 
            kontoverwaltung_Address.BackColor = SystemColors.HighlightText;
            kontoverwaltung_Address.Location = new Point(309, 323);
            kontoverwaltung_Address.Name = "kontoverwaltung_Address";
            kontoverwaltung_Address.Size = new Size(375, 34);
            kontoverwaltung_Address.TabIndex = 12;
            kontoverwaltung_Address.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.HighlightText;
            label8.Location = new Point(6, 323);
            label8.Name = "label8";
            label8.Size = new Size(275, 28);
            label8.TabIndex = 11;
            label8.Text = "                   Adresse                    ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // del_konto
            // 
            del_konto.Location = new Point(510, 428);
            del_konto.Name = "del_konto";
            del_konto.Size = new Size(174, 46);
            del_konto.TabIndex = 15;
            del_konto.Text = "Konto löschen";
            del_konto.UseVisualStyleBackColor = true;
            del_konto.Click += del_konto_Click;
            // 
            // back
            // 
            back.Location = new Point(245, 491);
            back.Name = "back";
            back.Size = new Size(174, 46);
            back.TabIndex = 16;
            back.Text = "Zurück";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // change_pass
            // 
            change_pass.Location = new Point(6, 428);
            change_pass.Name = "change_pass";
            change_pass.Size = new Size(174, 46);
            change_pass.TabIndex = 17;
            change_pass.Text = "Passwort ändern";
            change_pass.UseVisualStyleBackColor = true;
            change_pass.Click += change_pass_Click;
            // 
            // kontoverwaltung_SafeChanges
            // 
            kontoverwaltung_SafeChanges.Location = new Point(223, 428);
            kontoverwaltung_SafeChanges.Name = "kontoverwaltung_SafeChanges";
            kontoverwaltung_SafeChanges.Size = new Size(226, 46);
            kontoverwaltung_SafeChanges.TabIndex = 18;
            kontoverwaltung_SafeChanges.Text = "Änderungen speichern";
            kontoverwaltung_SafeChanges.UseVisualStyleBackColor = true;
            kontoverwaltung_SafeChanges.Visible = false;
            kontoverwaltung_SafeChanges.Click += kontoverwaltung_SafeChanges_Click;
            // 
            // Kontoverwaltung_Kunde
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(696, 549);
            Controls.Add(kontoverwaltung_SafeChanges);
            Controls.Add(change_pass);
            Controls.Add(back);
            Controls.Add(del_konto);
            Controls.Add(kontoverwaltung_TaxID);
            Controls.Add(label7);
            Controls.Add(kontoverwaltung_Address);
            Controls.Add(label8);
            Controls.Add(kontoverwaltung_PhoneNumber);
            Controls.Add(label5);
            Controls.Add(kontoverwaltung_Mail);
            Controls.Add(label6);
            Controls.Add(kontoverwaltung_Geburtsdatum);
            Controls.Add(label4);
            Controls.Add(kontoverwaltung_Nachname);
            Controls.Add(kontoverwaltung_Vorname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Kontoverwaltung_Kunde";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kontoverwaltung";
            FormClosing += Kontoverwaltung_Kunde_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kontoverwaltung_Vorname;
        private TextBox kontoverwaltung_Nachname;
        private TextBox kontoverwaltung_Geburtsdatum;
        private Label label4;
        private TextBox kontoverwaltung_PhoneNumber;
        private Label label5;
        private TextBox kontoverwaltung_Mail;
        private Label label6;
        private TextBox kontoverwaltung_TaxID;
        private Label label7;
        private TextBox kontoverwaltung_Address;
        private Label label8;
        private Button del_konto;
        private Button back;
        private Button change_pass;
        private Button kontoverwaltung_SafeChanges;
    }
}
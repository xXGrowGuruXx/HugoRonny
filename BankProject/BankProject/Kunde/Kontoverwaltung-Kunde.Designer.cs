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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            vorname = new TextBox();
            nachname = new TextBox();
            geburtsdatum = new TextBox();
            label4 = new Label();
            number = new TextBox();
            label5 = new Label();
            mail = new TextBox();
            label6 = new Label();
            taxID = new TextBox();
            label7 = new Label();
            adress = new TextBox();
            label8 = new Label();
            del_konto = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 9);
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
            // vorname
            // 
            vorname.BackColor = SystemColors.HighlightText;
            vorname.Location = new Point(309, 83);
            vorname.Name = "vorname";
            vorname.Size = new Size(375, 34);
            vorname.TabIndex = 3;
            // 
            // nachname
            // 
            nachname.BackColor = SystemColors.HighlightText;
            nachname.Location = new Point(309, 132);
            nachname.Name = "nachname";
            nachname.Size = new Size(375, 34);
            nachname.TabIndex = 4;
            // 
            // geburtsdatum
            // 
            geburtsdatum.BackColor = SystemColors.HighlightText;
            geburtsdatum.Location = new Point(309, 180);
            geburtsdatum.Name = "geburtsdatum";
            geburtsdatum.Size = new Size(375, 34);
            geburtsdatum.TabIndex = 6;
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
            // number
            // 
            number.BackColor = SystemColors.HighlightText;
            number.Location = new Point(309, 274);
            number.Name = "number";
            number.Size = new Size(375, 34);
            number.TabIndex = 10;
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
            // mail
            // 
            mail.BackColor = SystemColors.HighlightText;
            mail.Location = new Point(309, 227);
            mail.Name = "mail";
            mail.Size = new Size(375, 34);
            mail.TabIndex = 8;
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
            // taxID
            // 
            taxID.BackColor = SystemColors.HighlightText;
            taxID.Location = new Point(309, 370);
            taxID.Name = "taxID";
            taxID.Size = new Size(375, 34);
            taxID.TabIndex = 14;
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
            // adress
            // 
            adress.BackColor = SystemColors.HighlightText;
            adress.Location = new Point(309, 323);
            adress.Name = "adress";
            adress.Size = new Size(375, 34);
            adress.TabIndex = 12;
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
            del_konto.Location = new Point(216, 419);
            del_konto.Name = "del_konto";
            del_konto.Size = new Size(174, 46);
            del_konto.TabIndex = 15;
            del_konto.Text = "Konto löschen";
            del_konto.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            back.Location = new Point(216, 481);
            back.Name = "back";
            back.Size = new Size(174, 46);
            back.TabIndex = 16;
            back.Text = "Zurück";
            back.UseVisualStyleBackColor = true;
            // 
            // Kontoverwaltung_Kunde
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(696, 549);
            Controls.Add(back);
            Controls.Add(del_konto);
            Controls.Add(taxID);
            Controls.Add(label7);
            Controls.Add(adress);
            Controls.Add(label8);
            Controls.Add(number);
            Controls.Add(label5);
            Controls.Add(mail);
            Controls.Add(label6);
            Controls.Add(geburtsdatum);
            Controls.Add(label4);
            Controls.Add(nachname);
            Controls.Add(vorname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Kontoverwaltung_Kunde";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kontoverwaltung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox vorname;
        private TextBox nachname;
        private TextBox geburtsdatum;
        private Label label4;
        private TextBox number;
        private Label label5;
        private TextBox mail;
        private Label label6;
        private TextBox taxID;
        private Label label7;
        private TextBox adress;
        private Label label8;
        private Button del_konto;
        private Button back;
    }
}
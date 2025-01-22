namespace BankProject.Kunde
{
    partial class Kontobewegungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kontobewegungen));
            kontobewegung_Zahlungsart = new ComboBox();
            Kunde_Transaktionen_bestaetigen = new Button();
            kontobewegung_Betrag = new TextBox();
            kontobewegung_TargetIBAN = new TextBox();
            Kunde_Transaktionen_zurueck = new Button();
            kontobewegung_Label_Kontostand = new Label();
            kontobewegung_Name = new Label();
            kontobewegung_Kontostand = new Label();
            kontobewegung_Label_TargetIBAN = new Label();
            kontobewegung_Label_Betrag = new Label();
            kontobewegung_Label_Restbetrag = new Label();
            kontobewegung_Restbetrag = new Label();
            SuspendLayout();
            // 
            // kontobewegung_Zahlungsart
            // 
            kontobewegung_Zahlungsart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Zahlungsart.FormattingEnabled = true;
            kontobewegung_Zahlungsart.Items.AddRange(new object[] { "Einzahlen", "Auszahlen" });
            kontobewegung_Zahlungsart.Location = new Point(122, 143);
            kontobewegung_Zahlungsart.Margin = new Padding(3, 4, 3, 4);
            kontobewegung_Zahlungsart.Name = "kontobewegung_Zahlungsart";
            kontobewegung_Zahlungsart.Size = new Size(339, 36);
            kontobewegung_Zahlungsart.TabIndex = 0;
            kontobewegung_Zahlungsart.Text = "Transaktion auswählen";
            kontobewegung_Zahlungsart.SelectedIndexChanged += kontobewegung_Zahlungsart_SelectedIndexChanged;
            // 
            // Kunde_Transaktionen_bestaetigen
            // 
            Kunde_Transaktionen_bestaetigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Transaktionen_bestaetigen.Location = new Point(180, 412);
            Kunde_Transaktionen_bestaetigen.Margin = new Padding(3, 4, 3, 4);
            Kunde_Transaktionen_bestaetigen.Name = "Kunde_Transaktionen_bestaetigen";
            Kunde_Transaktionen_bestaetigen.Size = new Size(194, 53);
            Kunde_Transaktionen_bestaetigen.TabIndex = 1;
            Kunde_Transaktionen_bestaetigen.Text = "Bestätigen";
            Kunde_Transaktionen_bestaetigen.UseVisualStyleBackColor = true;
            Kunde_Transaktionen_bestaetigen.Click += Kunde_Transaktionen_bestaetigen_Click;
            // 
            // kontobewegung_Betrag
            // 
            kontobewegung_Betrag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Betrag.Location = new Point(12, 339);
            kontobewegung_Betrag.Margin = new Padding(3, 4, 3, 4);
            kontobewegung_Betrag.Name = "kontobewegung_Betrag";
            kontobewegung_Betrag.Size = new Size(239, 34);
            kontobewegung_Betrag.TabIndex = 2;
            kontobewegung_Betrag.TextChanged += kontobewegung_Betrag_TextChanged;
            // 
            // kontobewegung_TargetIBAN
            // 
            kontobewegung_TargetIBAN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_TargetIBAN.Location = new Point(122, 241);
            kontobewegung_TargetIBAN.Margin = new Padding(3, 4, 3, 4);
            kontobewegung_TargetIBAN.Name = "kontobewegung_TargetIBAN";
            kontobewegung_TargetIBAN.Size = new Size(339, 34);
            kontobewegung_TargetIBAN.TabIndex = 3;
            kontobewegung_TargetIBAN.Text = "Tansaktionsziel";
            kontobewegung_TargetIBAN.TextChanged += kontobewegung_TargetIBAN_TextChanged;
            // 
            // Kunde_Transaktionen_zurueck
            // 
            Kunde_Transaktionen_zurueck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kunde_Transaktionen_zurueck.Location = new Point(180, 492);
            Kunde_Transaktionen_zurueck.Margin = new Padding(3, 4, 3, 4);
            Kunde_Transaktionen_zurueck.Name = "Kunde_Transaktionen_zurueck";
            Kunde_Transaktionen_zurueck.Size = new Size(194, 38);
            Kunde_Transaktionen_zurueck.TabIndex = 4;
            Kunde_Transaktionen_zurueck.Text = "Zurück";
            Kunde_Transaktionen_zurueck.UseVisualStyleBackColor = true;
            Kunde_Transaktionen_zurueck.Click += Kunde_Transaktionen_zurueck_Click;
            // 
            // kontobewegung_Label_Kontostand
            // 
            kontobewegung_Label_Kontostand.AutoSize = true;
            kontobewegung_Label_Kontostand.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Label_Kontostand.Location = new Point(159, 67);
            kontobewegung_Label_Kontostand.Name = "kontobewegung_Label_Kontostand";
            kontobewegung_Label_Kontostand.Size = new Size(239, 31);
            kontobewegung_Label_Kontostand.TabIndex = 5;
            kontobewegung_Label_Kontostand.Text = " Aktueller Kontostand ";
            // 
            // kontobewegung_Name
            // 
            kontobewegung_Name.AutoSize = true;
            kontobewegung_Name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Name.Location = new Point(159, 9);
            kontobewegung_Name.Name = "kontobewegung_Name";
            kontobewegung_Name.Size = new Size(239, 41);
            kontobewegung_Name.TabIndex = 9;
            kontobewegung_Name.Text = "Kontobewegung";
            // 
            // kontobewegung_Kontostand
            // 
            kontobewegung_Kontostand.AutoSize = true;
            kontobewegung_Kontostand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Kontostand.Location = new Point(241, 111);
            kontobewegung_Kontostand.Name = "kontobewegung_Kontostand";
            kontobewegung_Kontostand.Size = new Size(65, 28);
            kontobewegung_Kontostand.TabIndex = 10;
            kontobewegung_Kontostand.Text = "label2";
            // 
            // kontobewegung_Label_TargetIBAN
            // 
            kontobewegung_Label_TargetIBAN.AutoSize = true;
            kontobewegung_Label_TargetIBAN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Label_TargetIBAN.Location = new Point(229, 198);
            kontobewegung_Label_TargetIBAN.Name = "kontobewegung_Label_TargetIBAN";
            kontobewegung_Label_TargetIBAN.Size = new Size(92, 28);
            kontobewegung_Label_TargetIBAN.TabIndex = 11;
            kontobewegung_Label_TargetIBAN.Text = "Ziel IBAN";
            // 
            // kontobewegung_Label_Betrag
            // 
            kontobewegung_Label_Betrag.AutoSize = true;
            kontobewegung_Label_Betrag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Label_Betrag.Location = new Point(60, 307);
            kontobewegung_Label_Betrag.Name = "kontobewegung_Label_Betrag";
            kontobewegung_Label_Betrag.Size = new Size(131, 28);
            kontobewegung_Label_Betrag.TabIndex = 12;
            kontobewegung_Label_Betrag.Text = "Betrag in EUR";
            // 
            // kontobewegung_Label_Restbetrag
            // 
            kontobewegung_Label_Restbetrag.AutoSize = true;
            kontobewegung_Label_Restbetrag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Label_Restbetrag.Location = new Point(348, 307);
            kontobewegung_Label_Restbetrag.Name = "kontobewegung_Label_Restbetrag";
            kontobewegung_Label_Restbetrag.Size = new Size(168, 28);
            kontobewegung_Label_Restbetrag.TabIndex = 14;
            kontobewegung_Label_Restbetrag.Text = "Restbetrag in EUR";
            // 
            // kontobewegung_Restbetrag
            // 
            kontobewegung_Restbetrag.AutoSize = true;
            kontobewegung_Restbetrag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kontobewegung_Restbetrag.Location = new Point(438, 342);
            kontobewegung_Restbetrag.Name = "kontobewegung_Restbetrag";
            kontobewegung_Restbetrag.Size = new Size(23, 28);
            kontobewegung_Restbetrag.TabIndex = 15;
            kontobewegung_Restbetrag.Text = "0";
            // 
            // Kontobewegungen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(560, 557);
            Controls.Add(kontobewegung_Restbetrag);
            Controls.Add(kontobewegung_Label_Restbetrag);
            Controls.Add(kontobewegung_Label_Betrag);
            Controls.Add(kontobewegung_Label_TargetIBAN);
            Controls.Add(kontobewegung_Kontostand);
            Controls.Add(kontobewegung_Name);
            Controls.Add(kontobewegung_Label_Kontostand);
            Controls.Add(Kunde_Transaktionen_zurueck);
            Controls.Add(kontobewegung_TargetIBAN);
            Controls.Add(kontobewegung_Betrag);
            Controls.Add(Kunde_Transaktionen_bestaetigen);
            Controls.Add(kontobewegung_Zahlungsart);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kontobewegungen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kontobewegungen";
            FormClosing += Kontobewegungen_FormClosing;
            Load += Kontobewegungen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox kontobewegung_Zahlungsart;
        private Button Kunde_Transaktionen_bestaetigen;
        private TextBox kontobewegung_Betrag;
        private TextBox kontobewegung_TargetIBAN;
        private Button Kunde_Transaktionen_zurueck;
        private Label kontobewegung_Label_Kontostand;
        private Label kontobewegung_Name;
        private Label kontobewegung_Kontostand;
        private Label kontobewegung_Label_TargetIBAN;
        private Label kontobewegung_Label_Betrag;
        private Label kontobewegung_Label_Restbetrag;
        private Label kontobewegung_Restbetrag;
    }
}
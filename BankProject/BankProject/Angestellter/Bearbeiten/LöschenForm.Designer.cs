namespace BankProject.Angestellter.Bearbeiten
{
    partial class LöschenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LöschenForm));
            label2 = new Label();
            label3 = new Label();
            löschen_MitarbeiterList = new ComboBox();
            löschen_Anwenden = new Button();
            löschen_Back = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 20);
            label3.Name = "label3";
            label3.Size = new Size(213, 31);
            label3.TabIndex = 0;
            label3.Text = "Mitarbeiter löschen";
            // 
            // löschen_MitarbeiterList
            // 
            löschen_MitarbeiterList.FormattingEnabled = true;
            löschen_MitarbeiterList.Location = new Point(91, 80);
            löschen_MitarbeiterList.Name = "löschen_MitarbeiterList";
            löschen_MitarbeiterList.Size = new Size(151, 36);
            löschen_MitarbeiterList.TabIndex = 2;
            // 
            // löschen_Anwenden
            // 
            löschen_Anwenden.Location = new Point(69, 144);
            löschen_Anwenden.Name = "löschen_Anwenden";
            löschen_Anwenden.Size = new Size(122, 39);
            löschen_Anwenden.TabIndex = 3;
            löschen_Anwenden.Text = "Anwenden";
            löschen_Anwenden.UseVisualStyleBackColor = true;
            löschen_Anwenden.Click += löschen_Anwenden_Click;
            // 
            // löschen_Back
            // 
            löschen_Back.Location = new Point(69, 203);
            löschen_Back.Name = "löschen_Back";
            löschen_Back.Size = new Size(122, 39);
            löschen_Back.TabIndex = 4;
            löschen_Back.Text = "Zurück";
            löschen_Back.UseVisualStyleBackColor = true;
            löschen_Back.Click += löschen_Back_Click;
            // 
            // LöschenForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            ClientSize = new Size(254, 256);
            Controls.Add(löschen_Back);
            Controls.Add(löschen_Anwenden);
            Controls.Add(löschen_MitarbeiterList);
            Controls.Add(label2);
            Controls.Add(label3);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LöschenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter löschen";
            FormClosing += LöschenForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private ComboBox löschen_MitarbeiterList;
        private Button löschen_Anwenden;
        private Button löschen_Back;
    }
}
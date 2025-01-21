namespace BankProject.Kunde
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            label1 = new Label();
            label2 = new Label();
            changePass_Aktuell = new Label();
            label3 = new Label();
            changePass_NewPass = new TextBox();
            changePass_Anwenden = new Button();
            changePass_Abbrechen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 0;
            label1.Text = "Passwort ändern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 1;
            label2.Text = "Passwort aktuell";
            // 
            // changePass_Aktuell
            // 
            changePass_Aktuell.AutoSize = true;
            changePass_Aktuell.Location = new Point(119, 121);
            changePass_Aktuell.Name = "changePass_Aktuell";
            changePass_Aktuell.Size = new Size(56, 28);
            changePass_Aktuell.TabIndex = 2;
            changePass_Aktuell.Text = "1234";
            changePass_Aktuell.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 172);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 3;
            label3.Text = "Neues Passwort";
            // 
            // changePass_NewPass
            // 
            changePass_NewPass.Location = new Point(71, 214);
            changePass_NewPass.Name = "changePass_NewPass";
            changePass_NewPass.Size = new Size(147, 34);
            changePass_NewPass.TabIndex = 4;
            // 
            // changePass_Anwenden
            // 
            changePass_Anwenden.Location = new Point(12, 271);
            changePass_Anwenden.Name = "changePass_Anwenden";
            changePass_Anwenden.Size = new Size(130, 37);
            changePass_Anwenden.TabIndex = 5;
            changePass_Anwenden.Text = "Anwenden";
            changePass_Anwenden.UseVisualStyleBackColor = true;
            changePass_Anwenden.Click += changePass_Anwenden_Click;
            // 
            // changePass_Abbrechen
            // 
            changePass_Abbrechen.Location = new Point(162, 271);
            changePass_Abbrechen.Name = "changePass_Abbrechen";
            changePass_Abbrechen.Size = new Size(130, 37);
            changePass_Abbrechen.TabIndex = 6;
            changePass_Abbrechen.Text = "Abbrechen";
            changePass_Abbrechen.UseVisualStyleBackColor = true;
            changePass_Abbrechen.Click += changePass_Abbrechen_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(304, 329);
            Controls.Add(changePass_Abbrechen);
            Controls.Add(changePass_Anwenden);
            Controls.Add(changePass_NewPass);
            Controls.Add(label3);
            Controls.Add(changePass_Aktuell);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passwort ändern";
            FormClosing += ChangePassword_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label changePass_Aktuell;
        private Label label3;
        private TextBox changePass_NewPass;
        private Button changePass_Anwenden;
        private Button changePass_Abbrechen;
    }
}
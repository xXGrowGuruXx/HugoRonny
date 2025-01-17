namespace BankProject.Angestellter.Bearbeiten
{
    partial class BearbeitenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BearbeitenForm));
            bearbeiten_Back = new Button();
            label1 = new Label();
            bearbeiten_ChooseMitarbeiter = new ComboBox();
            label2 = new Label();
            bearbeiten_position = new ComboBox();
            bearbeiten_branch = new ComboBox();
            label3 = new Label();
            bearbeiten_SaveSettings = new Button();
            SuspendLayout();
            // 
            // bearbeiten_Back
            // 
            bearbeiten_Back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bearbeiten_Back.Location = new Point(133, 388);
            bearbeiten_Back.Name = "bearbeiten_Back";
            bearbeiten_Back.Size = new Size(160, 50);
            bearbeiten_Back.TabIndex = 0;
            bearbeiten_Back.Text = "Zurück";
            bearbeiten_Back.UseVisualStyleBackColor = true;
            bearbeiten_Back.Click += bearbeiten_Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 1;
            label1.Text = "Bearbeiten";
            // 
            // bearbeiten_ChooseMitarbeiter
            // 
            bearbeiten_ChooseMitarbeiter.FormattingEnabled = true;
            bearbeiten_ChooseMitarbeiter.Location = new Point(133, 71);
            bearbeiten_ChooseMitarbeiter.Name = "bearbeiten_ChooseMitarbeiter";
            bearbeiten_ChooseMitarbeiter.Size = new Size(160, 28);
            bearbeiten_ChooseMitarbeiter.TabIndex = 2;
            bearbeiten_ChooseMitarbeiter.SelectedIndexChanged += bearbeiten_ChooseMitarbeiter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 133);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 3;
            label2.Text = "Position";
            // 
            // bearbeiten_position
            // 
            bearbeiten_position.FormattingEnabled = true;
            bearbeiten_position.Items.AddRange(new object[] { "Manager", "Teller", "Clerk" });
            bearbeiten_position.Location = new Point(133, 137);
            bearbeiten_position.Name = "bearbeiten_position";
            bearbeiten_position.Size = new Size(160, 28);
            bearbeiten_position.TabIndex = 4;
            // 
            // bearbeiten_branch
            // 
            bearbeiten_branch.FormattingEnabled = true;
            bearbeiten_branch.Items.AddRange(new object[] { "Main Branch", "West Branch", "East Branch" });
            bearbeiten_branch.Location = new Point(133, 215);
            bearbeiten_branch.Name = "bearbeiten_branch";
            bearbeiten_branch.Size = new Size(160, 28);
            bearbeiten_branch.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 211);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 5;
            label3.Text = "Branch";
            // 
            // bearbeiten_SaveSettings
            // 
            bearbeiten_SaveSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bearbeiten_SaveSettings.Location = new Point(133, 287);
            bearbeiten_SaveSettings.Name = "bearbeiten_SaveSettings";
            bearbeiten_SaveSettings.Size = new Size(160, 50);
            bearbeiten_SaveSettings.TabIndex = 7;
            bearbeiten_SaveSettings.Text = "Anwenden";
            bearbeiten_SaveSettings.UseVisualStyleBackColor = true;
            bearbeiten_SaveSettings.Click += bearbeiten_SaveSettings_Click;
            // 
            // BearbeitenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(431, 450);
            Controls.Add(bearbeiten_SaveSettings);
            Controls.Add(bearbeiten_branch);
            Controls.Add(label3);
            Controls.Add(bearbeiten_position);
            Controls.Add(label2);
            Controls.Add(bearbeiten_ChooseMitarbeiter);
            Controls.Add(label1);
            Controls.Add(bearbeiten_Back);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BearbeitenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bearbeiten";
            FormClosing += BearbeitenForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bearbeiten_Back;
        private Label label1;
        private ComboBox bearbeiten_ChooseMitarbeiter;
        private Label label2;
        private ComboBox bearbeiten_position;
        private ComboBox bearbeiten_branch;
        private Label label3;
        private Button bearbeiten_SaveSettings;
    }
}
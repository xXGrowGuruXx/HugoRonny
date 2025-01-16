namespace BankProject.Angestellter.Bericht
{
    partial class Mitarbeiter_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_History));
            mitarb_history_comboBox_mitarbeiter = new ComboBox();
            mitarb_history_laden = new Button();
            listBox1 = new ListBox();
            mitarb_history_export = new Button();
            mitarb_history_zurueck = new Button();
            SuspendLayout();
            // 
            // mitarb_history_comboBox_mitarbeiter
            // 
            mitarb_history_comboBox_mitarbeiter.FormattingEnabled = true;
            mitarb_history_comboBox_mitarbeiter.Location = new Point(14, 16);
            mitarb_history_comboBox_mitarbeiter.Margin = new Padding(3, 4, 3, 4);
            mitarb_history_comboBox_mitarbeiter.Name = "mitarb_history_comboBox_mitarbeiter";
            mitarb_history_comboBox_mitarbeiter.Size = new Size(191, 28);
            mitarb_history_comboBox_mitarbeiter.TabIndex = 0;
            mitarb_history_comboBox_mitarbeiter.Text = "Mitarbeiter auswählen";
            // 
            // mitarb_history_laden
            // 
            mitarb_history_laden.Location = new Point(272, 16);
            mitarb_history_laden.Margin = new Padding(3, 4, 3, 4);
            mitarb_history_laden.Name = "mitarb_history_laden";
            mitarb_history_laden.Size = new Size(114, 31);
            mitarb_history_laden.TabIndex = 1;
            mitarb_history_laden.Text = "History laden";
            mitarb_history_laden.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 55);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(371, 364);
            listBox1.TabIndex = 2;
            // 
            // mitarb_history_export
            // 
            mitarb_history_export.Location = new Point(15, 427);
            mitarb_history_export.Margin = new Padding(3, 4, 3, 4);
            mitarb_history_export.Name = "mitarb_history_export";
            mitarb_history_export.Size = new Size(191, 31);
            mitarb_history_export.TabIndex = 3;
            mitarb_history_export.Text = "exportieren";
            mitarb_history_export.UseVisualStyleBackColor = true;
            // 
            // mitarb_history_zurueck
            // 
            mitarb_history_zurueck.Location = new Point(272, 427);
            mitarb_history_zurueck.Margin = new Padding(3, 4, 3, 4);
            mitarb_history_zurueck.Name = "mitarb_history_zurueck";
            mitarb_history_zurueck.Size = new Size(114, 31);
            mitarb_history_zurueck.TabIndex = 4;
            mitarb_history_zurueck.Text = "Zurück";
            mitarb_history_zurueck.UseVisualStyleBackColor = true;
            // 
            // Mitarbeiter_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(400, 473);
            Controls.Add(mitarb_history_zurueck);
            Controls.Add(mitarb_history_export);
            Controls.Add(listBox1);
            Controls.Add(mitarb_history_laden);
            Controls.Add(mitarb_history_comboBox_mitarbeiter);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mitarbeiter_History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mitarbeiter History";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox mitarb_history_comboBox_mitarbeiter;
        private Button mitarb_history_laden;
        private ListBox listBox1;
        private Button mitarb_history_export;
        private Button mitarb_history_zurueck;
    }
}
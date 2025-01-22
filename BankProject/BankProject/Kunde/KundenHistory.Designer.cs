namespace BankProject.Kunde
{
    partial class KundenHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenHistory));
            kundenHistory_Zurück = new Button();
            kundenHistory_Export = new Button();
            kundenHistory_Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)kundenHistory_Grid).BeginInit();
            SuspendLayout();
            // 
            // kundenHistory_Zurück
            // 
            kundenHistory_Zurück.Location = new Point(788, 13);
            kundenHistory_Zurück.Margin = new Padding(4);
            kundenHistory_Zurück.Name = "kundenHistory_Zurück";
            kundenHistory_Zurück.Size = new Size(202, 62);
            kundenHistory_Zurück.TabIndex = 0;
            kundenHistory_Zurück.Text = "Zurück";
            kundenHistory_Zurück.UseVisualStyleBackColor = true;
            kundenHistory_Zurück.Click += kundenHistory_Zurück_Click;
            // 
            // kundenHistory_Export
            // 
            kundenHistory_Export.Location = new Point(32, 13);
            kundenHistory_Export.Margin = new Padding(4);
            kundenHistory_Export.Name = "kundenHistory_Export";
            kundenHistory_Export.Size = new Size(202, 62);
            kundenHistory_Export.TabIndex = 1;
            kundenHistory_Export.Text = "Exportieren";
            kundenHistory_Export.UseVisualStyleBackColor = true;
            kundenHistory_Export.Click += kundenHistory_Export_Click;
            // 
            // kundenHistory_Grid
            // 
            kundenHistory_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kundenHistory_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            kundenHistory_Grid.BackgroundColor = SystemColors.Control;
            kundenHistory_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kundenHistory_Grid.Location = new Point(32, 91);
            kundenHistory_Grid.Name = "kundenHistory_Grid";
            kundenHistory_Grid.RowHeadersWidth = 51;
            kundenHistory_Grid.Size = new Size(958, 400);
            kundenHistory_Grid.TabIndex = 2;
            // 
            // KundenHistory
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            ClientSize = new Size(1031, 516);
            Controls.Add(kundenHistory_Grid);
            Controls.Add(kundenHistory_Export);
            Controls.Add(kundenHistory_Zurück);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KundenHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KundenHistory";
            FormClosing += KundenHistory_FormClosing;
            ((System.ComponentModel.ISupportInitialize)kundenHistory_Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button kundenHistory_Zurück;
        private Button kundenHistory_Export;
        private DataGridView kundenHistory_Grid;
    }
}
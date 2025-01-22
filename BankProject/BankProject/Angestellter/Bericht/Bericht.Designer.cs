namespace BankProject.Angestellter.Bericht
{
    partial class Mitarbeiter_Berichte
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mitarbeiter_Berichte));
            bericht_Kunde = new ComboBox();
            bericht_bericht_anzeigen = new Button();
            bericht_exportieren = new Button();
            bericht_zurueck = new Button();
            bericht_DataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bericht_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // bericht_Kunde
            // 
            bericht_Kunde.FormattingEnabled = true;
            bericht_Kunde.Location = new Point(46, 23);
            bericht_Kunde.Margin = new Padding(3, 4, 3, 4);
            bericht_Kunde.Name = "bericht_Kunde";
            bericht_Kunde.Size = new Size(178, 28);
            bericht_Kunde.TabIndex = 1;
            bericht_Kunde.Tag = "";
            bericht_Kunde.Text = "Kunde";
            // 
            // bericht_bericht_anzeigen
            // 
            bericht_bericht_anzeigen.Location = new Point(295, 13);
            bericht_bericht_anzeigen.Margin = new Padding(3, 4, 3, 4);
            bericht_bericht_anzeigen.Name = "bericht_bericht_anzeigen";
            bericht_bericht_anzeigen.Size = new Size(189, 46);
            bericht_bericht_anzeigen.TabIndex = 2;
            bericht_bericht_anzeigen.Text = "anzeigen";
            bericht_bericht_anzeigen.UseVisualStyleBackColor = true;
            bericht_bericht_anzeigen.Click += bericht_bericht_anzeigen_Click;
            // 
            // bericht_exportieren
            // 
            bericht_exportieren.Location = new Point(46, 424);
            bericht_exportieren.Margin = new Padding(3, 4, 3, 4);
            bericht_exportieren.Name = "bericht_exportieren";
            bericht_exportieren.Size = new Size(178, 46);
            bericht_exportieren.TabIndex = 3;
            bericht_exportieren.Text = "Export";
            bericht_exportieren.UseVisualStyleBackColor = true;
            bericht_exportieren.Click += bericht_exportieren_Click;
            // 
            // bericht_zurueck
            // 
            bericht_zurueck.Location = new Point(295, 424);
            bericht_zurueck.Margin = new Padding(3, 4, 3, 4);
            bericht_zurueck.Name = "bericht_zurueck";
            bericht_zurueck.Size = new Size(189, 46);
            bericht_zurueck.TabIndex = 4;
            bericht_zurueck.Text = "Zurück";
            bericht_zurueck.UseVisualStyleBackColor = true;
            bericht_zurueck.Click += bericht_zurueck_Click;
            // 
            // bericht_DataGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            bericht_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            bericht_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bericht_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            bericht_DataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            bericht_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bericht_DataGrid.Location = new Point(12, 69);
            bericht_DataGrid.Name = "bericht_DataGrid";
            bericht_DataGrid.RowHeadersWidth = 51;
            bericht_DataGrid.Size = new Size(516, 348);
            bericht_DataGrid.TabIndex = 5;
            // 
            // Mitarbeiter_Berichte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Random_Bank_Icon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(540, 473);
            Controls.Add(bericht_DataGrid);
            Controls.Add(bericht_zurueck);
            Controls.Add(bericht_exportieren);
            Controls.Add(bericht_bericht_anzeigen);
            Controls.Add(bericht_Kunde);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mitarbeiter_Berichte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bericht";
            FormClosing += Bericht_FormClosing;
            ((System.ComponentModel.ISupportInitialize)bericht_DataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox bericht_Kunde;
        private Button bericht_bericht_anzeigen;
        private Button bericht_exportieren;
        private Button bericht_zurueck;
        private DataGridView bericht_DataGrid;
    }
}
namespace BankProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            remember_checkbox = new CheckBox();
            username = new Label();
            label1 = new Label();
            login_mail = new TextBox();
            login_password = new TextBox();
            login = new Button();
            label2 = new Label();
            login_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // remember_checkbox
            // 
            remember_checkbox.AutoSize = true;
            remember_checkbox.BackColor = SystemColors.HighlightText;
            remember_checkbox.Location = new Point(18, 276);
            remember_checkbox.Name = "remember_checkbox";
            remember_checkbox.Size = new Size(365, 32);
            remember_checkbox.TabIndex = 0;
            remember_checkbox.Text = "   Zugangsdaten für später speichern   ";
            remember_checkbox.UseVisualStyleBackColor = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = SystemColors.HighlightText;
            username.Location = new Point(17, 170);
            username.Name = "username";
            username.Size = new Size(154, 28);
            username.TabIndex = 1;
            username.Text = "Username/Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Location = new Point(18, 224);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 2;
            label1.Text = "      Password      ";
            // 
            // login_mail
            // 
            login_mail.Location = new Point(204, 170);
            login_mail.Name = "login_mail";
            login_mail.Size = new Size(179, 34);
            login_mail.TabIndex = 3;
            // 
            // login_password
            // 
            login_password.Location = new Point(204, 224);
            login_password.Name = "login_password";
            login_password.Size = new Size(179, 34);
            login_password.TabIndex = 4;
            // 
            // login
            // 
            login.Location = new Point(17, 327);
            login.Name = "login";
            login.Size = new Size(365, 46);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 24);
            label2.Name = "label2";
            label2.Size = new Size(202, 41);
            label2.TabIndex = 6;
            label2.Text = "Random Bank";
            // 
            // login_comboBox
            // 
            login_comboBox.FormattingEnabled = true;
            login_comboBox.Items.AddRange(new object[] { "Kunde", "Kundenberater" });
            login_comboBox.Location = new Point(90, 96);
            login_comboBox.Name = "login_comboBox";
            login_comboBox.Size = new Size(202, 36);
            login_comboBox.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(395, 387);
            Controls.Add(login_comboBox);
            Controls.Add(label2);
            Controls.Add(login);
            Controls.Add(login_password);
            Controls.Add(login_mail);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(remember_checkbox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox remember_checkbox;
        private Label username;
        private Label label1;
        private TextBox login_mail;
        private TextBox login_password;
        private Button login;
        private Label label2;
        private ComboBox login_comboBox;
    }
}

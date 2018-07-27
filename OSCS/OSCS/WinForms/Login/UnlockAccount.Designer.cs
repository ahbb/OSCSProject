namespace OSCS.WinForms.Login
{
    partial class UnlockAccount
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
            this.Header = new System.Windows.Forms.Panel();
            this.projectTitle = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetCode = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.resetLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.confirmNewPassword = new System.Windows.Forms.Label();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.check = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.RegisterButton);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Controls.Add(this.LoginButton);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(887, 73);
            this.Header.TabIndex = 19;
            // 
            // projectTitle
            // 
            this.projectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectTitle.AutoSize = true;
            this.projectTitle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTitle.Location = new System.Drawing.Point(12, 22);
            this.projectTitle.MaximumSize = new System.Drawing.Size(250, 30);
            this.projectTitle.MinimumSize = new System.Drawing.Size(250, 30);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(250, 30);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(758, 16);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 41);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(304, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Unlock Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please enter the reset code received in your email below.\r\nThereafter, set a new " +
    "strong password.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetCode
            // 
            this.resetCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCode.Location = new System.Drawing.Point(289, 66);
            this.resetCode.Name = "resetCode";
            this.resetCode.Size = new System.Drawing.Size(241, 30);
            this.resetCode.TabIndex = 22;
            // 
            // SubmitButton
            // 
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.SubmitButton.Location = new System.Drawing.Point(355, 170);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(117, 51);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // newPassword
            // 
            this.newPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPassword.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.Location = new System.Drawing.Point(323, 76);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(176, 27);
            this.newPassword.TabIndex = 26;
            this.newPassword.UseSystemPasswordChar = true;
            this.newPassword.TextChanged += new System.EventHandler(this.newPassword_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(81, 79);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(226, 24);
            this.passwordLabel.TabIndex = 27;
            this.passwordLabel.Text = "Confirm New Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(156, 21);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(151, 24);
            this.usernameLabel.TabIndex = 24;
            this.usernameLabel.Text = "New Password: ";
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(323, 18);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(176, 27);
            this.password.TabIndex = 25;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // resetLabel
            // 
            this.resetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.Location = new System.Drawing.Point(543, 65);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(0, 24);
            this.resetLabel.TabIndex = 30;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ConfirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Georgia", 12F);
            this.ConfirmButton.Location = new System.Drawing.Point(355, 119);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(117, 51);
            this.ConfirmButton.TabIndex = 31;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Georgia", 8F);
            this.confirmPassword.ForeColor = System.Drawing.Color.Red;
            this.confirmPassword.Location = new System.Drawing.Point(516, 8);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(322, 54);
            this.confirmPassword.TabIndex = 32;
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.Font = new System.Drawing.Font("Georgia", 8F);
            this.confirmNewPassword.ForeColor = System.Drawing.Color.Red;
            this.confirmNewPassword.Location = new System.Drawing.Point(519, 62);
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(319, 58);
            this.confirmNewPassword.TabIndex = 33;
            // 
            // resetPanel
            // 
            this.resetPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetPanel.Controls.Add(this.resetLabel);
            this.resetPanel.Controls.Add(this.label1);
            this.resetPanel.Controls.Add(this.ConfirmButton);
            this.resetPanel.Controls.Add(this.resetCode);
            this.resetPanel.Location = new System.Drawing.Point(17, 135);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(843, 182);
            this.resetPanel.TabIndex = 34;
            // 
            // passwordPanel
            // 
            this.passwordPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordPanel.Controls.Add(this.check);
            this.passwordPanel.Controls.Add(this.confirmPassword);
            this.passwordPanel.Controls.Add(this.confirmNewPassword);
            this.passwordPanel.Controls.Add(this.SubmitButton);
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Controls.Add(this.newPassword);
            this.passwordPanel.Controls.Add(this.usernameLabel);
            this.passwordPanel.Controls.Add(this.password);
            this.passwordPanel.Location = new System.Drawing.Point(17, 323);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(843, 227);
            this.passwordPanel.TabIndex = 35;
            this.passwordPanel.Visible = false;
            // 
            // check
            // 
            this.check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Red;
            this.check.Location = new System.Drawing.Point(215, 130);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(0, 24);
            this.check.TabIndex = 34;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(626, 16);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(126, 41);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // UnlockAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.resetPanel);
            this.MaximizeBox = false;
            this.Name = "UnlockAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnlockAccount";
            this.Load += new System.EventHandler(this.UnlockAccount_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resetCode;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Label confirmNewPassword;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.Button RegisterButton;
    }
}
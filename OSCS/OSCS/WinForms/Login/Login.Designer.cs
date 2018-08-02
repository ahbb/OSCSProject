namespace OSCS.WinForms.Login
{
    partial class Login
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.ToLoginOTPButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ForgetButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.usernameWarning = new System.Windows.Forms.Label();
            this.passwordWarning = new System.Windows.Forms.Label();
            this.loginWarning = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.UnlockAccountButton = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(216, 166);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 18);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // ToLoginOTPButton
            // 
            this.ToLoginOTPButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ToLoginOTPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ToLoginOTPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ToLoginOTPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToLoginOTPButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLoginOTPButton.Location = new System.Drawing.Point(223, 10);
            this.ToLoginOTPButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToLoginOTPButton.Name = "ToLoginOTPButton";
            this.ToLoginOTPButton.Size = new System.Drawing.Size(80, 39);
            this.ToLoginOTPButton.TabIndex = 1;
            this.ToLoginOTPButton.Text = "Login";
            this.ToLoginOTPButton.UseVisualStyleBackColor = true;
            this.ToLoginOTPButton.Click += new System.EventHandler(this.ToLoginOTPButton_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(302, 166);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 23);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(302, 213);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 23);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(216, 215);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 18);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // ForgetButton
            // 
            this.ForgetButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ForgetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ForgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetButton.Location = new System.Drawing.Point(12, 10);
            this.ForgetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForgetButton.Name = "ForgetButton";
            this.ForgetButton.Size = new System.Drawing.Size(190, 39);
            this.ForgetButton.TabIndex = 8;
            this.ForgetButton.Text = "Forget your Password?";
            this.ForgetButton.UseVisualStyleBackColor = true;
            this.ForgetButton.Click += new System.EventHandler(this.ForgetButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(292, 114);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(77, 27);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Login";
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.ForgetButton);
            this.LoginPanel.Controls.Add(this.ToLoginOTPButton);
            this.LoginPanel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(166, 306);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(313, 57);
            this.LoginPanel.TabIndex = 12;
            // 
            // usernameWarning
            // 
            this.usernameWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameWarning.AutoSize = true;
            this.usernameWarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameWarning.Location = new System.Drawing.Point(448, 168);
            this.usernameWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameWarning.Name = "usernameWarning";
            this.usernameWarning.Size = new System.Drawing.Size(0, 18);
            this.usernameWarning.TabIndex = 13;
            // 
            // passwordWarning
            // 
            this.passwordWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordWarning.AutoSize = true;
            this.passwordWarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordWarning.Location = new System.Drawing.Point(448, 215);
            this.passwordWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordWarning.Name = "passwordWarning";
            this.passwordWarning.Size = new System.Drawing.Size(0, 18);
            this.passwordWarning.TabIndex = 14;
            // 
            // loginWarning
            // 
            this.loginWarning.AutoSize = true;
            this.loginWarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.loginWarning.Location = new System.Drawing.Point(152, 265);
            this.loginWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginWarning.Name = "loginWarning";
            this.loginWarning.Size = new System.Drawing.Size(0, 18);
            this.loginWarning.TabIndex = 15;
            this.loginWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.UnlockAccountButton);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Controls.Add(this.RegisterButton);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(665, 59);
            this.Header.TabIndex = 16;
            // 
            // UnlockAccountButton
            // 
            this.UnlockAccountButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnlockAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.UnlockAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.UnlockAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.UnlockAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlockAccountButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnlockAccountButton.ForeColor = System.Drawing.Color.White;
            this.UnlockAccountButton.Location = new System.Drawing.Point(434, 13);
            this.UnlockAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnlockAccountButton.Name = "UnlockAccountButton";
            this.UnlockAccountButton.Size = new System.Drawing.Size(142, 33);
            this.UnlockAccountButton.TabIndex = 10;
            this.UnlockAccountButton.Text = "Unlock Account";
            this.UnlockAccountButton.UseVisualStyleBackColor = true;
            this.UnlockAccountButton.Click += new System.EventHandler(this.UnlockAccountButton_Click);
            // 
            // projectTitle
            // 
            this.projectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectTitle.AutoSize = true;
            this.projectTitle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTitle.Location = new System.Drawing.Point(9, 18);
            this.projectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectTitle.MaximumSize = new System.Drawing.Size(188, 24);
            this.projectTitle.MinimumSize = new System.Drawing.Size(188, 24);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(188, 24);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
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
            this.RegisterButton.Location = new System.Drawing.Point(568, 13);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(94, 33);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(484, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 19;
            this.button1.Text = "Already registered? Activate your account here!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.loginWarning);
            this.Controls.Add(this.passwordWarning);
            this.Controls.Add(this.usernameWarning);
            this.Controls.Add(this.password);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.username);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chat Protection";
            this.LoginPanel.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button ToLoginOTPButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button ForgetButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label usernameWarning;
        private System.Windows.Forms.Label passwordWarning;
        private System.Windows.Forms.Label loginWarning;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button UnlockAccountButton;
        private System.Windows.Forms.Button button1;
    }
}
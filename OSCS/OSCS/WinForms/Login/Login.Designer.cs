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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.ToLoginOTPButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.RecoverLabel = new System.Windows.Forms.Label();
            this.ToRecoverOTPButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RecoverPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.usernameWarning = new System.Windows.Forms.Label();
            this.passwordWarning = new System.Windows.Forms.Label();
            this.loginWarning = new System.Windows.Forms.Label();
            this.RecoverPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(423, 92);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // ToLoginOTPButton
            // 
            this.ToLoginOTPButton.Location = new System.Drawing.Point(112, 12);
            this.ToLoginOTPButton.Name = "ToLoginOTPButton";
            this.ToLoginOTPButton.Size = new System.Drawing.Size(287, 51);
            this.ToLoginOTPButton.TabIndex = 1;
            this.ToLoginOTPButton.Text = "Proceed to OTP Verification";
            this.ToLoginOTPButton.UseVisualStyleBackColor = true;
            this.ToLoginOTPButton.Click += new System.EventHandler(this.ToLoginOTPButton_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(539, 89);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 27);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(539, 150);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 27);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(423, 153);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // RecoverLabel
            // 
            this.RecoverLabel.AutoSize = true;
            this.RecoverLabel.Location = new System.Drawing.Point(16, 14);
            this.RecoverLabel.MaximumSize = new System.Drawing.Size(850, 650);
            this.RecoverLabel.Name = "RecoverLabel";
            this.RecoverLabel.Size = new System.Drawing.Size(774, 60);
            this.RecoverLabel.TabIndex = 5;
            this.RecoverLabel.Text = resources.GetString("RecoverLabel.Text");
            // 
            // ToRecoverOTPButton
            // 
            this.ToRecoverOTPButton.ForeColor = System.Drawing.Color.Red;
            this.ToRecoverOTPButton.Location = new System.Drawing.Point(245, 99);
            this.ToRecoverOTPButton.Name = "ToRecoverOTPButton";
            this.ToRecoverOTPButton.Size = new System.Drawing.Size(344, 54);
            this.ToRecoverOTPButton.TabIndex = 7;
            this.ToRecoverOTPButton.Text = "Recover account using OTP Verification";
            this.ToRecoverOTPButton.UseVisualStyleBackColor = true;
            this.ToRecoverOTPButton.Click += new System.EventHandler(this.ToRecoverOTPButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 51);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(491, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(97, 32);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Login";
            // 
            // RecoverPanel
            // 
            this.RecoverPanel.Controls.Add(this.RecoverLabel);
            this.RecoverPanel.Controls.Add(this.ToRecoverOTPButton);
            this.RecoverPanel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverPanel.Location = new System.Drawing.Point(156, 327);
            this.RecoverPanel.Name = "RecoverPanel";
            this.RecoverPanel.Size = new System.Drawing.Size(804, 178);
            this.RecoverPanel.TabIndex = 11;
            this.RecoverPanel.Visible = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.CancelButton);
            this.LoginPanel.Controls.Add(this.ToLoginOTPButton);
            this.LoginPanel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPanel.Location = new System.Drawing.Point(365, 244);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(411, 77);
            this.LoginPanel.TabIndex = 12;
            // 
            // usernameWarning
            // 
            this.usernameWarning.AutoSize = true;
            this.usernameWarning.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameWarning.Location = new System.Drawing.Point(666, 95);
            this.usernameWarning.Name = "usernameWarning";
            this.usernameWarning.Size = new System.Drawing.Size(0, 20);
            this.usernameWarning.TabIndex = 13;
            // 
            // passwordWarning
            // 
            this.passwordWarning.AutoSize = true;
            this.passwordWarning.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordWarning.Location = new System.Drawing.Point(666, 153);
            this.passwordWarning.Name = "passwordWarning";
            this.passwordWarning.Size = new System.Drawing.Size(0, 20);
            this.passwordWarning.TabIndex = 14;
            // 
            // loginWarning
            // 
            this.loginWarning.AutoSize = true;
            this.loginWarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginWarning.Location = new System.Drawing.Point(473, 198);
            this.loginWarning.Name = "loginWarning";
            this.loginWarning.Size = new System.Drawing.Size(0, 24);
            this.loginWarning.TabIndex = 15;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.loginWarning);
            this.Controls.Add(this.passwordWarning);
            this.Controls.Add(this.usernameWarning);
            this.Controls.Add(this.password);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.RecoverPanel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.username);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Online Chat Protection";
            this.Load += new System.EventHandler(this.Login_Load);
            this.RecoverPanel.ResumeLayout(false);
            this.RecoverPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button ToLoginOTPButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label RecoverLabel;
        private System.Windows.Forms.Button ToRecoverOTPButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel RecoverPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label usernameWarning;
        private System.Windows.Forms.Label passwordWarning;
        private System.Windows.Forms.Label loginWarning;
    }
}
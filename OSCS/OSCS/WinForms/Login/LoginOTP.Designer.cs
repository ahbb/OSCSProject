namespace OSCS.WinForms.Login
{
    partial class LoginOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOTP));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InputOTP = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CancelLoginButton = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.UnlockAccountButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.OTPLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.HPNum = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(267, 81);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(131, 27);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Login OTP";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(385, 328);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(79, 42);
            this.LoginButton.TabIndex = 15;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InputOTP
            // 
            this.InputOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputOTP.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputOTP.Location = new System.Drawing.Point(250, 285);
            this.InputOTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputOTP.Name = "InputOTP";
            this.InputOTP.Size = new System.Drawing.Size(143, 23);
            this.InputOTP.TabIndex = 14;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RefreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(281, 328);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(79, 42);
            this.RefreshButton.TabIndex = 17;
            this.RefreshButton.Text = "Resend";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CancelLoginButton
            // 
            this.CancelLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.CancelLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.CancelLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelLoginButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelLoginButton.Location = new System.Drawing.Point(178, 328);
            this.CancelLoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelLoginButton.Name = "CancelLoginButton";
            this.CancelLoginButton.Size = new System.Drawing.Size(79, 42);
            this.CancelLoginButton.TabIndex = 18;
            this.CancelLoginButton.Text = "Cancel";
            this.CancelLoginButton.UseVisualStyleBackColor = true;
            this.CancelLoginButton.Click += new System.EventHandler(this.CancelLoginButton_Click);
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.UnlockAccountButton);
            this.Header.Controls.Add(this.RegisterButton);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(665, 63);
            this.Header.TabIndex = 19;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.Image = global::OSCS.Properties.Resources.Shield;
            this.Logo.Location = new System.Drawing.Point(300, 3);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 57);
            this.Logo.TabIndex = 24;
            this.Logo.UseVisualStyleBackColor = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            this.UnlockAccountButton.Location = new System.Drawing.Point(434, 15);
            this.UnlockAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UnlockAccountButton.Name = "UnlockAccountButton";
            this.UnlockAccountButton.Size = new System.Drawing.Size(142, 33);
            this.UnlockAccountButton.TabIndex = 11;
            this.UnlockAccountButton.Text = "Unlock Account";
            this.UnlockAccountButton.UseVisualStyleBackColor = true;
            this.UnlockAccountButton.Click += new System.EventHandler(this.UnlockAccountButton_Click);
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
            this.RegisterButton.Location = new System.Drawing.Point(568, 15);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(94, 33);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // projectTitle
            // 
            this.projectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectTitle.AutoSize = true;
            this.projectTitle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTitle.Location = new System.Drawing.Point(9, 20);
            this.projectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectTitle.MaximumSize = new System.Drawing.Size(188, 24);
            this.projectTitle.MinimumSize = new System.Drawing.Size(188, 24);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(188, 24);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
            // 
            // OTPLabel
            // 
            this.OTPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTPLabel.AutoSize = true;
            this.OTPLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLabel.Location = new System.Drawing.Point(25, 124);
            this.OTPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OTPLabel.Name = "OTPLabel";
            this.OTPLabel.Size = new System.Drawing.Size(624, 68);
            this.OTPLabel.TabIndex = 13;
            this.OTPLabel.Text = resources.GetString("OTPLabel.Text");
            this.OTPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(32, 207);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 16;
            // 
            // HPNum
            // 
            this.HPNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HPNum.AutoSize = true;
            this.HPNum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HPNum.Location = new System.Drawing.Point(486, 124);
            this.HPNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HPNum.Name = "HPNum";
            this.HPNum.Size = new System.Drawing.Size(0, 17);
            this.HPNum.TabIndex = 20;
            // 
            // LoginOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.HPNum);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.CancelLoginButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.InputOTP);
            this.Controls.Add(this.OTPLabel);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chat Protection";
            this.Load += new System.EventHandler(this.LoginOTP_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox InputOTP;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CancelLoginButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Label OTPLabel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label HPNum;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button UnlockAccountButton;
        private System.Windows.Forms.Button Logo;
    }
}
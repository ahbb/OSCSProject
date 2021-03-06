﻿namespace OSCS.WinForms.Login
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FPLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.ConfirmFPButton = new System.Windows.Forms.Button();
            this.FPWarning = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.LoginButton);
            this.Header.Controls.Add(this.RegisterButton);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(665, 64);
            this.Header.TabIndex = 17;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.Image = global::OSCS.Properties.Resources.Shield;
            this.Logo.Location = new System.Drawing.Point(298, 5);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 57);
            this.Logo.TabIndex = 23;
            this.Logo.UseVisualStyleBackColor = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            this.LoginButton.Location = new System.Drawing.Point(568, 15);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 33);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
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
            this.RegisterButton.Location = new System.Drawing.Point(485, 15);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(94, 33);
            this.RegisterButton.TabIndex = 11;
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
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(224, 106);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(201, 27);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Forget Password";
            // 
            // FPLabel
            // 
            this.FPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPLabel.AutoSize = true;
            this.FPLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPLabel.Location = new System.Drawing.Point(121, 149);
            this.FPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FPLabel.Name = "FPLabel";
            this.FPLabel.Size = new System.Drawing.Size(426, 72);
            this.FPLabel.TabIndex = 19;
            this.FPLabel.Text = "Forgotten your password? Fear not. \r\nInput your email address used for our Applic" +
    "ation below.\r\nThereafter, we will send you a code to reset your password.\r\n\r\n";
            this.FPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(228, 268);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(190, 23);
            this.email.TabIndex = 20;
            // 
            // ConfirmFPButton
            // 
            this.ConfirmFPButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmFPButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ConfirmFPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ConfirmFPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ConfirmFPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmFPButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmFPButton.Location = new System.Drawing.Point(284, 318);
            this.ConfirmFPButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmFPButton.Name = "ConfirmFPButton";
            this.ConfirmFPButton.Size = new System.Drawing.Size(80, 41);
            this.ConfirmFPButton.TabIndex = 21;
            this.ConfirmFPButton.Text = "Submit";
            this.ConfirmFPButton.UseVisualStyleBackColor = true;
            this.ConfirmFPButton.Click += new System.EventHandler(this.ConfirmFPButton_Click);
            // 
            // FPWarning
            // 
            this.FPWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPWarning.AutoSize = true;
            this.FPWarning.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.FPWarning.Location = new System.Drawing.Point(187, 227);
            this.FPWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FPWarning.Name = "FPWarning";
            this.FPWarning.Size = new System.Drawing.Size(0, 18);
            this.FPWarning.TabIndex = 22;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.FPWarning);
            this.Controls.Add(this.ConfirmFPButton);
            this.Controls.Add(this.email);
            this.Controls.Add(this.FPLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chat Protection";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label FPLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button ConfirmFPButton;
        private System.Windows.Forms.Label FPWarning;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button Logo;
    }
}
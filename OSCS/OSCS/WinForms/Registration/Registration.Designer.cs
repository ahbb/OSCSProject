﻿namespace OSCS.WinForms.Registration
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbCheck = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbContactNo = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.Location = new System.Drawing.Point(198, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(305, 151);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F);
            this.label2.Location = new System.Drawing.Point(218, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(305, 202);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 26);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F);
            this.label3.Location = new System.Drawing.Point(197, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(305, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(182, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F);
            this.label4.Location = new System.Drawing.Point(142, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(305, 303);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(182, 26);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F);
            this.label5.Location = new System.Drawing.Point(161, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(305, 354);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(182, 26);
            this.txtContactNo.TabIndex = 5;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(263, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Register Now!";
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(334, 458);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 41);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbCheck.ForeColor = System.Drawing.Color.Red;
            this.lbCheck.Location = new System.Drawing.Point(376, 414);
            this.lbCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(10, 14);
            this.lbCheck.TabIndex = 7;
            this.lbCheck.Text = " ";
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbPassword.ForeColor = System.Drawing.Color.Red;
            this.lbPassword.Location = new System.Drawing.Point(491, 247);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(233, 48);
            this.lbPassword.TabIndex = 10;
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbUsername.ForeColor = System.Drawing.Color.Red;
            this.lbUsername.Location = new System.Drawing.Point(491, 151);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(232, 51);
            this.lbUsername.TabIndex = 8;
            this.lbUsername.Text = " ";
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(491, 202);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(232, 45);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = " ";
            // 
            // lbContactNo
            // 
            this.lbContactNo.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbContactNo.ForeColor = System.Drawing.Color.Red;
            this.lbContactNo.Location = new System.Drawing.Point(491, 354);
            this.lbContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContactNo.Name = "lbContactNo";
            this.lbContactNo.Size = new System.Drawing.Size(233, 57);
            this.lbContactNo.TabIndex = 12;
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Controls.Add(this.LoginButton);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(724, 62);
            this.Header.TabIndex = 17;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.Image = global::OSCS.Properties.Resources.Shield;
            this.Logo.Location = new System.Drawing.Point(321, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 57);
            this.Logo.TabIndex = 25;
            this.Logo.UseVisualStyleBackColor = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(598, 15);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 33);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Georgia", 8F);
            this.lbConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.lbConfirmPassword.Location = new System.Drawing.Point(492, 303);
            this.lbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(232, 47);
            this.lbConfirmPassword.TabIndex = 11;
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
            this.button1.Location = new System.Drawing.Point(532, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Already registered? Activate your account here!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(721, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.lbContactNo);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbConfirmPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbCheck;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbContactNo;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Logo;
    }
}
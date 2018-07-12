namespace OSCS.WinForms.Login
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
            this.Header = new System.Windows.Forms.Panel();
            this.projectTitle = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FPLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.ConfirmFPButton = new System.Windows.Forms.Button();
            this.FPWarning = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
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
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(887, 73);
            this.Header.TabIndex = 17;
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
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(298, 132);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(258, 32);
            this.TitleLabel.TabIndex = 18;
            this.TitleLabel.Text = "Forget Password";
            // 
            // FPLabel
            // 
            this.FPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPLabel.AutoSize = true;
            this.FPLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPLabel.Location = new System.Drawing.Point(72, 185);
            this.FPLabel.Name = "FPLabel";
            this.FPLabel.Size = new System.Drawing.Size(712, 60);
            this.FPLabel.TabIndex = 19;
            this.FPLabel.Text = "Forgotten your password? Fear not. \r\nInput your email address used for our App an" +
    "d we will send you a link to reset your password.\r\n\r\n";
            this.FPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(333, 330);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(187, 27);
            this.email.TabIndex = 20;
            // 
            // ConfirmFPButton
            // 
            this.ConfirmFPButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmFPButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.ConfirmFPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ConfirmFPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ConfirmFPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmFPButton.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmFPButton.Location = new System.Drawing.Point(377, 394);
            this.ConfirmFPButton.Name = "ConfirmFPButton";
            this.ConfirmFPButton.Size = new System.Drawing.Size(106, 51);
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
            this.FPWarning.Location = new System.Drawing.Point(276, 279);
            this.FPWarning.Name = "FPWarning";
            this.FPWarning.Size = new System.Drawing.Size(0, 24);
            this.FPWarning.TabIndex = 22;
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
            this.RegisterButton.Location = new System.Drawing.Point(758, 16);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(126, 41);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.FPWarning);
            this.Controls.Add(this.ConfirmFPButton);
            this.Controls.Add(this.email);
            this.Controls.Add(this.FPLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Header);
            this.MaximizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Chat Protection";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
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
    }
}
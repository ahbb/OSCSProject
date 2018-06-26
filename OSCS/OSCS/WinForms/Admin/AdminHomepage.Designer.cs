namespace OSCS.WinForms.Admin
{
    partial class AdminHomepage
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AdminLogsButton = new System.Windows.Forms.Button();
            this.AdminAccountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(376, 55);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 32);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Welcome, Admin ";
            // 
            // AdminLogsButton
            // 
            this.AdminLogsButton.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogsButton.Location = new System.Drawing.Point(280, 250);
            this.AdminLogsButton.Name = "AdminLogsButton";
            this.AdminLogsButton.Size = new System.Drawing.Size(202, 44);
            this.AdminLogsButton.TabIndex = 18;
            this.AdminLogsButton.Text = "User Logs Management";
            this.AdminLogsButton.UseVisualStyleBackColor = true;
            this.AdminLogsButton.Click += new System.EventHandler(this.AdminLogsButton_Click);
            // 
            // AdminAccountsButton
            // 
            this.AdminAccountsButton.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAccountsButton.Location = new System.Drawing.Point(539, 250);
            this.AdminAccountsButton.Name = "AdminAccountsButton";
            this.AdminAccountsButton.Size = new System.Drawing.Size(246, 44);
            this.AdminAccountsButton.TabIndex = 19;
            this.AdminAccountsButton.Text = "User Accounts Management";
            this.AdminAccountsButton.UseVisualStyleBackColor = true;
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AdminAccountsButton);
            this.Controls.Add(this.AdminLogsButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AdminHomepage";
            this.Text = "Online Chat Protection";
            this.Load += new System.EventHandler(this.AdminHomepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AdminLogsButton;
        private System.Windows.Forms.Button AdminAccountsButton;
    }
}
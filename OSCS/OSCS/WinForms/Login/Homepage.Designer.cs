﻿namespace OSCS.WinForms.Login
{
    partial class Homepage
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
            this.Header = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.FileVirusScanner = new System.Windows.Forms.Button();
            this.FiddlerCapturing = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(230, 143);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 32);
            this.TitleLabel.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.logoutBtn);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1095, 90);
            this.Header.TabIndex = 18;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(941, 21);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(125, 41);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // projectTitle
            // 
            this.projectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectTitle.AutoSize = true;
            this.projectTitle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTitle.Location = new System.Drawing.Point(16, 27);
            this.projectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectTitle.MaximumSize = new System.Drawing.Size(333, 37);
            this.projectTitle.MinimumSize = new System.Drawing.Size(333, 37);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(333, 37);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
            // 
            // FileVirusScanner
            // 
            this.FileVirusScanner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FileVirusScanner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileVirusScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileVirusScanner.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileVirusScanner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileVirusScanner.Image = global::OSCS.Properties.Resources.FileVirusUpload;
            this.FileVirusScanner.Location = new System.Drawing.Point(570, 209);
            this.FileVirusScanner.Name = "FileVirusScanner";
            this.FileVirusScanner.Size = new System.Drawing.Size(298, 293);
            this.FileVirusScanner.TabIndex = 20;
            this.FileVirusScanner.Text = "File Virus Scanner";
            this.FileVirusScanner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FileVirusScanner.UseVisualStyleBackColor = false;
            this.FileVirusScanner.Click += new System.EventHandler(this.FileVirusScanner_Click);
            // 
            // FiddlerCapturing
            // 
            this.FiddlerCapturing.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FiddlerCapturing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FiddlerCapturing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiddlerCapturing.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiddlerCapturing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FiddlerCapturing.Image = global::OSCS.Properties.Resources.WifiRadarScanning;
            this.FiddlerCapturing.Location = new System.Drawing.Point(185, 209);
            this.FiddlerCapturing.Margin = new System.Windows.Forms.Padding(1);
            this.FiddlerCapturing.Name = "FiddlerCapturing";
            this.FiddlerCapturing.Size = new System.Drawing.Size(298, 293);
            this.FiddlerCapturing.TabIndex = 19;
            this.FiddlerCapturing.Text = "Fiddler Traffic Capturing";
            this.FiddlerCapturing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FiddlerCapturing.UseVisualStyleBackColor = false;
            this.FiddlerCapturing.Click += new System.EventHandler(this.FiddlerCapturing_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.FileVirusScanner);
            this.Controls.Add(this.FiddlerCapturing);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.ShowInTaskbar = false;
            this.Text = "Online Chat Protection";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Button FiddlerCapturing;
        private System.Windows.Forms.Button FileVirusScanner;
    }
}
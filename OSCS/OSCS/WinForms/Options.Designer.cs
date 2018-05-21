namespace OSCS
{
    partial class Options
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
            this.virusScannerBtn = new System.Windows.Forms.Button();
            this.logManagementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // virusScannerBtn
            // 
            this.virusScannerBtn.Location = new System.Drawing.Point(103, 70);
            this.virusScannerBtn.Name = "virusScannerBtn";
            this.virusScannerBtn.Size = new System.Drawing.Size(191, 92);
            this.virusScannerBtn.TabIndex = 0;
            this.virusScannerBtn.Text = "Virus Scanner";
            this.virusScannerBtn.UseVisualStyleBackColor = true;
            this.virusScannerBtn.Click += new System.EventHandler(this.virusScannerBtn_Click);
            // 
            // logManagementBtn
            // 
            this.logManagementBtn.Location = new System.Drawing.Point(421, 70);
            this.logManagementBtn.Name = "logManagementBtn";
            this.logManagementBtn.Size = new System.Drawing.Size(191, 92);
            this.logManagementBtn.TabIndex = 1;
            this.logManagementBtn.Text = "Log Management";
            this.logManagementBtn.UseVisualStyleBackColor = true;
            this.logManagementBtn.Click += new System.EventHandler(this.logManagementBtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logManagementBtn);
            this.Controls.Add(this.virusScannerBtn);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button virusScannerBtn;
        private System.Windows.Forms.Button logManagementBtn;
    }
}


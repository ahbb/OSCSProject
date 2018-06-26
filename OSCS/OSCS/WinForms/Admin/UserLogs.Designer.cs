namespace OSCS.WinForms.Admin
{
    partial class UserLogs
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
            this.dv = new System.Windows.Forms.DataGridView();
            this.noLogs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(353, 73);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(352, 32);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "User Logs Management";
            // 
            // dv
            // 
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(250, 180);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 24;
            this.dv.Size = new System.Drawing.Size(549, 351);
            this.dv.TabIndex = 4;
            // 
            // noLogs
            // 
            this.noLogs.AutoSize = true;
            this.noLogs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLogs.ForeColor = System.Drawing.Color.DarkRed;
            this.noLogs.Location = new System.Drawing.Point(424, 134);
            this.noLogs.Name = "noLogs";
            this.noLogs.Size = new System.Drawing.Size(193, 24);
            this.noLogs.TabIndex = 5;
            this.noLogs.Text = "No User Logs Found";
            this.noLogs.Visible = false;
            // 
            // UserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.noLogs);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.TitleLabel);
            this.Name = "UserLogs";
            this.Text = "UserLogs";
            this.Load += new System.EventHandler(this.UserLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Label noLogs;
    }
}
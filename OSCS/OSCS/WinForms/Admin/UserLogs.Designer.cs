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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogs));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.dv = new System.Windows.Forms.DataGridView();
            this.LogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogException = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noLogs = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(300, 94);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(456, 32);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Admin User Logs Management";
            // 
            // dv
            // 
            this.dv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogID,
            this.LogDateTime,
            this.LogLevel,
            this.LogSource,
            this.LogMessage,
            this.LogException,
            this.userID});
            this.dv.Location = new System.Drawing.Point(12, 179);
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            this.dv.RowTemplate.Height = 24;
            this.dv.Size = new System.Drawing.Size(1043, 346);
            this.dv.TabIndex = 4;
            // 
            // LogID
            // 
            this.LogID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogID.DefaultCellStyle = dataGridViewCellStyle1;
            this.LogID.FillWeight = 35F;
            this.LogID.HeaderText = "Log ID";
            this.LogID.Name = "LogID";
            this.LogID.ReadOnly = true;
            // 
            // LogDateTime
            // 
            this.LogDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogDateTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.LogDateTime.HeaderText = "Date and Time of Logged Event";
            this.LogDateTime.Name = "LogDateTime";
            this.LogDateTime.ReadOnly = true;
            // 
            // LogLevel
            // 
            this.LogLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogLevel.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogLevel.FillWeight = 35F;
            this.LogLevel.HeaderText = "Log Level";
            this.LogLevel.Name = "LogLevel";
            this.LogLevel.ReadOnly = true;
            // 
            // LogSource
            // 
            this.LogSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogSource.DefaultCellStyle = dataGridViewCellStyle4;
            this.LogSource.HeaderText = "Source of Logged Event";
            this.LogSource.Name = "LogSource";
            this.LogSource.ReadOnly = true;
            // 
            // LogMessage
            // 
            this.LogMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogMessage.DefaultCellStyle = dataGridViewCellStyle5;
            this.LogMessage.FillWeight = 120F;
            this.LogMessage.HeaderText = "Log Message";
            this.LogMessage.Name = "LogMessage";
            this.LogMessage.ReadOnly = true;
            // 
            // LogException
            // 
            this.LogException.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LogException.DefaultCellStyle = dataGridViewCellStyle6;
            this.LogException.FillWeight = 50F;
            this.LogException.HeaderText = "Log Exception";
            this.LogException.Name = "LogException";
            this.LogException.ReadOnly = true;
            // 
            // userID
            // 
            this.userID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.userID.DefaultCellStyle = dataGridViewCellStyle7;
            this.userID.FillWeight = 35F;
            this.userID.HeaderText = "ID of User\'s Logged Event";
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            // 
            // noLogs
            // 
            this.noLogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noLogs.AutoSize = true;
            this.noLogs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLogs.ForeColor = System.Drawing.Color.DarkRed;
            this.noLogs.Location = new System.Drawing.Point(426, 138);
            this.noLogs.Name = "noLogs";
            this.noLogs.Size = new System.Drawing.Size(193, 24);
            this.noLogs.TabIndex = 5;
            this.noLogs.Text = "No User Logs Found";
            this.noLogs.Visible = false;
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.LogoutButton);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1069, 79);
            this.Header.TabIndex = 17;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.Image = global::OSCS.Properties.Resources.Shield;
            this.Logo.Location = new System.Drawing.Point(491, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(87, 70);
            this.Logo.TabIndex = 23;
            this.Logo.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(948, 19);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(109, 41);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "Log Out";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // projectTitle
            // 
            this.projectTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectTitle.AutoSize = true;
            this.projectTitle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.projectTitle.Location = new System.Drawing.Point(12, 25);
            this.projectTitle.MaximumSize = new System.Drawing.Size(250, 30);
            this.projectTitle.MinimumSize = new System.Drawing.Size(250, 30);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(250, 30);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
            // 
            // UserLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.noLogs);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogs";
            this.Load += new System.EventHandler(this.UserLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Label noLogs;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogException;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
    }
}
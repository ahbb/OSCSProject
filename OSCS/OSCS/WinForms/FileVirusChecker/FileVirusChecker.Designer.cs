﻿namespace OSCS.WinForms.FileVirusChecker
{
    partial class FileVirusChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileVirusChecker));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.scanFile = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.logoutBtn);
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(821, 73);
            this.Header.TabIndex = 17;
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logo.Image = global::OSCS.Properties.Resources.Shield;
            this.Logo.Location = new System.Drawing.Point(378, 8);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(65, 57);
            this.Logo.TabIndex = 22;
            this.Logo.UseVisualStyleBackColor = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            this.logoutBtn.Location = new System.Drawing.Point(706, 17);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(94, 33);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "File Virus Checker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 138);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseFile
            // 
            this.chooseFile.BackColor = System.Drawing.Color.Honeydew;
            this.chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chooseFile.Location = new System.Drawing.Point(76, 251);
            this.chooseFile.Margin = new System.Windows.Forms.Padding(2);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(101, 46);
            this.chooseFile.TabIndex = 20;
            this.chooseFile.Text = "Choose a File";
            this.chooseFile.UseVisualStyleBackColor = false;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(73, 313);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(402, 57);
            this.fileName.TabIndex = 21;
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scanFile
            // 
            this.scanFile.BackColor = System.Drawing.Color.Honeydew;
            this.scanFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scanFile.Location = new System.Drawing.Point(76, 382);
            this.scanFile.Margin = new System.Windows.Forms.Padding(2);
            this.scanFile.Name = "scanFile";
            this.scanFile.Size = new System.Drawing.Size(101, 46);
            this.scanFile.TabIndex = 22;
            this.scanFile.Text = "Scan File";
            this.scanFile.UseVisualStyleBackColor = false;
            this.scanFile.Click += new System.EventHandler(this.scanFile_ClickAsync);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(73, 443);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(402, 79);
            this.result.TabIndex = 23;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Scan Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(503, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(278, 258);
            this.dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Antivirus Vendor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Detected";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FileVirusChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.scanFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FileVirusChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileVirusChecker";
            this.Load += new System.EventHandler(this.FileVirusChecker_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button scanFile;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
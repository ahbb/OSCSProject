namespace OSCS.WinForms.FileVirusChecker
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
            this.Header = new System.Windows.Forms.Panel();
            this.projectTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.scanFile = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1095, 90);
            this.Header.TabIndex = 17;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "File Virus Checker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 150);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseFile
            // 
            this.chooseFile.BackColor = System.Drawing.Color.Honeydew;
            this.chooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chooseFile.Location = new System.Drawing.Point(460, 339);
            this.chooseFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(135, 56);
            this.chooseFile.TabIndex = 20;
            this.chooseFile.Text = "Choose a File";
            this.chooseFile.UseVisualStyleBackColor = false;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(364, 415);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 20);
            this.fileName.TabIndex = 21;
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scanFile
            // 
            this.scanFile.BackColor = System.Drawing.Color.Honeydew;
            this.scanFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scanFile.Location = new System.Drawing.Point(460, 475);
            this.scanFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scanFile.Name = "scanFile";
            this.scanFile.Size = new System.Drawing.Size(135, 56);
            this.scanFile.TabIndex = 22;
            this.scanFile.Text = "Scan File";
            this.scanFile.UseVisualStyleBackColor = false;
            this.scanFile.Click += new System.EventHandler(this.scanFile_ClickAsync);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(349, 557);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 23;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FileVirusChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.result);
            this.Controls.Add(this.scanFile);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Header);
            this.Name = "FileVirusChecker";
            this.Text = "FileVirusChecker";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
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
    }
}
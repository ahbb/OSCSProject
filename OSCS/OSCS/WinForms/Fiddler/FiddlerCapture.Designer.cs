namespace OSCS.WinForms.Fiddler
{
    partial class FiddlerCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiddlerCapture));
            this.tbCapture = new System.Windows.Forms.Button();
            this.tbStop = new System.Windows.Forms.Button();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.txtCapture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.projectTitle = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCapture
            // 
            this.tbCapture.Location = new System.Drawing.Point(11, 180);
            this.tbCapture.Margin = new System.Windows.Forms.Padding(2);
            this.tbCapture.Name = "tbCapture";
            this.tbCapture.Size = new System.Drawing.Size(65, 27);
            this.tbCapture.TabIndex = 0;
            this.tbCapture.Text = "Start";
            this.tbCapture.UseVisualStyleBackColor = true;
            this.tbCapture.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(91, 180);
            this.tbStop.Margin = new System.Windows.Forms.Padding(2);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(65, 27);
            this.tbStop.TabIndex = 1;
            this.tbStop.Text = "Stop";
            this.tbStop.UseVisualStyleBackColor = true;
            this.tbStop.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbClear
            // 
            this.tbClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClear.Location = new System.Drawing.Point(724, 180);
            this.tbClear.Margin = new System.Windows.Forms.Padding(2);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(65, 27);
            this.tbClear.TabIndex = 2;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbSave
            // 
            this.tbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSave.Location = new System.Drawing.Point(644, 180);
            this.tbSave.Margin = new System.Windows.Forms.Padding(2);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(65, 27);
            this.tbSave.TabIndex = 3;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // txtCapture
            // 
            this.txtCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapture.Location = new System.Drawing.Point(-3, 222);
            this.txtCapture.Margin = new System.Windows.Forms.Padding(2);
            this.txtCapture.Multiline = true;
            this.txtCapture.Name = "txtCapture";
            this.txtCapture.ReadOnly = true;
            this.txtCapture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCapture.Size = new System.Drawing.Size(805, 236);
            this.txtCapture.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Traffic Capturing";
            // 
            // Header
            // 
            this.Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.MidnightBlue;
            this.Header.Controls.Add(this.projectTitle);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(887, 73);
            this.Header.TabIndex = 16;
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
            // FiddlerCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapture);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.tbCapture);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FiddlerCapture";
            this.Text = "FiddlerCapture";
            this.Load += new System.EventHandler(this.FiddlerCapture_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbCapture;
        private System.Windows.Forms.Button tbStop;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.TextBox txtCapture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label projectTitle;
    }
}
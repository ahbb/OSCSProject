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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.projectTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCapture
            // 
            this.tbCapture.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbCapture.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.tbCapture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tbCapture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tbCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCapture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbCapture.Location = new System.Drawing.Point(15, 222);
            this.tbCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCapture.Name = "tbCapture";
            this.tbCapture.Size = new System.Drawing.Size(101, 47);
            this.tbCapture.TabIndex = 0;
            this.tbCapture.Text = "Start";
            this.tbCapture.UseVisualStyleBackColor = false;
            this.tbCapture.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbStop
            // 
            this.tbStop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbStop.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.tbStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tbStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tbStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStop.Location = new System.Drawing.Point(121, 222);
            this.tbStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(101, 47);
            this.tbStop.TabIndex = 1;
            this.tbStop.Text = "Stop";
            this.tbStop.UseVisualStyleBackColor = false;
            this.tbStop.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbClear
            // 
            this.tbClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.tbClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tbClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tbClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClear.Location = new System.Drawing.Point(951, 222);
            this.tbClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(101, 47);
            this.tbClear.TabIndex = 2;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = false;
            this.tbClear.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbSave
            // 
            this.tbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.tbSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tbSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.tbSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSave.Location = new System.Drawing.Point(844, 222);
            this.tbSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(101, 47);
            this.tbSave.TabIndex = 3;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = false;
            this.tbSave.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // txtCapture
            // 
            this.txtCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapture.Location = new System.Drawing.Point(-4, 327);
            this.txtCapture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapture.Multiline = true;
            this.txtCapture.Name = "txtCapture";
            this.txtCapture.ReadOnly = true;
            this.txtCapture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCapture.Size = new System.Drawing.Size(1072, 307);
            this.txtCapture.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Traffic Capturing";
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
            this.Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1068, 90);
            this.Header.TabIndex = 16;
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
            this.logoutBtn.Location = new System.Drawing.Point(927, 21);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(125, 41);
            this.logoutBtn.TabIndex = 11;
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
            this.projectTitle.Location = new System.Drawing.Point(16, 27);
            this.projectTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectTitle.MaximumSize = new System.Drawing.Size(333, 37);
            this.projectTitle.MinimumSize = new System.Drawing.Size(333, 37);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(333, 37);
            this.projectTitle.TabIndex = 2;
            this.projectTitle.Text = "Online Chat Protection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Traffic Output:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 57);
            this.label4.TabIndex = 18;
            this.label4.Text = "Click yes when prompted to install the certificate so that you will be protected " +
    "when using Discord. When you choose to stop capturing traffic, click yes to unin" +
    "stall the certificate.\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiddlerCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1067, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapture);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.tbCapture);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FiddlerCapture";
            this.Text = "FiddlerCapture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FiddlerCapture_FormClosed);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logoutBtn;
    }
}
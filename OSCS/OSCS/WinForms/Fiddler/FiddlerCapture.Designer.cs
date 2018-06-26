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
            this.tbCapture = new System.Windows.Forms.Button();
            this.tbStop = new System.Windows.Forms.Button();
            this.tbClear = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.txtCapture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCapture
            // 
            this.tbCapture.Location = new System.Drawing.Point(66, 70);
            this.tbCapture.Name = "tbCapture";
            this.tbCapture.Size = new System.Drawing.Size(75, 23);
            this.tbCapture.TabIndex = 0;
            this.tbCapture.Text = "Start";
            this.tbCapture.UseVisualStyleBackColor = true;
            this.tbCapture.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbStop
            // 
            this.tbStop.Location = new System.Drawing.Point(180, 70);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(75, 23);
            this.tbStop.TabIndex = 1;
            this.tbStop.Text = "Stop";
            this.tbStop.UseVisualStyleBackColor = true;
            this.tbStop.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbClear
            // 
            this.tbClear.Location = new System.Drawing.Point(386, 70);
            this.tbClear.Name = "tbClear";
            this.tbClear.Size = new System.Drawing.Size(75, 23);
            this.tbClear.TabIndex = 2;
            this.tbClear.Text = "Clear";
            this.tbClear.UseVisualStyleBackColor = true;
            this.tbClear.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(284, 70);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(75, 23);
            this.tbSave.TabIndex = 3;
            this.tbSave.Text = "Save";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.ButtonHandler);
            // 
            // txtCapture
            // 
            this.txtCapture.Location = new System.Drawing.Point(109, 130);
            this.txtCapture.Multiline = true;
            this.txtCapture.Name = "txtCapture";
            this.txtCapture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCapture.Size = new System.Drawing.Size(802, 387);
            this.txtCapture.TabIndex = 4;
            // 
            // FiddlerCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCapture);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbClear);
            this.Controls.Add(this.tbStop);
            this.Controls.Add(this.tbCapture);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FiddlerCapture";
            this.Text = "FiddlerCapture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbCapture;
        private System.Windows.Forms.Button tbStop;
        private System.Windows.Forms.Button tbClear;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.TextBox txtCapture;
    }
}
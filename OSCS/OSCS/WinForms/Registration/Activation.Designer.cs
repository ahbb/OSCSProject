namespace OSCS.WinForms.Registration
{
    partial class Activation
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.lbActivation = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Activate your account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter the activation code received in your email";
            // 
            // txtActivation
            // 
            this.txtActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivation.Location = new System.Drawing.Point(344, 242);
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.Size = new System.Drawing.Size(241, 30);
            this.txtActivation.TabIndex = 5;
            this.txtActivation.TextChanged += new System.EventHandler(this.txtActivation_TextChanged);
            // 
            // lbActivation
            // 
            this.lbActivation.AutoSize = true;
            this.lbActivation.ForeColor = System.Drawing.Color.Red;
            this.lbActivation.Location = new System.Drawing.Point(591, 252);
            this.lbActivation.Name = "lbActivation";
            this.lbActivation.Size = new System.Drawing.Size(12, 17);
            this.lbActivation.TabIndex = 6;
            this.lbActivation.Text = " ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(390, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 37);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 555);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbActivation);
            this.Controls.Add(this.txtActivation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Activation";
            this.Text = "Activation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActivation;
        private System.Windows.Forms.Label lbActivation;
        private System.Windows.Forms.Button btnSubmit;
    }
}
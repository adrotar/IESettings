namespace iDocCreatorIESetup
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TrustedURL = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToTrusted = new System.Windows.Forms.Button();
            this.lstTrustedSites = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TrustedURL
            // 
            this.TrustedURL.Font = new System.Drawing.Font("Calibri", 12F);
            this.TrustedURL.Location = new System.Drawing.Point(28, 88);
            this.TrustedURL.Name = "TrustedURL";
            this.TrustedURL.Size = new System.Drawing.Size(168, 25);
            this.TrustedURL.TabIndex = 1;
            this.TrustedURL.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Trusted Sites";
            // 
            // AddToTrusted
            // 
            this.AddToTrusted.AutoSize = true;
            this.AddToTrusted.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToTrusted.Location = new System.Drawing.Point(37, 119);
            this.AddToTrusted.Name = "AddToTrusted";
            this.AddToTrusted.Size = new System.Drawing.Size(150, 29);
            this.AddToTrusted.TabIndex = 4;
            this.AddToTrusted.Text = "Add To Trusted Sites";
            this.AddToTrusted.UseVisualStyleBackColor = true;
            this.AddToTrusted.Click += new System.EventHandler(this.AddToTrusted_Click);
            // 
            // lstTrustedSites
            // 
            this.lstTrustedSites.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTrustedSites.FormattingEnabled = true;
            this.lstTrustedSites.ItemHeight = 19;
            this.lstTrustedSites.Location = new System.Drawing.Point(242, 70);
            this.lstTrustedSites.Name = "lstTrustedSites";
            this.lstTrustedSites.Size = new System.Drawing.Size(128, 156);
            this.lstTrustedSites.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 471);
            this.Controls.Add(this.lstTrustedSites);
            this.Controls.Add(this.AddToTrusted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrustedURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox TrustedURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToTrusted;
        private System.Windows.Forms.ListBox lstTrustedSites;
    }
}


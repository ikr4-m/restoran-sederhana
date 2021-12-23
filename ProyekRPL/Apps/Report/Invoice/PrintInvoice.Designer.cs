namespace ProyekRPL.Apps.Report.Invoice
{
    partial class PrintInvoice
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
            this.SaveJpegBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveJpegBtn
            // 
            this.SaveJpegBtn.Location = new System.Drawing.Point(12, 12);
            this.SaveJpegBtn.Name = "SaveJpegBtn";
            this.SaveJpegBtn.Size = new System.Drawing.Size(110, 67);
            this.SaveJpegBtn.TabIndex = 0;
            this.SaveJpegBtn.Text = "Save to JPEG";
            this.SaveJpegBtn.UseVisualStyleBackColor = true;
            this.SaveJpegBtn.Click += new System.EventHandler(this.SaveJpegBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(244, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(110, 67);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(128, 12);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(110, 67);
            this.PrintBtn.TabIndex = 2;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 91);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveJpegBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.PrintInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveJpegBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button PrintBtn;
    }
}
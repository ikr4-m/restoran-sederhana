namespace ProyekRPL.Apps.Cashier
{
    partial class Transaction
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
            this.GrandTotalTxt = new MetroFramework.Controls.MetroTextBox();
            this.PayTxt = new MetroFramework.Controls.MetroTextBox();
            this.ChangeTxt = new MetroFramework.Controls.MetroTextBox();
            this.ExecuteBtn = new MetroFramework.Controls.MetroButton();
            this.CancelBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // GrandTotalTxt
            // 
            // 
            // 
            // 
            this.GrandTotalTxt.CustomButton.Image = null;
            this.GrandTotalTxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.GrandTotalTxt.CustomButton.Name = "";
            this.GrandTotalTxt.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.GrandTotalTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrandTotalTxt.CustomButton.TabIndex = 1;
            this.GrandTotalTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrandTotalTxt.CustomButton.UseSelectable = true;
            this.GrandTotalTxt.CustomButton.Visible = false;
            this.GrandTotalTxt.Enabled = false;
            this.GrandTotalTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.GrandTotalTxt.Lines = new string[0];
            this.GrandTotalTxt.Location = new System.Drawing.Point(173, 68);
            this.GrandTotalTxt.MaxLength = 32767;
            this.GrandTotalTxt.Name = "GrandTotalTxt";
            this.GrandTotalTxt.PasswordChar = '\0';
            this.GrandTotalTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GrandTotalTxt.SelectedText = "";
            this.GrandTotalTxt.SelectionLength = 0;
            this.GrandTotalTxt.SelectionStart = 0;
            this.GrandTotalTxt.ShortcutsEnabled = true;
            this.GrandTotalTxt.Size = new System.Drawing.Size(230, 33);
            this.GrandTotalTxt.TabIndex = 0;
            this.GrandTotalTxt.UseSelectable = true;
            this.GrandTotalTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GrandTotalTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PayTxt
            // 
            // 
            // 
            // 
            this.PayTxt.CustomButton.Image = null;
            this.PayTxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.PayTxt.CustomButton.Name = "";
            this.PayTxt.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.PayTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PayTxt.CustomButton.TabIndex = 1;
            this.PayTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PayTxt.CustomButton.UseSelectable = true;
            this.PayTxt.CustomButton.Visible = false;
            this.PayTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.PayTxt.Lines = new string[] {
        "0"};
            this.PayTxt.Location = new System.Drawing.Point(173, 107);
            this.PayTxt.MaxLength = 32767;
            this.PayTxt.Name = "PayTxt";
            this.PayTxt.PasswordChar = '\0';
            this.PayTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PayTxt.SelectedText = "";
            this.PayTxt.SelectionLength = 0;
            this.PayTxt.SelectionStart = 0;
            this.PayTxt.ShortcutsEnabled = true;
            this.PayTxt.Size = new System.Drawing.Size(230, 33);
            this.PayTxt.TabIndex = 1;
            this.PayTxt.Text = "0";
            this.PayTxt.UseSelectable = true;
            this.PayTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PayTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PayTxt.TextChanged += new System.EventHandler(this.PayTxt_TextChanged);
            this.PayTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PayTxt_KeyDown);
            // 
            // ChangeTxt
            // 
            // 
            // 
            // 
            this.ChangeTxt.CustomButton.Image = null;
            this.ChangeTxt.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.ChangeTxt.CustomButton.Name = "";
            this.ChangeTxt.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.ChangeTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangeTxt.CustomButton.TabIndex = 1;
            this.ChangeTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChangeTxt.CustomButton.UseSelectable = true;
            this.ChangeTxt.CustomButton.Visible = false;
            this.ChangeTxt.Enabled = false;
            this.ChangeTxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ChangeTxt.Lines = new string[0];
            this.ChangeTxt.Location = new System.Drawing.Point(173, 146);
            this.ChangeTxt.MaxLength = 32767;
            this.ChangeTxt.Name = "ChangeTxt";
            this.ChangeTxt.PasswordChar = '\0';
            this.ChangeTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChangeTxt.SelectedText = "";
            this.ChangeTxt.SelectionLength = 0;
            this.ChangeTxt.SelectionStart = 0;
            this.ChangeTxt.ShortcutsEnabled = true;
            this.ChangeTxt.Size = new System.Drawing.Size(230, 33);
            this.ChangeTxt.TabIndex = 2;
            this.ChangeTxt.UseSelectable = true;
            this.ChangeTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChangeTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(257, 194);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(87, 38);
            this.ExecuteBtn.TabIndex = 3;
            this.ExecuteBtn.Text = "Bayar";
            this.ExecuteBtn.UseSelectable = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(87, 194);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(87, 38);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Kembali";
            this.CancelBtn.UseSelectable = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(43, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Total";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(43, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Bayar";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(43, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Kembalian";
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 264);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.ChangeTxt);
            this.Controls.Add(this.PayTxt);
            this.Controls.Add(this.GrandTotalTxt);
            this.Name = "Transaction";
            this.Resizable = false;
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox GrandTotalTxt;
        private MetroFramework.Controls.MetroTextBox PayTxt;
        private MetroFramework.Controls.MetroTextBox ChangeTxt;
        private MetroFramework.Controls.MetroButton ExecuteBtn;
        private MetroFramework.Controls.MetroButton CancelBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
namespace ProyekRPL.Apps.Report.Transaction
{
    partial class TransactionList
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
            this.ReportDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthCal = new System.Windows.Forms.MonthCalendar();
            this.StartPeriode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EndPeriode = new System.Windows.Forms.TextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportDG
            // 
            this.ReportDG.AllowUserToAddRows = false;
            this.ReportDG.AllowUserToDeleteRows = false;
            this.ReportDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Timestamp,
            this.InvoiceID,
            this.Qty,
            this.Amount});
            this.ReportDG.Location = new System.Drawing.Point(12, 57);
            this.ReportDG.Name = "ReportDG";
            this.ReportDG.ReadOnly = true;
            this.ReportDG.Size = new System.Drawing.Size(960, 496);
            this.ReportDG.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periode";
            // 
            // MonthCal
            // 
            this.MonthCal.Location = new System.Drawing.Point(78, 42);
            this.MonthCal.Name = "MonthCal";
            this.MonthCal.TabIndex = 2;
            this.MonthCal.Visible = false;
            this.MonthCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCal_DateChanged);
            this.MonthCal.MouseLeave += new System.EventHandler(this.MonthCal_MouseLeave);
            // 
            // StartPeriode
            // 
            this.StartPeriode.Location = new System.Drawing.Point(75, 20);
            this.StartPeriode.Name = "StartPeriode";
            this.StartPeriode.ReadOnly = true;
            this.StartPeriode.Size = new System.Drawing.Size(103, 20);
            this.StartPeriode.TabIndex = 3;
            this.StartPeriode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartPeriode_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // EndPeriode
            // 
            this.EndPeriode.Location = new System.Drawing.Point(202, 20);
            this.EndPeriode.Name = "EndPeriode";
            this.EndPeriode.ReadOnly = true;
            this.EndPeriode.Size = new System.Drawing.Size(103, 20);
            this.EndPeriode.TabIndex = 5;
            this.EndPeriode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EndPeriode_MouseClick);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(882, 10);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(90, 41);
            this.PrintBtn.TabIndex = 6;
            this.PrintBtn.Text = "Cetak";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(311, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 41);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Cari";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            // 
            // InvoiceID
            // 
            this.InvoiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Total Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Total Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // TransactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.EndPeriode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartPeriode);
            this.Controls.Add(this.MonthCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportDG);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Transaksi";
            this.Load += new System.EventHandler(this.TransactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportDG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar MonthCal;
        private System.Windows.Forms.TextBox StartPeriode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndPeriode;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
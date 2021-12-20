namespace ProyekRPL.Apps.Report.Invoice
{
    partial class PeekInvoice
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
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MenuID,
            this.NamaMenu,
            this.Harga,
            this.Qty,
            this.Total});
            this.OrderDataGrid.Location = new System.Drawing.Point(12, 12);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.Size = new System.Drawing.Size(707, 270);
            this.OrderDataGrid.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // MenuID
            // 
            this.MenuID.HeaderText = "MID";
            this.MenuID.Name = "MenuID";
            this.MenuID.ReadOnly = true;
            this.MenuID.Width = 50;
            // 
            // NamaMenu
            // 
            this.NamaMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaMenu.HeaderText = "Nama Menu";
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(12, 295);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(707, 29);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total: Rp0";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PeekInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 333);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.OrderDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PeekInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PeekInvoice";
            this.Load += new System.EventHandler(this.PeekInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label TotalLabel;
    }
}
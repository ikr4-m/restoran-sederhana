namespace ProyekRPL.Apps.Tracing
{
    partial class Tracer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.CallingQuery = new System.Windows.Forms.Timer(this.components);
            this.PeekOrderBtn = new MetroFramework.Controls.MetroButton();
            this.ProcessBtn = new MetroFramework.Controls.MetroButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPemesan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomorMeja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.InvoiceID,
            this.Timestamp,
            this.NamaPemesan,
            this.NomorMeja,
            this.StatusPesanan});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDataGrid.Location = new System.Drawing.Point(23, 77);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.Size = new System.Drawing.Size(812, 465);
            this.OrderDataGrid.TabIndex = 0;
            this.OrderDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderDataGrid_KeyDown);
            this.OrderDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OrderDataGrid_MouseDoubleClick);
            // 
            // CallingQuery
            // 
            this.CallingQuery.Interval = 1000;
            this.CallingQuery.Tick += new System.EventHandler(this.CallingQuery_Tick);
            // 
            // PeekOrderBtn
            // 
            this.PeekOrderBtn.Location = new System.Drawing.Point(841, 77);
            this.PeekOrderBtn.Name = "PeekOrderBtn";
            this.PeekOrderBtn.Size = new System.Drawing.Size(125, 47);
            this.PeekOrderBtn.TabIndex = 1;
            this.PeekOrderBtn.Text = "Cek Pesanan";
            this.PeekOrderBtn.UseSelectable = true;
            this.PeekOrderBtn.Click += new System.EventHandler(this.PeekOrderBtn_Click);
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(841, 130);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(125, 47);
            this.ProcessBtn.TabIndex = 2;
            this.ProcessBtn.Text = "Proses (F1)";
            this.ProcessBtn.UseSelectable = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "InvoiceID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // Timestamp
            // 
            this.Timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            // 
            // NamaPemesan
            // 
            this.NamaPemesan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaPemesan.HeaderText = "Nama Pemesan";
            this.NamaPemesan.Name = "NamaPemesan";
            this.NamaPemesan.ReadOnly = true;
            // 
            // NomorMeja
            // 
            this.NomorMeja.HeaderText = "No. Meja";
            this.NomorMeja.Name = "NomorMeja";
            this.NomorMeja.ReadOnly = true;
            // 
            // StatusPesanan
            // 
            this.StatusPesanan.HeaderText = "Status";
            this.StatusPesanan.Name = "StatusPesanan";
            this.StatusPesanan.ReadOnly = true;
            // 
            // Tracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.PeekOrderBtn);
            this.Controls.Add(this.OrderDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tracer";
            this.Text = "Tracer: ";
            this.Load += new System.EventHandler(this.Tracer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Timer CallingQuery;
        private MetroFramework.Controls.MetroButton PeekOrderBtn;
        private MetroFramework.Controls.MetroButton ProcessBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPemesan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomorMeja;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPesanan;
    }
}
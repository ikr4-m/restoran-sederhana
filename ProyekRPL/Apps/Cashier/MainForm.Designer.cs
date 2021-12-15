namespace ProyekRPL.Apps.Cashier
{
    partial class MainForm
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
            this.IDOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuDataGrid = new System.Windows.Forms.DataGridView();
            this.IDMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMenuDisplay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BuyBtn = new MetroFramework.Controls.MetroButton();
            this.PrintBtn = new MetroFramework.Controls.MetroButton();
            this.ResetBtn = new MetroFramework.Controls.MetroButton();
            this.CustomerNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TableNumberTxt = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.InvoiceIDTxt = new MetroFramework.Controls.MetroTextBox();
            this.SyncBtn = new MetroFramework.Controls.MetroButton();
            this.ChangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNumberTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOrder,
            this.NamaMenu,
            this.Harga,
            this.Qty,
            this.Total});
            this.OrderDataGrid.Location = new System.Drawing.Point(23, 131);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.Size = new System.Drawing.Size(694, 450);
            this.OrderDataGrid.TabIndex = 1;
            this.OrderDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderDataGrid_KeyDown);
            // 
            // IDOrder
            // 
            this.IDOrder.HeaderText = "ID";
            this.IDOrder.Name = "IDOrder";
            this.IDOrder.ReadOnly = true;
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
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // MenuDataGrid
            // 
            this.MenuDataGrid.AllowUserToAddRows = false;
            this.MenuDataGrid.AllowUserToDeleteRows = false;
            this.MenuDataGrid.AllowUserToResizeColumns = false;
            this.MenuDataGrid.AllowUserToResizeRows = false;
            this.MenuDataGrid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.MenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMenu,
            this.NamaMenuDisplay,
            this.HargaMenu});
            this.MenuDataGrid.Location = new System.Drawing.Point(734, 163);
            this.MenuDataGrid.Name = "MenuDataGrid";
            this.MenuDataGrid.Size = new System.Drawing.Size(243, 418);
            this.MenuDataGrid.TabIndex = 2;
            this.MenuDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuDataGrid_KeyDown);
            this.MenuDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MenuDataGrid_MouseDoubleClick);
            // 
            // IDMenu
            // 
            this.IDMenu.HeaderText = "ID";
            this.IDMenu.Name = "IDMenu";
            this.IDMenu.ReadOnly = true;
            this.IDMenu.Width = 50;
            // 
            // NamaMenuDisplay
            // 
            this.NamaMenuDisplay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaMenuDisplay.HeaderText = "Nama Menu";
            this.NamaMenuDisplay.Name = "NamaMenuDisplay";
            this.NamaMenuDisplay.ReadOnly = true;
            // 
            // HargaMenu
            // 
            this.HargaMenu.HeaderText = "Harga";
            this.HargaMenu.Name = "HargaMenu";
            this.HargaMenu.ReadOnly = true;
            this.HargaMenu.Visible = false;
            // 
            // MenuSearchTxt
            // 
            // 
            // 
            // 
            this.MenuSearchTxt.CustomButton.Image = null;
            this.MenuSearchTxt.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.MenuSearchTxt.CustomButton.Name = "";
            this.MenuSearchTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MenuSearchTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MenuSearchTxt.CustomButton.TabIndex = 1;
            this.MenuSearchTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MenuSearchTxt.CustomButton.UseSelectable = true;
            this.MenuSearchTxt.CustomButton.Visible = false;
            this.MenuSearchTxt.Lines = new string[0];
            this.MenuSearchTxt.Location = new System.Drawing.Point(734, 131);
            this.MenuSearchTxt.MaxLength = 32767;
            this.MenuSearchTxt.Name = "MenuSearchTxt";
            this.MenuSearchTxt.PasswordChar = '\0';
            this.MenuSearchTxt.PromptText = "Cari Barang (F1)";
            this.MenuSearchTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MenuSearchTxt.SelectedText = "";
            this.MenuSearchTxt.SelectionLength = 0;
            this.MenuSearchTxt.SelectionStart = 0;
            this.MenuSearchTxt.ShortcutsEnabled = true;
            this.MenuSearchTxt.Size = new System.Drawing.Size(243, 23);
            this.MenuSearchTxt.TabIndex = 3;
            this.MenuSearchTxt.UseSelectable = true;
            this.MenuSearchTxt.WaterMark = "Cari Barang (F1)";
            this.MenuSearchTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MenuSearchTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MenuSearchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuSearchTxt_KeyDown);
            // 
            // PriceLabel
            // 
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(731, 45);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(246, 74);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Rp0";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(23, 92);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(88, 33);
            this.BuyBtn.TabIndex = 5;
            this.BuyBtn.Text = "Bayar (F2)";
            this.BuyBtn.UseSelectable = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Enabled = false;
            this.PrintBtn.Location = new System.Drawing.Point(117, 92);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(88, 33);
            this.PrintBtn.TabIndex = 6;
            this.PrintBtn.Text = "Cetak (F3)";
            this.PrintBtn.UseSelectable = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(211, 92);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 33);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset (F4)";
            this.ResetBtn.UseSelectable = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CustomerNameTxt
            // 
            // 
            // 
            // 
            this.CustomerNameTxt.CustomButton.Image = null;
            this.CustomerNameTxt.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.CustomerNameTxt.CustomButton.Name = "";
            this.CustomerNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CustomerNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustomerNameTxt.CustomButton.TabIndex = 1;
            this.CustomerNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustomerNameTxt.CustomButton.UseSelectable = true;
            this.CustomerNameTxt.CustomButton.Visible = false;
            this.CustomerNameTxt.Lines = new string[0];
            this.CustomerNameTxt.Location = new System.Drawing.Point(139, 63);
            this.CustomerNameTxt.MaxLength = 32767;
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.PasswordChar = '\0';
            this.CustomerNameTxt.PromptText = "(F5)";
            this.CustomerNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustomerNameTxt.SelectedText = "";
            this.CustomerNameTxt.SelectionLength = 0;
            this.CustomerNameTxt.SelectionStart = 0;
            this.CustomerNameTxt.ShortcutsEnabled = true;
            this.CustomerNameTxt.Size = new System.Drawing.Size(160, 23);
            this.CustomerNameTxt.TabIndex = 8;
            this.CustomerNameTxt.UseSelectable = true;
            this.CustomerNameTxt.WaterMark = "(F5)";
            this.CustomerNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustomerNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Nama Pelanggan";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(330, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "No. Meja (F6)";
            // 
            // TableNumberTxt
            // 
            this.TableNumberTxt.Location = new System.Drawing.Point(446, 63);
            this.TableNumberTxt.Name = "TableNumberTxt";
            this.TableNumberTxt.Size = new System.Drawing.Size(160, 20);
            this.TableNumberTxt.TabIndex = 12;
            this.TableNumberTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(330, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "ID Faktur";
            // 
            // InvoiceIDTxt
            // 
            // 
            // 
            // 
            this.InvoiceIDTxt.CustomButton.Image = null;
            this.InvoiceIDTxt.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.InvoiceIDTxt.CustomButton.Name = "";
            this.InvoiceIDTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.InvoiceIDTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InvoiceIDTxt.CustomButton.TabIndex = 1;
            this.InvoiceIDTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InvoiceIDTxt.CustomButton.UseSelectable = true;
            this.InvoiceIDTxt.CustomButton.Visible = false;
            this.InvoiceIDTxt.Enabled = false;
            this.InvoiceIDTxt.Lines = new string[0];
            this.InvoiceIDTxt.Location = new System.Drawing.Point(446, 96);
            this.InvoiceIDTxt.MaxLength = 32767;
            this.InvoiceIDTxt.Name = "InvoiceIDTxt";
            this.InvoiceIDTxt.PasswordChar = '\0';
            this.InvoiceIDTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InvoiceIDTxt.SelectedText = "";
            this.InvoiceIDTxt.SelectionLength = 0;
            this.InvoiceIDTxt.SelectionStart = 0;
            this.InvoiceIDTxt.ShortcutsEnabled = true;
            this.InvoiceIDTxt.Size = new System.Drawing.Size(160, 23);
            this.InvoiceIDTxt.TabIndex = 13;
            this.InvoiceIDTxt.UseSelectable = true;
            this.InvoiceIDTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InvoiceIDTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SyncBtn
            // 
            this.SyncBtn.Location = new System.Drawing.Point(636, 63);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(80, 55);
            this.SyncBtn.TabIndex = 15;
            this.SyncBtn.Text = "Sync (F10)";
            this.SyncBtn.UseSelectable = true;
            this.SyncBtn.Click += new System.EventHandler(this.SyncBtn_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(163, 281);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(380, 119);
            this.ChangeLabel.TabIndex = 16;
            this.ChangeLabel.Text = "Kembalian:\r\nRp0";
            this.ChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 604);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.SyncBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.InvoiceIDTxt);
            this.Controls.Add(this.TableNumberTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CustomerNameTxt);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MenuSearchTxt);
            this.Controls.Add(this.MenuDataGrid);
            this.Controls.Add(this.OrderDataGrid);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Point of Sale";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableNumberTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView MenuDataGrid;
        private MetroFramework.Controls.MetroTextBox MenuSearchTxt;
        private System.Windows.Forms.Label PriceLabel;
        private MetroFramework.Controls.MetroButton BuyBtn;
        private MetroFramework.Controls.MetroButton PrintBtn;
        private MetroFramework.Controls.MetroButton ResetBtn;
        private MetroFramework.Controls.MetroTextBox CustomerNameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown TableNumberTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox InvoiceIDTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMenuDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaMenu;
        private MetroFramework.Controls.MetroButton SyncBtn;
        private System.Windows.Forms.Label ChangeLabel;
    }
}
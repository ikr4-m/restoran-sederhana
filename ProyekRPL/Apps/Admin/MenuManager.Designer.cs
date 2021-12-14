namespace ProyekRPL.Apps.Admin
{
    partial class MenuManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MenuRefreshData = new MetroFramework.Controls.MetroButton();
            this.MenuDeleteData = new MetroFramework.Controls.MetroButton();
            this.MenuEditData = new MetroFramework.Controls.MetroButton();
            this.MenuInsertData = new MetroFramework.Controls.MetroButton();
            this.MenuDataGrid = new MetroFramework.Controls.MetroGrid();
            this.IDMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSearchTextBox
            // 
            // 
            // 
            // 
            this.MenuSearchTextBox.CustomButton.Image = null;
            this.MenuSearchTextBox.CustomButton.Location = new System.Drawing.Point(627, 1);
            this.MenuSearchTextBox.CustomButton.Name = "";
            this.MenuSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MenuSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MenuSearchTextBox.CustomButton.TabIndex = 1;
            this.MenuSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MenuSearchTextBox.CustomButton.UseSelectable = true;
            this.MenuSearchTextBox.CustomButton.Visible = false;
            this.MenuSearchTextBox.Lines = new string[0];
            this.MenuSearchTextBox.Location = new System.Drawing.Point(23, 71);
            this.MenuSearchTextBox.MaxLength = 32767;
            this.MenuSearchTextBox.Name = "MenuSearchTextBox";
            this.MenuSearchTextBox.PasswordChar = '\0';
            this.MenuSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MenuSearchTextBox.SelectedText = "";
            this.MenuSearchTextBox.SelectionLength = 0;
            this.MenuSearchTextBox.SelectionStart = 0;
            this.MenuSearchTextBox.ShortcutsEnabled = true;
            this.MenuSearchTextBox.Size = new System.Drawing.Size(649, 23);
            this.MenuSearchTextBox.TabIndex = 20;
            this.MenuSearchTextBox.UseSelectable = true;
            this.MenuSearchTextBox.WaterMark = "Cari di sini";
            this.MenuSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MenuSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MenuSearchTextBox.KeyDown += MenuSearchTextBox_KeyDown;
            // 
            // MenuRefreshData
            // 
            this.MenuRefreshData.Location = new System.Drawing.Point(696, 242);
            this.MenuRefreshData.Name = "MenuRefreshData";
            this.MenuRefreshData.Size = new System.Drawing.Size(100, 50);
            this.MenuRefreshData.TabIndex = 19;
            this.MenuRefreshData.Text = "Refresh Menu";
            this.MenuRefreshData.UseSelectable = true;
            this.MenuRefreshData.Click += new System.EventHandler(this.MenuRefreshData_Click);
            // 
            // MenuDeleteData
            // 
            this.MenuDeleteData.Location = new System.Drawing.Point(696, 186);
            this.MenuDeleteData.Name = "MenuDeleteData";
            this.MenuDeleteData.Size = new System.Drawing.Size(100, 50);
            this.MenuDeleteData.TabIndex = 18;
            this.MenuDeleteData.Text = "Hapus Menu";
            this.MenuDeleteData.UseSelectable = true;
            this.MenuDeleteData.Click += new System.EventHandler(this.MenuDeleteData_Click);
            // 
            // MenuEditData
            // 
            this.MenuEditData.Location = new System.Drawing.Point(696, 130);
            this.MenuEditData.Name = "MenuEditData";
            this.MenuEditData.Size = new System.Drawing.Size(100, 50);
            this.MenuEditData.TabIndex = 17;
            this.MenuEditData.Text = "Edit Menu";
            this.MenuEditData.UseSelectable = true;
            this.MenuEditData.Click += new System.EventHandler(this.MenuEditData_Click);
            // 
            // MenuInsertData
            // 
            this.MenuInsertData.Location = new System.Drawing.Point(696, 74);
            this.MenuInsertData.Name = "MenuInsertData";
            this.MenuInsertData.Size = new System.Drawing.Size(100, 50);
            this.MenuInsertData.TabIndex = 16;
            this.MenuInsertData.Text = "Tambah Menu";
            this.MenuInsertData.UseSelectable = true;
            this.MenuInsertData.Click += new System.EventHandler(this.MenuInsertData_Click);
            // 
            // MenuDataGrid
            // 
            this.MenuDataGrid.AllowUserToAddRows = false;
            this.MenuDataGrid.AllowUserToDeleteRows = false;
            this.MenuDataGrid.AllowUserToResizeRows = false;
            this.MenuDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MenuDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMenu,
            this.NamaMenu,
            this.JenisMenu,
            this.Harga,
            this.StatusMenu});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.MenuDataGrid.EnableHeadersVisualStyles = false;
            this.MenuDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MenuDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuDataGrid.Location = new System.Drawing.Point(23, 100);
            this.MenuDataGrid.Name = "MenuDataGrid";
            this.MenuDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MenuDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MenuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MenuDataGrid.Size = new System.Drawing.Size(649, 413);
            this.MenuDataGrid.TabIndex = 15;
            // 
            // IDMenu
            // 
            this.IDMenu.HeaderText = "ID";
            this.IDMenu.Name = "IDMenu";
            this.IDMenu.ReadOnly = true;
            // 
            // NamaMenu
            // 
            this.NamaMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamaMenu.HeaderText = "Nama Menu";
            this.NamaMenu.Name = "NamaMenu";
            this.NamaMenu.ReadOnly = true;
            // 
            // JenisMenu
            // 
            this.JenisMenu.HeaderText = "Jenis Menu";
            this.JenisMenu.Name = "JenisMenu";
            this.JenisMenu.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // StatusMenu
            // 
            this.StatusMenu.HeaderText = "Status Menu";
            this.StatusMenu.Name = "StatusMenu";
            this.StatusMenu.ReadOnly = true;
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 543);
            this.Controls.Add(this.MenuSearchTextBox);
            this.Controls.Add(this.MenuRefreshData);
            this.Controls.Add(this.MenuDeleteData);
            this.Controls.Add(this.MenuEditData);
            this.Controls.Add(this.MenuInsertData);
            this.Controls.Add(this.MenuDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuManager";
            this.Resizable = false;
            this.Text = "Manajemen Menu";
            this.Load += new System.EventHandler(this.MenuManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox MenuSearchTextBox;
        private MetroFramework.Controls.MetroButton MenuRefreshData;
        private MetroFramework.Controls.MetroButton MenuDeleteData;
        private MetroFramework.Controls.MetroButton MenuEditData;
        private MetroFramework.Controls.MetroButton MenuInsertData;
        private MetroFramework.Controls.MetroGrid MenuDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusMenu;
    }
}
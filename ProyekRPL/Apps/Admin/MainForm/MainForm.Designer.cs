namespace ProyekRPL.Apps.Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabCon = new MetroFramework.Controls.MetroTabControl();
            this.UserManagementTab = new MetroFramework.Controls.MetroTabPage();
            this.UserSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserRefreshData = new MetroFramework.Controls.MetroButton();
            this.UserDeleteData = new MetroFramework.Controls.MetroButton();
            this.UserEditData = new MetroFramework.Controls.MetroButton();
            this.UserInsertData = new MetroFramework.Controls.MetroButton();
            this.UserDataGrid = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuTab = new MetroFramework.Controls.MetroTabPage();
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
            this.TabCon.SuspendLayout();
            this.UserManagementTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.MenuTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCon
            // 
            this.TabCon.Controls.Add(this.UserManagementTab);
            this.TabCon.Controls.Add(this.MenuTab);
            this.TabCon.Location = new System.Drawing.Point(23, 63);
            this.TabCon.Name = "TabCon";
            this.TabCon.SelectedIndex = 1;
            this.TabCon.Size = new System.Drawing.Size(787, 499);
            this.TabCon.TabIndex = 0;
            this.TabCon.UseSelectable = true;
            // 
            // UserManagementTab
            // 
            this.UserManagementTab.Controls.Add(this.UserSearchTextBox);
            this.UserManagementTab.Controls.Add(this.UserRefreshData);
            this.UserManagementTab.Controls.Add(this.UserDeleteData);
            this.UserManagementTab.Controls.Add(this.UserEditData);
            this.UserManagementTab.Controls.Add(this.UserInsertData);
            this.UserManagementTab.Controls.Add(this.UserDataGrid);
            this.UserManagementTab.HorizontalScrollbarBarColor = true;
            this.UserManagementTab.HorizontalScrollbarHighlightOnWheel = false;
            this.UserManagementTab.HorizontalScrollbarSize = 10;
            this.UserManagementTab.Location = new System.Drawing.Point(4, 38);
            this.UserManagementTab.Name = "UserManagementTab";
            this.UserManagementTab.Size = new System.Drawing.Size(779, 457);
            this.UserManagementTab.TabIndex = 0;
            this.UserManagementTab.Text = "Managemen User";
            this.UserManagementTab.VerticalScrollbarBarColor = true;
            this.UserManagementTab.VerticalScrollbarHighlightOnWheel = false;
            this.UserManagementTab.VerticalScrollbarSize = 10;
            // 
            // UserSearchTextBox
            // 
            this.UserSearchTextBox.CustomButton.Image = null;
            this.UserSearchTextBox.CustomButton.Location = new System.Drawing.Point(627, 1);
            this.UserSearchTextBox.CustomButton.Name = "";
            this.UserSearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserSearchTextBox.CustomButton.TabIndex = 1;
            this.UserSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserSearchTextBox.CustomButton.UseSelectable = true;
            this.UserSearchTextBox.CustomButton.Visible = false;
            this.UserSearchTextBox.Lines = new string[0];
            this.UserSearchTextBox.Location = new System.Drawing.Point(3, 12);
            this.UserSearchTextBox.MaxLength = 32767;
            this.UserSearchTextBox.Name = "UserSearchTextBox";
            this.UserSearchTextBox.PasswordChar = '\0';
            this.UserSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserSearchTextBox.SelectedText = "";
            this.UserSearchTextBox.SelectionLength = 0;
            this.UserSearchTextBox.SelectionStart = 0;
            this.UserSearchTextBox.ShortcutsEnabled = true;
            this.UserSearchTextBox.Size = new System.Drawing.Size(649, 23);
            this.UserSearchTextBox.TabIndex = 8;
            this.UserSearchTextBox.UseSelectable = true;
            this.UserSearchTextBox.WaterMark = "Cari di sini";
            this.UserSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UserRefreshData
            // 
            this.UserRefreshData.Location = new System.Drawing.Point(676, 183);
            this.UserRefreshData.Name = "UserRefreshData";
            this.UserRefreshData.Size = new System.Drawing.Size(100, 50);
            this.UserRefreshData.TabIndex = 7;
            this.UserRefreshData.Text = "Refresh User";
            this.UserRefreshData.UseSelectable = true;
            this.UserRefreshData.Click += new System.EventHandler(this.UserRefreshData_Click);
            // 
            // UserDeleteData
            // 
            this.UserDeleteData.Location = new System.Drawing.Point(676, 127);
            this.UserDeleteData.Name = "UserDeleteData";
            this.UserDeleteData.Size = new System.Drawing.Size(100, 50);
            this.UserDeleteData.TabIndex = 6;
            this.UserDeleteData.Text = "Hapus User";
            this.UserDeleteData.UseSelectable = true;
            this.UserDeleteData.Click += new System.EventHandler(this.UserDeleteData_Click);
            // 
            // UserEditData
            // 
            this.UserEditData.Location = new System.Drawing.Point(676, 71);
            this.UserEditData.Name = "UserEditData";
            this.UserEditData.Size = new System.Drawing.Size(100, 50);
            this.UserEditData.TabIndex = 5;
            this.UserEditData.Text = "Edit User";
            this.UserEditData.UseSelectable = true;
            this.UserEditData.Click += new System.EventHandler(this.UserEditData_Click);
            // 
            // UserInsertData
            // 
            this.UserInsertData.Location = new System.Drawing.Point(676, 15);
            this.UserInsertData.Name = "UserInsertData";
            this.UserInsertData.Size = new System.Drawing.Size(100, 50);
            this.UserInsertData.TabIndex = 4;
            this.UserInsertData.Text = "Tambah User";
            this.UserInsertData.UseSelectable = true;
            this.UserInsertData.Click += new System.EventHandler(this.UserInsertData_Click);
            // 
            // UserDataGrid
            // 
            this.UserDataGrid.AllowUserToAddRows = false;
            this.UserDataGrid.AllowUserToDeleteRows = false;
            this.UserDataGrid.AllowUserToResizeRows = false;
            this.UserDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Fullname,
            this.Role});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.UserDataGrid.EnableHeadersVisualStyles = false;
            this.UserDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDataGrid.Location = new System.Drawing.Point(3, 41);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.UserDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGrid.Size = new System.Drawing.Size(649, 413);
            this.UserDataGrid.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fullname.HeaderText = "Nama";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            this.Fullname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // MenuTab
            // 
            this.MenuTab.Controls.Add(this.MenuSearchTextBox);
            this.MenuTab.Controls.Add(this.MenuRefreshData);
            this.MenuTab.Controls.Add(this.MenuDeleteData);
            this.MenuTab.Controls.Add(this.MenuEditData);
            this.MenuTab.Controls.Add(this.MenuInsertData);
            this.MenuTab.Controls.Add(this.MenuDataGrid);
            this.MenuTab.HorizontalScrollbarBarColor = true;
            this.MenuTab.HorizontalScrollbarHighlightOnWheel = false;
            this.MenuTab.HorizontalScrollbarSize = 10;
            this.MenuTab.Location = new System.Drawing.Point(4, 38);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Size = new System.Drawing.Size(779, 457);
            this.MenuTab.TabIndex = 1;
            this.MenuTab.Text = "Manajemen Menu";
            this.MenuTab.VerticalScrollbarBarColor = true;
            this.MenuTab.VerticalScrollbarHighlightOnWheel = false;
            this.MenuTab.VerticalScrollbarSize = 10;
            // 
            // MenuSearchTextBox
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
            this.MenuSearchTextBox.Location = new System.Drawing.Point(3, 13);
            this.MenuSearchTextBox.MaxLength = 32767;
            this.MenuSearchTextBox.Name = "MenuSearchTextBox";
            this.MenuSearchTextBox.PasswordChar = '\0';
            this.MenuSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MenuSearchTextBox.SelectedText = "";
            this.MenuSearchTextBox.SelectionLength = 0;
            this.MenuSearchTextBox.SelectionStart = 0;
            this.MenuSearchTextBox.ShortcutsEnabled = true;
            this.MenuSearchTextBox.Size = new System.Drawing.Size(649, 23);
            this.MenuSearchTextBox.TabIndex = 14;
            this.MenuSearchTextBox.UseSelectable = true;
            this.MenuSearchTextBox.WaterMark = "Cari di sini";
            this.MenuSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MenuSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MenuSearchTextBox.KeyDown += MenuSearchTextBox_KeyDown;
            // 
            // MenuRefreshData
            // 
            this.MenuRefreshData.Location = new System.Drawing.Point(676, 184);
            this.MenuRefreshData.Name = "MenuRefreshData";
            this.MenuRefreshData.Size = new System.Drawing.Size(100, 50);
            this.MenuRefreshData.TabIndex = 13;
            this.MenuRefreshData.Text = "Refresh Menu";
            this.MenuRefreshData.UseSelectable = true;
            this.MenuRefreshData.Click += new System.EventHandler(this.MenuRefreshData_Click);
            // 
            // MenuDeleteData
            // 
            this.MenuDeleteData.Location = new System.Drawing.Point(676, 128);
            this.MenuDeleteData.Name = "MenuDeleteData";
            this.MenuDeleteData.Size = new System.Drawing.Size(100, 50);
            this.MenuDeleteData.TabIndex = 12;
            this.MenuDeleteData.Text = "Hapus Menu";
            this.MenuDeleteData.UseSelectable = true;
            this.MenuDeleteData.Click += new System.EventHandler(this.MenuDeleteData_Click);
            // 
            // MenuEditData
            // 
            this.MenuEditData.Location = new System.Drawing.Point(676, 72);
            this.MenuEditData.Name = "MenuEditData";
            this.MenuEditData.Size = new System.Drawing.Size(100, 50);
            this.MenuEditData.TabIndex = 11;
            this.MenuEditData.Text = "Edit Menu";
            this.MenuEditData.UseSelectable = true;
            this.MenuEditData.Click += new System.EventHandler(this.MenuEditData_Click);
            // 
            // MenuInsertData
            // 
            this.MenuInsertData.Location = new System.Drawing.Point(676, 16);
            this.MenuInsertData.Name = "MenuInsertData";
            this.MenuInsertData.Size = new System.Drawing.Size(100, 50);
            this.MenuInsertData.TabIndex = 10;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MenuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMenu,
            this.NamaMenu,
            this.JenisMenu,
            this.Harga,
            this.StatusMenu});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MenuDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.MenuDataGrid.EnableHeadersVisualStyles = false;
            this.MenuDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MenuDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MenuDataGrid.Location = new System.Drawing.Point(3, 42);
            this.MenuDataGrid.Name = "MenuDataGrid";
            this.MenuDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MenuDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.MenuDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MenuDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MenuDataGrid.Size = new System.Drawing.Size(649, 413);
            this.MenuDataGrid.TabIndex = 9;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 585);
            this.Controls.Add(this.TabCon);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Halaman Admin";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.TabCon.ResumeLayout(false);
            this.UserManagementTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.MenuTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabCon;
        private MetroFramework.Controls.MetroTabPage UserManagementTab;
        private MetroFramework.Controls.MetroGrid UserDataGrid;
        private MetroFramework.Controls.MetroButton UserInsertData;
        private MetroFramework.Controls.MetroButton UserDeleteData;
        private MetroFramework.Controls.MetroButton UserEditData;
        private MetroFramework.Controls.MetroButton UserRefreshData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private MetroFramework.Controls.MetroTextBox UserSearchTextBox;
        private MetroFramework.Controls.MetroTabPage MenuTab;
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
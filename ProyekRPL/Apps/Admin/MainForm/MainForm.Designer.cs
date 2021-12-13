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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TabCon.SuspendLayout();
            this.UserManagementTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
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
            // 
            // 
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
            this.UserSearchTextBox.PromptText = "Cari di sini";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Fullname,
            this.Role});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserDataGrid.EnableHeadersVisualStyles = false;
            this.UserDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDataGrid.Location = new System.Drawing.Point(3, 41);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
    }
}
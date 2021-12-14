namespace ProyekRPL.Apps.Admin
{
    partial class UserManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.UserSearchTextBox.Location = new System.Drawing.Point(23, 72);
            this.UserSearchTextBox.MaxLength = 32767;
            this.UserSearchTextBox.Name = "UserSearchTextBox";
            this.UserSearchTextBox.PasswordChar = '\0';
            this.UserSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserSearchTextBox.SelectedText = "";
            this.UserSearchTextBox.SelectionLength = 0;
            this.UserSearchTextBox.SelectionStart = 0;
            this.UserSearchTextBox.ShortcutsEnabled = true;
            this.UserSearchTextBox.Size = new System.Drawing.Size(649, 23);
            this.UserSearchTextBox.TabIndex = 14;
            this.UserSearchTextBox.UseSelectable = true;
            this.UserSearchTextBox.WaterMark = "Cari di sini";
            this.UserSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UserSearchTextBox.KeyDown += UserSearchTextBox_KeyDown;
            // 
            // UserRefreshData
            // 
            this.UserRefreshData.Location = new System.Drawing.Point(696, 243);
            this.UserRefreshData.Name = "UserRefreshData";
            this.UserRefreshData.Size = new System.Drawing.Size(100, 50);
            this.UserRefreshData.TabIndex = 13;
            this.UserRefreshData.Text = "Refresh User";
            this.UserRefreshData.UseSelectable = true;
            this.UserRefreshData.Click += new System.EventHandler(this.UserRefreshData_Click);
            // 
            // UserDeleteData
            // 
            this.UserDeleteData.Location = new System.Drawing.Point(696, 187);
            this.UserDeleteData.Name = "UserDeleteData";
            this.UserDeleteData.Size = new System.Drawing.Size(100, 50);
            this.UserDeleteData.TabIndex = 12;
            this.UserDeleteData.Text = "Hapus User";
            this.UserDeleteData.UseSelectable = true;
            this.UserDeleteData.Click += new System.EventHandler(this.UserDeleteData_Click);
            // 
            // UserEditData
            // 
            this.UserEditData.Location = new System.Drawing.Point(696, 131);
            this.UserEditData.Name = "UserEditData";
            this.UserEditData.Size = new System.Drawing.Size(100, 50);
            this.UserEditData.TabIndex = 11;
            this.UserEditData.Text = "Edit User";
            this.UserEditData.UseSelectable = true;
            this.UserEditData.Click += new System.EventHandler(this.UserEditData_Click);
            // 
            // UserInsertData
            // 
            this.UserInsertData.Location = new System.Drawing.Point(696, 75);
            this.UserInsertData.Name = "UserInsertData";
            this.UserInsertData.Size = new System.Drawing.Size(100, 50);
            this.UserInsertData.TabIndex = 10;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.UserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Fullname,
            this.Role});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.UserDataGrid.EnableHeadersVisualStyles = false;
            this.UserDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDataGrid.Location = new System.Drawing.Point(23, 101);
            this.UserDataGrid.Name = "UserDataGrid";
            this.UserDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.UserDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGrid.Size = new System.Drawing.Size(649, 413);
            this.UserDataGrid.TabIndex = 9;
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
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 542);
            this.Controls.Add(this.UserSearchTextBox);
            this.Controls.Add(this.UserRefreshData);
            this.Controls.Add(this.UserDeleteData);
            this.Controls.Add(this.UserEditData);
            this.Controls.Add(this.UserInsertData);
            this.Controls.Add(this.UserDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManager";
            this.Resizable = false;
            this.Text = "Manajemen User";
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UserSearchTextBox;
        private MetroFramework.Controls.MetroButton UserRefreshData;
        private MetroFramework.Controls.MetroButton UserDeleteData;
        private MetroFramework.Controls.MetroButton UserEditData;
        private MetroFramework.Controls.MetroButton UserInsertData;
        private MetroFramework.Controls.MetroGrid UserDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}
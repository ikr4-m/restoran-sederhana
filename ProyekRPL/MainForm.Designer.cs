namespace ProyekRPL
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserFullnameBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LevelUserBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimeEvt = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kokiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cetakTotalTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cetakRingkasanLaporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LoginStatusBar,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.UserFullnameBar,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.LevelUserBar,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.DateTimeBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Login Status:";
            // 
            // LoginStatusBar
            // 
            this.LoginStatusBar.Name = "LoginStatusBar";
            this.LoginStatusBar.Size = new System.Drawing.Size(35, 17);
            this.LoginStatusBar.Text = "Tidak";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "  |  ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel3.Text = "Nama User:";
            // 
            // UserFullnameBar
            // 
            this.UserFullnameBar.Name = "UserFullnameBar";
            this.UserFullnameBar.Size = new System.Drawing.Size(74, 17);
            this.UserFullnameBar.Text = "Belum Login";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel4.Text = "  |  ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel5.Text = "Level User:";
            // 
            // LevelUserBar
            // 
            this.LevelUserBar.Name = "LevelUserBar";
            this.LevelUserBar.Size = new System.Drawing.Size(57, 17);
            this.LevelUserBar.Text = "UserLevel";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel6.Text = "  |  ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel7.Text = "Tanggal/Jam:";
            // 
            // DateTimeBar
            // 
            this.DateTimeBar.Name = "DateTimeBar";
            this.DateTimeBar.Size = new System.Drawing.Size(65, 17);
            this.DateTimeBar.Text = "DATE_TIME";
            // 
            // DateTimeEvt
            // 
            this.DateTimeEvt.Enabled = true;
            this.DateTimeEvt.Interval = 1000;
            this.DateTimeEvt.Tick += new System.EventHandler(this.DateTimeEvt_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.kasirToolStripMenuItem,
            this.waiterToolStripMenuItem,
            this.kokiToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripSeparator1,
            this.keluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manajemenUserToolStripMenuItem,
            this.manajemenMenuToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Visible = false;
            // 
            // manajemenUserToolStripMenuItem
            // 
            this.manajemenUserToolStripMenuItem.Name = "manajemenUserToolStripMenuItem";
            this.manajemenUserToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.manajemenUserToolStripMenuItem.Text = "Manajemen User";
            this.manajemenUserToolStripMenuItem.Click += new System.EventHandler(this.manajemenUserToolStripMenuItem_Click);
            // 
            // manajemenMenuToolStripMenuItem
            // 
            this.manajemenMenuToolStripMenuItem.Name = "manajemenMenuToolStripMenuItem";
            this.manajemenMenuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.manajemenMenuToolStripMenuItem.Text = "Manajemen Menu";
            this.manajemenMenuToolStripMenuItem.Click += new System.EventHandler(this.manajemenMenuToolStripMenuItem_Click);
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kasirToolStripMenuItem.Text = "Kasir";
            this.kasirToolStripMenuItem.Visible = false;
            this.kasirToolStripMenuItem.Click += new System.EventHandler(this.kasirToolStripMenuItem_Click);
            // 
            // waiterToolStripMenuItem
            // 
            this.waiterToolStripMenuItem.Name = "waiterToolStripMenuItem";
            this.waiterToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.waiterToolStripMenuItem.Text = "Waiter";
            this.waiterToolStripMenuItem.Visible = false;
            // 
            // kokiToolStripMenuItem
            // 
            this.kokiToolStripMenuItem.Name = "kokiToolStripMenuItem";
            this.kokiToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.kokiToolStripMenuItem.Text = "Koki";
            this.kokiToolStripMenuItem.Visible = false;
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatTransaksiToolStripMenuItem,
            this.toolStripSeparator2,
            this.cetakTotalTransaksiToolStripMenuItem,
            this.cetakRingkasanLaporanToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            this.laporanToolStripMenuItem.Visible = false;
            // 
            // riwayatTransaksiToolStripMenuItem
            // 
            this.riwayatTransaksiToolStripMenuItem.Name = "riwayatTransaksiToolStripMenuItem";
            this.riwayatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.riwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // cetakTotalTransaksiToolStripMenuItem
            // 
            this.cetakTotalTransaksiToolStripMenuItem.Name = "cetakTotalTransaksiToolStripMenuItem";
            this.cetakTotalTransaksiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cetakTotalTransaksiToolStripMenuItem.Text = "Cetak Total Transaksi";
            // 
            // cetakRingkasanLaporanToolStripMenuItem
            // 
            this.cetakRingkasanLaporanToolStripMenuItem.Name = "cetakRingkasanLaporanToolStripMenuItem";
            this.cetakRingkasanLaporanToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cetakRingkasanLaporanToolStripMenuItem.Text = "Cetak Ringkasan Laporan";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ProyekRPL.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LoginStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel UserFullnameBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel LevelUserBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel DateTimeBar;
        private System.Windows.Forms.Timer DateTimeEvt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kokiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cetakTotalTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cetakRingkasanLaporanToolStripMenuItem;
    }
}
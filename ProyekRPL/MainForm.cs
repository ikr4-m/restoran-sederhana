using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyekRPL.Module;

namespace ProyekRPL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeStatusBar()
        {
            if (GlobalState.LoginState == false)
            {
                LoginStatusBar.Text = "Tidak";
                UserFullnameBar.Text = "Belum Login";
                LevelUserBar.Text = Enum.GetName(typeof(GlobalState.UserRole), 0);

                // Tutup tab
                adminToolStripMenuItem.Visible = false;
                kasirToolStripMenuItem.Visible = false;
                trackerToolStripMenuItem.Visible = false;
                laporanToolStripMenuItem.Visible = false;
            }
            else
            {
                LoginStatusBar.Text = "Ya";
                UserFullnameBar.Text = GlobalState.ThatUserLogin.Name;
                LevelUserBar.Text = Enum.GetName(typeof(GlobalState.UserRole), GlobalState.ThatUserLogin.Role);

                // Buka tab
                switch (GlobalState.ThatUserLogin.Role)
                {
                    case GlobalState.UserRole.Admin:
                        adminToolStripMenuItem.Visible = true;
                        kasirToolStripMenuItem.Visible = true;
                        laporanToolStripMenuItem.Visible = true;
                        trackerToolStripMenuItem.Visible = true;
                        break;
                    case GlobalState.UserRole.Kasir:
                        kasirToolStripMenuItem.Visible = true;
                        laporanToolStripMenuItem.Visible = true;
                        break;
                    case GlobalState.UserRole.Koki:
                    case GlobalState.UserRole.Waiter:
                        trackerToolStripMenuItem.Visible = true;
                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Panggil form loading
            LoadingScreen loadingScreen = new LoadingScreen();
            loadingScreen.Show();

            // Panggil config file
            loadingScreen.ScreenLoadingText = "Memuat konfigurasi";
            Initial.ConfigFile();
            Task.Delay(500).Wait();

            // Open Connection ke Database
            loadingScreen.ScreenLoadingText = "Memanggil koneksi ke database";
            Initial.ConfigDatabase();
            Task.Delay(500).Wait();

            // Ganti nama aplikasi
            this.Text = "Aplikasi Managemen " + (new IniFile("ApplicationConfig.ini")).Read("RestaurantName", "General");
            this.ChangeStatusBar();

            // Tutup Loading Screen
            loadingScreen.Close();
        }

        private void DateTimeEvt_Tick(object sender, EventArgs e)
        {
            DateTimeBar.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalState.LoginState == false)
            {
                // Tunggu hingga login form tertutup
                using (var form = new Apps.LoginForm()) form.ShowDialog();

                if (GlobalState.LoginState == true)
                {
                    loginToolStripMenuItem.Text = "Logout";
                    this.ChangeStatusBar();
                }
            }
            else
            {
                LoginState.Reset();
                this.ChangeStatusBar();
                loginToolStripMenuItem.Text = "Login";
            }
        }

        private void manajemenUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Apps.Admin.UserManager()) form.ShowDialog();
        }

        private void manajemenMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Apps.Admin.MenuManager()) form.ShowDialog();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Apps.Cashier.MainForm()) form.ShowDialog();
        }

        private void riwayatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Apps.Report.Invoice.InvoiceList()) form.ShowDialog();
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new Apps.Tracing.Tracer()) form.ShowDialog();
        }
    }
}

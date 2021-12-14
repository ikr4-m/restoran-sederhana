﻿using System;
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
            }
            else
            {
                LoginStatusBar.Text = "Ya";
                UserFullnameBar.Text = GlobalState.ThatUserLogin.Name;
                LevelUserBar.Text = Enum.GetName(typeof(GlobalState.UserRole), GlobalState.ThatUserLogin.Role);
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
                using (var form = new LoginForm()) form.ShowDialog();

                this.ChangeStatusBar();
                loginToolStripMenuItem.Text = "Logout";
            }
            else
            {
                LoginState.Reset();
                this.ChangeStatusBar();
                loginToolStripMenuItem.Text = "Login";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MetroFramework.Forms;
using ProyekRPL.Module;
using MySql.Data.MySqlClient;

namespace ProyekRPL
{
    public partial class LoginForm : MetroForm
    {
        private int _countMD5 = 1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserLevel.SelectedIndex = 0;

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

            // Tutup Loading Screen
            loadingScreen.Close();
        }

        private void UsernameClearBtn_Click(object sender, EventArgs e)
        {
            UsernameTxt.Text = "";
            UsernameTxt.Focus();
        }

        private void PasswordClearBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt.Text = "";
            PasswordTxt.Focus();
        }

        private void PasswordLogo_Click(object sender, EventArgs e)
        {
            if (_countMD5 == 10)
            {
                (new MD5Generator()).Show();
                _countMD5 = 1;
            }
            else
                _countMD5++;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM user WHERE username='{0}' AND password='{1}' AND role='{2}'",
                UsernameTxt.Text, MD5Factory.Generate(PasswordTxt.Text), UserLevel.Text);

            var data = SQL.QueryExecutor(query);

            if (data.Length > 0)
            {
                MessageBox.Show("Anda telah login atas nama " + data[0][3]);
            }
            else
            {
                MessageBox.Show("Username atau password anda salah!");
            }
        }
    }
}

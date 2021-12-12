using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyekRPL
{
    class Initial
    {
        public static void ConfigFile()
        {
            Initialize.ConfigFile configFile = new Initialize.ConfigFile();
            if (!configFile.IsConfigAvailable)
            {
                MessageBox.Show("Konfigurasi awal telah dimasukkan dalam sistem, aplikasi akan keluar.");
                Environment.Exit(0);
            }
        }

        public static void ConfigDatabase()
        {
            try
            {
                new Module.SQL();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    string.Format("Terjadi kesalahan dengan server:\n{0}\nPeriksa koneksi dan konfigurasi database kembali. Aplikasi dihentikan.", ex.Message),
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}

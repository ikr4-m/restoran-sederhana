using System;
using System.Windows.Forms;
using MySqlConnector;

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

        public static void SQLConnection()
        {
            try
            {
                new Module.SQL();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    string.Format("Terjadi error dengan database:\n{0}\n\nAplikasi dikeluarkan.",
                        ex.Message),
                    "Error Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}

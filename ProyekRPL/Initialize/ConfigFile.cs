using System;
using System.Windows.Forms;
using System.IO;

namespace ProyekRPL.Initialize
{
    class ConfigFile
    {
        private string[] _configFile =
        {
            "DatabaseConfig.ini"
        };

        public ConfigFile(bool init = true)
        {
            bool configAvailable = true;

            foreach (string file in _configFile)
            {
                if (!File.Exists(file))
                {
                    configAvailable = false;
                }
            }

            if (!configAvailable)
            {
                InsertConfigFile();
                if (init)
                {
                    // Exit code
                    MessageBox.Show("Konfigurasi awal telah dimasukkan dalam sistem, aplikasi akan keluar.");
                    Environment.Exit(0);
                }
            }
        }

        public void InsertConfigFile()
        {
            ConfigDatabaseConfig();
        }

        private void ConfigDatabaseConfig()
        {
            Module.IniFile ini = new Module.IniFile(_configFile[0]);
            ini.Write("Hostname", "localhost", "SQL");
            ini.Write("Username", "root", "SQL");
            ini.Write("Password", "", "SQL");
            ini.Write("Database", "mydatabase", "SQL");
        }
    }
}

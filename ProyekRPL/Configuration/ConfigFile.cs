using System;
using System.Windows.Forms;
using System.IO;

namespace ProyekRPL.Initialize
{
    class ConfigFile
    {
        private string[] _configFile =
        {
            "DatabaseConfig.ini",
            "ApplicationConfig.ini"
        };

        public bool IsConfigAvailable = true;

        public ConfigFile()
        {
            foreach (string file in _configFile)
            {
                if (!File.Exists(file)) IsConfigAvailable = false;
            }

            if (!IsConfigAvailable) InsertConfigFile();
        }

        public void InsertConfigFile()
        {
            ConfigDatabaseConfig();
            ConfigApplication();
        }

        private void ConfigDatabaseConfig()
        {
            Module.IniFile ini = new Module.IniFile(_configFile[0]);
            ini.Write("Hostname", "localhost", "SQL");
            ini.Write("Username", "root", "SQL");
            ini.Write("Password", "", "SQL");
            ini.Write("Database", "mydatabase", "SQL");
        }

        private void ConfigApplication()
        {
            Module.IniFile ini = new Module.IniFile(_configFile[1]);
            ini.Write("RestaurantName", "Restoran Mundur Terus", "General");
            ini.Write("Address", "Jl. Mana Aja Boleh", "General");
            ini.Write("PhoneNumber", "0411-454454454", "General");
        }
    }
}

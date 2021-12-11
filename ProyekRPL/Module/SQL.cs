using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace ProyekRPL.Module
{
    class SQL
    {
        public MySqlConnection Connection;

        public SQL()
        {
            IniFile iniFile = new IniFile("DatabaseConfig.ini");
            string conn = string.Format(
                "Server={0};User ID={1};Password={2};Database={3}",
                iniFile.Read("Hostname", "SQL"),
                iniFile.Read("Username", "SQL"),
                iniFile.Read("Password", "SQL"),
                iniFile.Read("Database", "SQL"));

            using (Connection = new MySqlConnection(conn))
            {
                Connection.Open();
            }
        }
    }
}

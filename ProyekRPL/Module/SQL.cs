using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace ProyekRPL.Module
{
    class SQL
    {
        public static MySqlConnection Connection { get; set; }

        public SQL()
        {
            Connection = new MySqlConnection(GenerateStringConnection());
            Connection.Open();
            Connection.Close();
        }

        public static string GenerateStringConnection()
        {
            IniFile iniFile = new IniFile("DatabaseConfig.ini");
            return string.Format(
                "Server={0};User ID={1};Password={2};Database={3}",
                iniFile.Read("Hostname", "SQL"),
                iniFile.Read("Username", "SQL"),
                iniFile.Read("Password", "SQL"),
                iniFile.Read("Database", "SQL"));
        }

        public static string[][] QueryExecutor(string query)
        {
            Connection.Open();

            List<string[]> list = new List<string[]>();
            MySqlCommand cmd = new MySqlCommand(query, Connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            string[] data = new string[reader.FieldCount];
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++) data[i] = reader.GetString(i);
                list.Add(data);
            }

            Connection.Close();

            return list.ToArray();
        }
    }
}

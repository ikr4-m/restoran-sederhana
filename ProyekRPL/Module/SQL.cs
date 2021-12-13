using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
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

        public static string[][] GetDataQuery(string query)
        {
            Connection.Open();

            List<string[]> list = new List<string[]>();
            MySqlCommand cmd = new MySqlCommand(query, Connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    string[] data = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++) data[i] = reader.GetString(i);
                    list.Add(data);
                }

            Connection.Close();

            return list.ToArray();
        }

        public static bool PreparedStatementQuery(string query, string[][] args)
        {
            Connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, Connection);
            foreach (string[] arg in args)
                cmd.Parameters.AddWithValue(arg[0], arg[1]);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            return true;
        }

        public static void NonReturnQuery(string query)
        {
            Connection.Open();

            MySqlCommand command = new MySqlCommand(query, Connection);
            command.CommandText = query;

            command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}

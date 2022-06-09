using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ClassConnect
    {
        static public string Conline = "Database = library; DataSource = localhost; user = root; password = qwerty; charset = utf8";
        static public MySqlConnection connection;
        static public MySqlCommand command;
        static public MySqlDataAdapter adapter;

        static public void Connection()
        {
            connection = new MySqlConnection(Conline);
            connection.Open();
            command = new MySqlCommand();
            command.Connection = connection;
            adapter = new MySqlDataAdapter(command);
        }
    }
}

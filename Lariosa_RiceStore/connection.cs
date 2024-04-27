using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Lariosa_RiceStore
{

    public static class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=jobelle;database=bsit3c_edp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _245_Proj_Prototype
{
    internal class DatabaseConnection
    {
        public static MySqlConnection MakeConnection()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _245_Proj_Prototype.Models;
using _245_Proj_Prototype.DBUtils;

namespace _245_Proj_Prototype.DBUtils
{
    internal class DBHelper
    {
        public string connStr =
           "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";


        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }

        public DataTable LoadGeneralMedicalHistory(int patientID)
        {
            var result = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                const string query = "SELECT * FROM generalmedicalhistory WHERE patientid = @PatientID AND deleted = 0";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@PatientID", MySqlDbType.Int32).Value = patientID;
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(result);
                        return result;
                    }
                }
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ITS245_Project;

public static class Logger
{
    public static void Log(string form, string action, int? patientId = null, string details = null)
    {
        Db.Exec(
            @"INSERT INTO AppLog (Username, FormName, ActionName, PatientID, Details)
              VALUES (@u, @f, @a, @pid, @d)",
            new MySqlParameter("@u", Session.Username),
            new MySqlParameter("@f", form),
            new MySqlParameter("@a", action),
            new MySqlParameter("@pid", patientId.HasValue ? (object)patientId.Value : DBNull.Value),
            new MySqlParameter("@d", details != null ? (object)details : DBNull.Value)
        );
    }
}

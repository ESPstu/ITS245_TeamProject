using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

public static class Db
{
    private const string ConnStr =
        "server=127.0.0.1;database=medhist;uid=root;pwd=password;";

    public static DataTable GetTable(string sql, params MySqlParameter[] p)
    {
        using (var conn = new MySqlConnection(ConnStr))
        using (var cmd = new MySqlCommand(sql, conn))
        {
            if (p != null) cmd.Parameters.AddRange(p);

            using (var da = new MySqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    public static int Exec(string sql, params MySqlParameter[] p)
    {
        using (var conn = new MySqlConnection(ConnStr))
        using (var cmd = new MySqlCommand(sql, conn))
        {
            conn.Open();
            if (p != null) cmd.Parameters.AddRange(p);
            return cmd.ExecuteNonQuery();
        }
    }

    public static object Scalar(string sql, params MySqlParameter[] p)
    {
        using (var conn = new MySqlConnection(ConnStr))
        using (var cmd = new MySqlCommand(sql, conn))
        {
            conn.Open();
            if (p != null) cmd.Parameters.AddRange(p);
            return cmd.ExecuteScalar();
        }
    }
}
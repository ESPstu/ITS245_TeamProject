using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using _245_Proj_Prototype.Models;

namespace _245_Proj_Prototype.DBUtils
{
    internal class UserLogs
    {
        private static readonly string logFilePath = Path.Combine("Logs", "Logged_Users.txt");

        public static void LoggedUser(string username)
        {
            //Ensures user is logged in first
            if (SessionManager.CurrentUserID == 0)
            {
                return;
            }

            //ensure directory exists
            string logDirectory = Path.GetDirectoryName(logFilePath);
         //   string directoryPath = @"C:\\Users\trist\source\repos\245_Proj_Prototype";
            if (!string.IsNullOrEmpty(logDirectory) && !Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logMessage = $"User '{username}' logged in at {timestamp}.";

            try
            {
                //append log message to file
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);

            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during logging
                Console.WriteLine("Error logging user activity: " + ex.Message);
            }

           



        }



    }
}

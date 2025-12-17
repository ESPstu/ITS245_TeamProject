using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS245_Project
{
    public static class Session
    {
        public static int SelectedPatientID { get; set; } = 0;
        public static string SelectedPatientName { get; set; } = "";
        public static System.DateTime SelectedPatientDOB { get; set; } = System.DateTime.MinValue;

        public static string Username { get; set; } = "testuser";
    }
}

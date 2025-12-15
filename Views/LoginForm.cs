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


namespace _245_Proj_Prototype
{
    public partial class LoginForm : Form
    {

        private bool AuthenticateUser(string username, string password)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT LoginID FROM ehr.login_test" +
                        " WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();


                    if (result != null)
                    {
                        int loginID = Convert.ToInt32(result);
                        SessionManager.CurrentUserID = loginID;
                        SessionManager.CurrentUserName = username;

                        //log sucessful authentication
                        UserLogs.LoggedUser("User logged in successfully");
                        return true;
                    }
                    else
                    {
                        //authentication failed
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                    return false;
                }
            }
        }



        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_LoginEnter_Click(object sender, EventArgs e)
        {

            string username = tb_Login1.Text;
            string password = tb_Login2.Text;


            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Sucessful  ", "Credentials Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

             



            }





            Form f3 = new SelectPatient();
            f3.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

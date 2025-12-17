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

namespace ITS245_Project.Forms
{
    public partial class FrmSelectPatient : Form
    {
        public FrmSelectPatient()
        {
            InitializeComponent();
        }

        private void FrmSelectPatient_Load(object sender, EventArgs e)
        {
            rbLastName.Checked = true;
            LoadPatients();
        }
        private void LoadPatients()
        {
            string sql = @"
        SELECT PatientID, FirstName, LastName, Phone, DOB
        FROM PatientDemographics
        WHERE deleted = 0
        ORDER BY LastName, FirstName;";

            var dt = Db.GetTable(sql);
            dgvPatients.DataSource = dt;

            if (dgvPatients.Columns.Contains("PatientID"))
                dgvPatients.Columns["PatientID"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = txtSearch.Text.Trim();

            if (rbPatientId.Checked)
            {
                int pid;
                if (!int.TryParse(s, out pid))
                {
                    MessageBox.Show("Enter a valid Patient ID number.");
                    return;
                }

                string sql = @"
            SELECT PatientID, FirstName, LastName, Phone, DOB
            FROM PatientDemographics
            WHERE deleted = 0 AND PatientID = @pid
            ORDER BY LastName, FirstName;";

                dgvPatients.DataSource = Db.GetTable(sql, new MySql.Data.MySqlClient.MySqlParameter("@pid", pid));
            }
            else
            {
                string sql = @"
            SELECT PatientID, FirstName, LastName, Phone, DOB
            FROM PatientDemographics
            WHERE deleted = 0 AND LastName LIKE @ln
            ORDER BY LastName, FirstName;";

                dgvPatients.DataSource = Db.GetTable(sql, new MySql.Data.MySqlClient.MySqlParameter("@ln", s + "%"));
            }

            if (dgvPatients.Columns.Contains("PatientID"))
                dgvPatients.Columns["PatientID"].Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow == null)
            {
                MessageBox.Show("Select a patient from the list first.");
                return;
            }

            Session.SelectedPatientID = Convert.ToInt32(dgvPatients.CurrentRow.Cells["PatientID"].Value);
            Session.SelectedPatientName =
                dgvPatients.CurrentRow.Cells["FirstName"].Value.ToString() + " " +
                dgvPatients.CurrentRow.Cells["LastName"].Value.ToString();

            Session.SelectedPatientDOB = Convert.ToDateTime(dgvPatients.CurrentRow.Cells["DOB"].Value);

            MessageBox.Show("Selected: " + Session.SelectedPatientName);
        }

        private void btnOpenDemographics_Click(object sender, EventArgs e)
        {
            if (Session.SelectedPatientID == 0)
            {
                MessageBox.Show("Select a patient first, then click Select Patient.");
                return;
            }

            var f = new FrmDemographics();
            f.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            rbLastName.Checked = true;
            LoadPatients();
        }
    }
}

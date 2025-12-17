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
    public partial class FrmDemographics : Form
    {

        private enum Mode { View, Add, Edit }
        private Mode _mode = Mode.View;

        private int _currentPatientId = 0;

        public FrmDemographics()
        {
            InitializeComponent();
        }

        private void FrmDemographics_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.LightBlue;

            cboGender.Items.Clear();
            cboGender.Items.AddRange(new string[] { "Male", "Female", "Other" });

            if (Session.SelectedPatientID != 0)
            {
                LoadPatient(Session.SelectedPatientID);
            }
            else
            {
                lblPatientBanner.Text = "No patient selected";
                SetMode(Mode.View);
            }

            Logger.Log("Demographics", "OpenForm", Session.SelectedPatientID);
        }

        private void SetMode(Mode mode)
        {
            _mode = mode;

            bool hasPatient = (_currentPatientId != 0);
            bool editing = (mode == Mode.Add || mode == Mode.Edit);

            txtFirst.Enabled = editing;
            txtLast.Enabled = editing;
            txtPhone.Enabled = editing;
            txtEthnicity.Enabled = editing;
            txtEmail.Enabled = editing;
            dtpDob.Enabled = editing;
            cboGender.Enabled = editing;

            btnSave.Enabled = editing;
            btnUndo.Enabled = editing;

            btnAdd.Enabled = !editing;
            btnModify.Enabled = hasPatient && !editing;
            btnDelete.Enabled = hasPatient && !editing;
        }

        private void ClearInputs()
        {
            txtFirst.Clear();
            txtLast.Clear();
            txtPhone.Clear();
            txtEthnicity.Clear();
            txtEmail.Clear();
            cboGender.SelectedIndex = -1;
            dtpDob.Value = DateTime.Today;
        }

        private void LoadPatient(int patientId)
        {
            var dt = Db.GetTable(
                @"SELECT PatientID, FirstName, LastName, Phone, DOB, Gender, EthnicAssociation, Email
                  FROM PatientDemographics
                  WHERE PatientID=@id AND deleted=0",
                new MySqlParameter("@id", patientId)
            );

            if (dt.Rows.Count == 0)
                return;

            var r = dt.Rows[0];

            _currentPatientId = patientId;
            Session.SelectedPatientID = patientId;
            Session.SelectedPatientName = $"{r["LastName"]}, {r["FirstName"]}";

            txtFirst.Text = r["FirstName"].ToString();
            txtLast.Text = r["LastName"].ToString();
            txtPhone.Text = r["Phone"].ToString();
            txtEthnicity.Text = r["EthnicAssociation"].ToString();
            txtEmail.Text = r["Email"].ToString();
            cboGender.Text = r["Gender"].ToString();

            if (r["DOB"] != DBNull.Value)
                dtpDob.Value = Convert.ToDateTime(r["DOB"]);

            lblPatientBanner.Text = Session.SelectedPatientName;

            SetMode(Mode.View);
        }

        private void InsertPatient()
        {
            Db.Exec(
                @"INSERT INTO PatientDemographics
                  (FirstName, LastName, Phone, DOB, Gender, EthnicAssociation, Email, deleted)
                  VALUES
                  (@fn,@ln,@ph,@dob,@gen,@eth,@em,0)",
                new MySqlParameter("@fn", txtFirst.Text),
                new MySqlParameter("@ln", txtLast.Text),
                new MySqlParameter("@ph", txtPhone.Text),
                new MySqlParameter("@dob", dtpDob.Value),
                new MySqlParameter("@gen", cboGender.Text),
                new MySqlParameter("@eth", txtEthnicity.Text),
                new MySqlParameter("@em", txtEmail.Text)
            );

            _currentPatientId = Convert.ToInt32(Db.Scalar("SELECT LAST_INSERT_ID();"));
            Session.SelectedPatientID = _currentPatientId;
            Session.SelectedPatientName = $"{txtLast.Text}, {txtFirst.Text}";

            lblPatientBanner.Text = Session.SelectedPatientName;

            Logger.Log("Demographics", "AddPatient", _currentPatientId);
            SetMode(Mode.View);
        }

        private void UpdatePatient()
        {
            Db.Exec(
                @"UPDATE PatientDemographics
                  SET FirstName=@fn, LastName=@ln, Phone=@ph, DOB=@dob,
                      Gender=@gen, EthnicAssociation=@eth, Email=@em
                  WHERE PatientID=@id",
                new MySqlParameter("@fn", txtFirst.Text),
                new MySqlParameter("@ln", txtLast.Text),
                new MySqlParameter("@ph", txtPhone.Text),
                new MySqlParameter("@dob", dtpDob.Value),
                new MySqlParameter("@gen", cboGender.Text),
                new MySqlParameter("@eth", txtEthnicity.Text),
                new MySqlParameter("@em", txtEmail.Text),
                new MySqlParameter("@id", _currentPatientId)
            );

            Logger.Log("Demographics", "UpdatePatient", _currentPatientId);
            SetMode(Mode.View);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearInputs();
            _currentPatientId = 0;
            lblPatientBanner.Text = "Adding new patient";
            SetMode(Mode.Add);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (_currentPatientId == 0)
            {
                MessageBox.Show("Select a patient first.");
                return;
            }

            SetMode(Mode.Edit);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Add)
            {
                ClearInputs();
                SetMode(Mode.View);
            }
            else if (_mode == Mode.Edit)
            {
                LoadPatient(_currentPatientId);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text.Trim() == "" || txtLast.Text.Trim() == "")
            {
                MessageBox.Show("First and Last Name are required.");
                return;
            }

            if (_mode == Mode.Add)
                InsertPatient();
            else if (_mode == Mode.Edit)
                UpdatePatient();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentPatientId == 0)
                return;

            if (MessageBox.Show("Delete this patient?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Db.Exec(
                "UPDATE PatientDemographics SET deleted=1 WHERE PatientID=@id",
                new MySqlParameter("@id", _currentPatientId)
            );

            Logger.Log("Demographics", "DeletePatient", _currentPatientId);

            ClearInputs();
            _currentPatientId = 0;
            Session.SelectedPatientID = 0;
            lblPatientBanner.Text = "No patient selected";

            SetMode(Mode.View);
        }

        private void btnNavSelectPatient_Click(object sender, EventArgs e)
        {
            new FrmSelectPatient().Show();
            this.Close();
        }

        private void btnImunizations_Click(object sender, EventArgs e)
        {
            new FrmImmunizations().Show();
            this.Close();
        }

        private void btnNavFamilyHistory_Click(object sender, EventArgs e)
        {
            new FrmFamilyHistory().Show();
            this.Close();
        }
    }
}
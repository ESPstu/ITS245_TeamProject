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
    public partial class FrmImmunizations : Form
    {
        private enum Mode { View, Add, Edit }
        private Mode _mode = Mode.View;

        private int _currentImmId = 0;

        public FrmImmunizations()
        {
            InitializeComponent();
        }

        private void FrmImmunizations_Load(object sender, EventArgs e)
        {
            UpdateBanner();
            LoadImmunizations();
            SetMode(Mode.View);
            Logger.Log("Immunizations", "OpenForm", Session.SelectedPatientID);
        }

        private void UpdateBanner()
        {
            if (Session.SelectedPatientID == 0)
                lblPatientBanner.Text = "No patient selected";
            else
                lblPatientBanner.Text = $"Patient Selected: {Session.SelectedPatientName} (ID: {Session.SelectedPatientID})";
        }

        private void LoadImmunizations()
        {
            if (Session.SelectedPatientID == 0)
            {
                dgvImmunizations.DataSource = null;
                return;
            }

            string sql = @"
                SELECT ImmunizationID, ImmunizationName, ImmunizationDate, Notes
                FROM ImmunizationHistory
                WHERE PatientID=@pid AND deleted=0
                ORDER BY ImmunizationDate DESC, ImmunizationName;";

            dgvImmunizations.DataSource = Db.GetTable(sql,
                new MySqlParameter("@pid", Session.SelectedPatientID));

            if (dgvImmunizations.Columns.Contains("ImmunizationID"))
                dgvImmunizations.Columns["ImmunizationID"].Visible = false;
        }

        private void ClearInputs()
        {
            txtImmName.Text = "";
            txtNotes.Text = "";
            dtpImmDate.Checked = false;
            dtpImmDate.Value = DateTime.Today;
        }

        private void FillInputsFromGrid()
        {
            if (dgvImmunizations.CurrentRow == null) return;

            _currentImmId = Convert.ToInt32(dgvImmunizations.CurrentRow.Cells["ImmunizationID"].Value);
            txtImmName.Text = Convert.ToString(dgvImmunizations.CurrentRow.Cells["ImmunizationName"].Value);
            txtNotes.Text = Convert.ToString(dgvImmunizations.CurrentRow.Cells["Notes"].Value);

            object dateVal = dgvImmunizations.CurrentRow.Cells["ImmunizationDate"].Value;
            if (dateVal == DBNull.Value || dateVal == null)
            {
                dtpImmDate.Checked = false;
                dtpImmDate.Value = DateTime.Today;
            }
            else
            {
                dtpImmDate.Checked = true;
                dtpImmDate.Value = Convert.ToDateTime(dateVal);
            }
        }

        private void SetMode(Mode mode)
        {
            _mode = mode;

            bool hasPatient = Session.SelectedPatientID != 0;
            bool editing = (mode == Mode.Add || mode == Mode.Edit);

            grpInputs.Enabled = hasPatient && editing;
            btnSave.Enabled = hasPatient && editing;
            btnUndo.Enabled = hasPatient && editing;

            btnAdd.Enabled = hasPatient && !editing;
            btnModify.Enabled = hasPatient && !editing && dgvImmunizations.CurrentRow != null;
            btnDelete.Enabled = hasPatient && !editing && dgvImmunizations.CurrentRow != null;

            dgvImmunizations.Enabled = hasPatient && !editing;
        }

        private bool ValidateInputs()
        {
            if (Session.SelectedPatientID == 0)
            {
                MessageBox.Show("Select a patient first.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImmName.Text))
            {
                MessageBox.Show("Immunization Name is required.");
                txtImmName.Focus();
                return false;
            }
            return true;
        }

        private void dgvImmunizations_SelectionChanged(object sender, EventArgs e)
        {
            if (_mode != Mode.View) return;
            if (dgvImmunizations.CurrentRow == null) return;

            FillInputsFromGrid();
            SetMode(Mode.View);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _currentImmId = 0;
            ClearInputs();
            SetMode(Mode.Add);
            Logger.Log("Immunizations", "AddStart", Session.SelectedPatientID);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvImmunizations.CurrentRow == null) return;

            FillInputsFromGrid();
            SetMode(Mode.Edit);
            Logger.Log("Immunizations", "EditStart", Session.SelectedPatientID, $"ImmID={_currentImmId}");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (dgvImmunizations.CurrentRow != null)
                FillInputsFromGrid();
            else
                ClearInputs();

            SetMode(Mode.View);
            Logger.Log("Immunizations", "Undo", Session.SelectedPatientID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            object immDateParam = dtpImmDate.Checked ? (object)dtpImmDate.Value.Date : DBNull.Value;

            if (_mode == Mode.Add)
            {
                string sql = @"
                    INSERT INTO ImmunizationHistory (PatientID, ImmunizationName, ImmunizationDate, Notes)
                    VALUES (@pid, @name, @dt, @notes);";

                Db.Exec(sql,
                    new MySqlParameter("@pid", Session.SelectedPatientID),
                    new MySqlParameter("@name", txtImmName.Text.Trim()),
                    new MySqlParameter("@dt", immDateParam),
                    new MySqlParameter("@notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim())
                );

                Logger.Log("Immunizations", "AddSave", Session.SelectedPatientID, txtImmName.Text.Trim());
            }
            else if (_mode == Mode.Edit)
            {
                string sql = @"
                    UPDATE ImmunizationHistory
                    SET ImmunizationName=@name, ImmunizationDate=@dt, Notes=@notes
                    WHERE ImmunizationID=@id;";

                Db.Exec(sql,
                    new MySqlParameter("@name", txtImmName.Text.Trim()),
                    new MySqlParameter("@dt", immDateParam),
                    new MySqlParameter("@notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim()),
                    new MySqlParameter("@id", _currentImmId)
                );

                Logger.Log("Immunizations", "EditSave", Session.SelectedPatientID, $"ImmID={_currentImmId}");
            }

            LoadImmunizations();
            SetMode(Mode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvImmunizations.CurrentRow == null) return;

            FillInputsFromGrid();

            var ok = MessageBox.Show("Delete selected immunization?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ok != DialogResult.Yes) return;

            Db.Exec("UPDATE ImmunizationHistory SET deleted=1 WHERE ImmunizationID=@id;",
                new MySqlParameter("@id", _currentImmId));

            Logger.Log("Immunizations", "Delete", Session.SelectedPatientID, $"ImmID={_currentImmId}");

            _currentImmId = 0;
            ClearInputs();
            LoadImmunizations();
            SetMode(Mode.View);
        }

        private void btnNavSelectPatient_Click(object sender, EventArgs e)
        {
            new FrmSelectPatient().Show();
            this.Close();
        }

        private void btnNavDemographics_Click(object sender, EventArgs e)
        {
            new FrmDemographics().Show();
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITS245_Project;
using MySql.Data.MySqlClient;

namespace ITS245_Project.Forms
{
        public partial class FrmFamilyHistory : Form
        {
            private enum Mode { View, Add, Edit }
            private Mode _mode = Mode.View;

            private int _currentFamId = 0;

            public FrmFamilyHistory()
            {
                InitializeComponent();
                this.BackColor = System.Drawing.Color.LightBlue;
            }

            private void FrmFamilyHistory_Load(object sender, EventArgs e)
            {
                UpdateBanner();
                LoadFamilyHistory();
                SetMode(Mode.View);
                Logger.Log("FamilyHistory", "OpenForm", Session.SelectedPatientID);
            }

            private int AgeFromDob(DateTime dob)
            {
                var today = DateTime.Today;
                int age = today.Year - dob.Year;
                if (dob.Date > today.AddYears(-age)) age--;
                return age;
            }

            private void UpdateBanner()
            {
                if (Session.SelectedPatientID == 0)
                {
                    lblPatientBanner.Text = "No Patient Selected";
                    return;
                }
                lblPatientBanner.Text = $"{Session.SelectedPatientName}  |  Age: {AgeFromDob(Session.SelectedPatientDOB)}";
            }

            private void SetMode(Mode m)
            {
                _mode = m;
                bool editing = (m == Mode.Add || m == Mode.Edit);

                foreach (Control c in grpInputs.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Enabled = editing;
                        c.BackColor = editing ? System.Drawing.Color.White : System.Drawing.Color.LightGray;
                    }
                }

                btnAdd.Enabled = (m == Mode.View);
                btnModify.Enabled = (m == Mode.View);
                btnSave.Enabled = editing;
                btnUndo.Enabled = editing;
                btnDelete.Enabled = (m == Mode.View);
            }

            private void LoadFamilyHistory()
            {
                if (Session.SelectedPatientID == 0) return;

                var dt = Db.GetTable(@"
                SELECT FamilyHistoryID, Relationship, ConditionName, Notes
                FROM FamilyHistory
                WHERE PatientID=@pid AND deleted=0
                ORDER BY Relationship, ConditionName",
                    new MySqlParameter("@pid", Session.SelectedPatientID));

                dgvFamily.DataSource = dt;
                dgvFamily.Columns["FamilyHistoryID"].Visible = false;
            }

            private void dgvFamily_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvFamily.CurrentRow == null) return;

                _currentFamId = Convert.ToInt32(dgvFamily.CurrentRow.Cells["FamilyHistoryID"].Value);
                txtRelationship.Text = dgvFamily.CurrentRow.Cells["Relationship"].Value?.ToString() ?? "";
                txtCondition.Text = dgvFamily.CurrentRow.Cells["ConditionName"].Value?.ToString() ?? "";
                txtNotes.Text = dgvFamily.CurrentRow.Cells["Notes"].Value?.ToString() ?? "";
            }

            private void ClearInputs()
            {
                txtRelationship.Clear();
                txtCondition.Clear();
                txtNotes.Clear();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                if (Session.SelectedPatientID == 0) { MessageBox.Show("Select a patient first."); return; }

                ClearInputs();
                _currentFamId = 0;
                SetMode(Mode.Add);
                Logger.Log("FamilyHistory", "ClickAdd", Session.SelectedPatientID);
            }

            private void btnModify_Click(object sender, EventArgs e)
            {
                if (_currentFamId == 0) { MessageBox.Show("Select a family history record first."); return; }

                SetMode(Mode.Edit);
                Logger.Log("FamilyHistory", "ClickModify", Session.SelectedPatientID);
            }

            private void btnUndo_Click(object sender, EventArgs e)
            {
                ClearInputs();
                SetMode(Mode.View);
                Logger.Log("FamilyHistory", "Undo", Session.SelectedPatientID);
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                if (Session.SelectedPatientID == 0) return;

                if (string.IsNullOrWhiteSpace(txtRelationship.Text) || string.IsNullOrWhiteSpace(txtCondition.Text))
                {
                    MessageBox.Show("Relationship and Condition are required.");
                    return;
                }

                if (_mode == Mode.Add)
                {
                    Db.Exec(@"
                    INSERT INTO FamilyHistory (PatientID, Relationship, ConditionName, Notes)
                    VALUES (@pid,@rel,@cond,@notes)",
                        new MySqlParameter("@pid", Session.SelectedPatientID),
                        new MySqlParameter("@rel", txtRelationship.Text.Trim()),
                        new MySqlParameter("@cond", txtCondition.Text.Trim()),
                        new MySqlParameter("@notes", txtNotes.Text.Trim())
                    );

                    Logger.Log("FamilyHistory", "AddFamilyHistory", Session.SelectedPatientID,
                        $"{txtRelationship.Text.Trim()} - {txtCondition.Text.Trim()}");
                }
                else if (_mode == Mode.Edit)
                {
                    Db.Exec(@"
                    UPDATE FamilyHistory
                    SET Relationship=@rel, ConditionName=@cond, Notes=@notes
                    WHERE FamilyHistoryID=@id",
                        new MySqlParameter("@rel", txtRelationship.Text.Trim()),
                        new MySqlParameter("@cond", txtCondition.Text.Trim()),
                        new MySqlParameter("@notes", txtNotes.Text.Trim()),
                        new MySqlParameter("@id", _currentFamId)
                    );

                    Logger.Log("FamilyHistory", "ModifyFamilyHistory", Session.SelectedPatientID,
                        $"{txtRelationship.Text.Trim()} - {txtCondition.Text.Trim()}");
                }

                LoadFamilyHistory();   // refresh list (important)
                SetMode(Mode.View);
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (_currentFamId == 0) return;

                if (MessageBox.Show("Soft delete this family history record?", "Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                Db.Exec(@"UPDATE FamilyHistory SET deleted=1 WHERE FamilyHistoryID=@id",
                    new MySqlParameter("@id", _currentFamId));

                Logger.Log("FamilyHistory", "DeleteFamilyHistory", Session.SelectedPatientID);

                _currentFamId = 0;
                LoadFamilyHistory();
                SetMode(Mode.View);
            }

            private void btnNavDemographics_Click(object sender, EventArgs e)
            {
                new FrmDemographics().Show();
                this.Close();
            }

            private void btnNavImmunizations_Click(object sender, EventArgs e)
            {
                new FrmImmunizations().Show();
                this.Close();
            }

            private void btnNavSelectPatient_Click(object sender, EventArgs e)
            {
                new FrmSelectPatient().Show();
                this.Close();
            }
        }
    }
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
    public partial class GMH : Form
    {
        ///Form  or EhrForm3, is General Medical History (GMH) 

        int FormMode = 0;

        int currentPatientID;
        public GMH(int patientID)
        {
            InitializeComponent();
            this.currentPatientID = patientID;

            //start in view mode
            SetFormMode(0);
            LoadPatientHeader(patientID);
            LoadMedicalHistory();
            LoadComboBoxData();

            txt_deleted.ReadOnly = true; //always read-only
            

        }

        private void LoadPatientHeader(int patientID)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    // Get patient name and DOB (to calculate age)
                    string query = "SELECT PtFirstName, PtLastName, " +
                        "DOB FROM PatientDemographics WHERE PatientID = @pid";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pid", patientID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = $"{reader["FirstName"]} {reader["LastName"]}";
                        DateTime dob = (DateTime)reader["DOB"];
                        int age = DateTime.Today.Year - dob.Year;
                        if (dob.Date > DateTime.Today.AddYears(-age)) age--;

                        // Assuming you have a Label control named 'lblPatientHeader' on your form
                        lbl_PatientHeader.Text = $"Patient: {name}, Age: {age}";
                        lbl_PatientHeader.Visible = true ;
                       
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient header: " + ex.Message);
                }
            }
        }











        private void EhrForm3_Load(object sender, EventArgs e)
        {

        }

        private void lbl_patientName_Click(object sender, EventArgs e)
        {

        }

        private void SetFormMode(int mode)
        {
            FormMode = mode;

            //isReadOnly = is TRUE (locked) only when FormMode is 0 (view mode)
            bool isReadOnly = (FormMode == 0);

            //if in view mode, set panel backcolor to silver, else white
            Color panelBackColor = isReadOnly ? Color.Silver : Color.White;

            pnl_DataEntry.BackColor = panelBackColor;
            

            //set controls to read-only or editable based on mode
            btn_Add.Enabled = isReadOnly;
            btn_Modify.Enabled = isReadOnly;
            btn_Save.Enabled = !isReadOnly;
            btn_Undo.Enabled = !isReadOnly;

            //comboxes
            cmb_MaritalStatus.Enabled = !isReadOnly;
            cmb_Alcohol.Enabled = !isReadOnly;
            cmb_Rh.Enabled = !isReadOnly;
            cmb_Tobacco.Enabled = !isReadOnly;

            //textboxes
            txt_Education.ReadOnly = isReadOnly;
            txt_BehavioralHistory.ReadOnly = isReadOnly;
            txt_TobaccoQuantity.ReadOnly = isReadOnly;
            txt_TobaccoDuration.ReadOnly = isReadOnly;
            txt_AlcoholQuantity.ReadOnly = isReadOnly;
            txt_AlcoholDuration.ReadOnly = isReadOnly;
            txt_Drug.ReadOnly = isReadOnly;
            txt_DrugType.ReadOnly = isReadOnly;
            txt_DrugDuration.ReadOnly = isReadOnly;
            txt_Dietary.ReadOnly = isReadOnly;
            txt_BloodType.ReadOnly = isReadOnly;
            txt_NumberOfChildren.ReadOnly = isReadOnly;
            txt_LMPStatus.ReadOnly = isReadOnly;
            txt_MensesMonthlyYes.ReadOnly = isReadOnly;
            txt_MensesMonthlyNo.ReadOnly = isReadOnly;
            txt_MensesFreq.ReadOnly = isReadOnly;        
            txt_HxObtainedBy.ReadOnly = isReadOnly;
           
            //richtextbox
            rt_MedicalNotes.ReadOnly = isReadOnly;

        }


        private void LoadMedicalHistory()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM generalmedicalhistory" +
                        " WHERE PatientID = @pid AND deleted = 0";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@pid", currentPatientID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        //populate form controls with data from the first row
                        DataRow row = dt.Rows[0]; // int
                        
                        cmb_MaritalStatus.Text = row["MaritalStatus"].ToString();
                        txt_Education.Text = row["Education"].ToString();
                        txt_BehavioralHistory.Text = row["BehavioralHistory"].ToString();
                        cmb_Tobacco.Text = row["Tobacco"].ToString();
                        txt_TobaccoQuantity.Text = row["TobaccoQuantity"].ToString();
                        txt_TobaccoDuration.Text = row["TobaccoDuraton"].ToString();
                        cmb_Alcohol.Text = row["Alcohol"].ToString();
                        txt_AlcoholQuantity.Text = row["AlcoholQuantity"].ToString();
                        txt_AlcoholDuration.Text = row["AlcoholDuration"].ToString();
                        txt_Drug.Text = row["Drug"].ToString();
                        txt_DrugType.Text = row["DrugType"].ToString();
                        txt_DrugDuration.Text = row["DrugDuration"].ToString();
                        txt_Dietary.Text = row["Dietary"].ToString();
                        txt_BloodType.Text = row["BloodType"].ToString();
                        cmb_Rh.Text = row["Rh"].ToString();
                        txt_NumberOfChildren.Text = row["NumberOfChildren"].ToString(); //int
                        txt_LMPStatus.Text = row["LMPStatus"].ToString();
                        txt_MensesMonthlyYes.Text = row["MensesMonthlyYes"].ToString(); //int
                        txt_MensesMonthlyNo.Text = row["MensesMonthlyNo"].ToString(); //int
                        txt_MensesFreq.Text = row["MensesFreq"].ToString();
                        rt_MedicalNotes.Text = row["MedicalHistoryNotes"].ToString();
                        txt_HxObtainedBy.Text = row["HxObtainedBy"].ToString();
                        txt_deleted.Text = row["deleted"].ToString();
                        
                    }
                    else
                    {
                        //no records found, clear form controls
                        ClearFormControls();
                    }

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void LoadComboBoxData()
        {
            // --- Marital Status ---
            // Clear any previous items
            cmb_MaritalStatus.Items.Clear();

            // Add the standard list of options
            cmb_MaritalStatus.Items.Add("Single");
            cmb_MaritalStatus.Items.Add("Married");
            cmb_MaritalStatus.Items.Add("Divorced");
            cmb_MaritalStatus.Items.Add("Widowed");
            cmb_MaritalStatus.Items.Add("Separated");

            // Set to drop-down 
            cmb_MaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- Tobacco Status ---
            cmb_Tobacco.Items.Clear();
            cmb_Tobacco.Items.Add("Never Used");
            cmb_Tobacco.Items.Add("Current User");
            cmb_Tobacco.Items.Add("Former User");

            // Set to drop-down 
            cmb_Tobacco.DropDownStyle = ComboBoxStyle.DropDownList;

            // --- Alcohol Status ---
            cmb_Alcohol.Items.Clear();
            cmb_Alcohol.Items.Add("Never Drinks");
            cmb_Alcohol.Items.Add("Socially");
            cmb_Alcohol.Items.Add("Former User");
            cmb_Alcohol.Items.Add("Daily");

            cmb_Alcohol.DropDownStyle = ComboBoxStyle.DropDownList;


            // --- Rh Factor  ---
            cmb_Rh.Items.Clear();
            cmb_Rh.Items.Add("Positive");
            cmb_Rh.Items.Add("Negative");
            cmb_Rh.Items.Add("Unknown");
            cmb_Rh.Items.Add("Not Tested");

            //set to drop-down
            cmb_Rh.DropDownStyle = ComboBoxStyle.DropDownList;
        }




        private void ClearFormControls()
        {

            //Reset Textboxes
            txt_Education.Text = "";
            txt_BehavioralHistory.Text = "";
            txt_TobaccoQuantity.Text = "";
            txt_TobaccoDuration.Text = "";

            txt_AlcoholQuantity.Text = "";
            txt_AlcoholDuration.Text = "";
            txt_Drug.Text = "";
            txt_DrugType.Text = "";
            txt_DrugDuration.Text = "";
            txt_Dietary.Text = "";
            txt_BloodType.Text = "";

            txt_NumberOfChildren.Text = "";
            txt_LMPStatus.Text = "";
            txt_MensesMonthlyYes.Text = "";
            txt_MensesMonthlyNo.Text = ""; 
            txt_MensesFreq.Text = "";
            rt_MedicalNotes.Text = "";
            txt_HxObtainedBy.Text = "";
            txt_deleted.Text = "";



            // Reset Dropdowns
            cmb_MaritalStatus.Text = "";
            cmb_Tobacco.Text = "";
            cmb_Alcohol.Text = "";
            cmb_Rh.Text = "";

           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ClearFormControls();
            SetFormMode(1);

            // 1. Check if the patient already has an active medical history record.
            // This is vital to prevent creating duplicate records.
            // (This check assumes you run a query similar to LoadMedicalHistory() 
            // but only check if a record with Deleted = 0 exists for the currentPatientID).

            // For simplicity now, we assume this check is handled by LoadMedicalHistory() 
            // returning 0 rows if none exist. If LoadMedicalHistory() returns a row, 
            // you should use the Modify button, not Add.

            // 2. Clear the form to prepare for new entry


            // 3. Set the mode to Add (1). 
            // SetFormMode(1) will enable the entry fields and enable the Save/Undo buttons.


            private void 


        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (currentPatientID <= 0)
            {
                MessageBox.Show("Invalid Patient ID. Cannot save medical history.");
                return;
            }

            if (FormMode == 1) 
            {
                InsertMedicalHistory();
                // Insert new record logic here
                MessageBox.Show("Saving new medical history record...");
            }
            else if (FormMode == 2) // Modify mode
            {
                // Update existing record logic here
                UpdateMedicalHistory();
                MessageBox.Show("Updating existing medical history record...");
            }
            LoadMedicalHistory();
            SetFormMode(0); // Return to view mode after saving
        }

        private void InsertMedicalHistory()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO generalmedicalhistory " +
                        "(PatientID, MaritalStatus, Education, BehavioralHistory, Tobacco, " +
                        "TobaccoQuantity, TobaccoDuraton, Alcohol, AlcoholQuantity, AlcoholDuration, " +
                        "Drug, DrugType, DrugDuration, Dietary, BloodType, Rh, NumberOfChildren, " +
                        "LMPStatus, MensesMonthlyYes, MensesMonthlyNo, MensesFreq, MedicalHistoryNotes, HxObtainedBy, deleted) " +
                        "VALUES (@PatientID, @MaritalStatus, @Education, @BehavioralHistory, @Tobacco, " +
                        "@TobaccoQuantity, @TobaccoDuraton, @Alcohol, @AlcoholQuantity, @AlcoholDuration, " +
                        "@Drug, @DrugType, @DrugDuration, @Dietary, @BloodType, @Rh, @NumberOfChildren, " +
                        "@LMPStatus, @MensesMonthlyYes, @MensesMonthlyNo, @MensesFreq, @MedicalHistoryNotes, @HxObtainedBy, 0)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", currentPatientID);
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmb_MaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@Education", txt_Education.Text);
                    cmd.Parameters.AddWithValue("@BehavioralHistory", txt_BehavioralHistory.Text);
                    cmd.Parameters.AddWithValue("@Tobacco", cmb_Tobacco.Text);
                    cmd.Parameters.AddWithValue("@TobaccoQuantity", txt_TobaccoQuantity.Text);
                    cmd.Parameters.AddWithValue("@TobaccoDuraton", txt_TobaccoDuration.Text);
                    cmd.Parameters.AddWithValue("@Alcohol", cmb_Alcohol.Text);
                    cmd.Parameters.AddWithValue("@AlcoholQuantity", txt_AlcoholQuantity.Text);
                    cmd.Parameters.AddWithValue("@AlcoholDuration", txt_AlcoholDuration.Text);
                    cmd.Parameters.AddWithValue("@Drug", txt_Drug.Text);
                    cmd.Parameters.AddWithValue("@DrugType", txt_DrugType.Text);
                    cmd.Parameters.AddWithValue("@DrugDuration", txt_DrugDuration.Text);
                    cmd.Parameters.AddWithValue("@Dietary", txt_Dietary.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txt_BloodType.Text);
                    cmd.Parameters.AddWithValue("@Rh", cmb_Rh.Text);
                    cmd.Parameters.AddWithValue("@NumberOfChildren", txt_NumberOfChildren.Text);
                    cmd.Parameters.AddWithValue("@LMPStatus", txt_LMPStatus.Text);
                    cmd.Parameters.AddWithValue("@MensesMonthlyYes", txt_MensesMonthlyYes.Text);
                    cmd.Parameters.AddWithValue("@MensesMonthlyNo", txt_MensesMonthlyNo.Text);
                    cmd.Parameters.AddWithValue("@MensesFreq", txt_MensesFreq.Text);
                    cmd.Parameters.AddWithValue("@MedicalHistoryNotes", rt_MedicalNotes.Text);
                    cmd.Parameters.AddWithValue("@HxObtainedBy", txt_HxObtainedBy.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medical history recordinserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting medical history: " + ex.Message, "Database Error");



                }

            }
        }

        private void UpdateMedicalHistory()
        {
            // Implementation for updating existing medical history record
            // Similar to InsertMedicalHistory but using an UPDATE SQL statement
            string connStr = "server=127.0.0.1;uid=root;pwd=toor;database=ehr;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE generalmedicalhistory" +
                        " SET " +
                        "MaritalStatus = @MaritalStatus, Education = @Education, BehavioralHistory = @BehavioralHistory, " +
                        "Tobacco = @Tobacco, TobaccoQuantity = @TobaccoQuantity, TobaccoDuraton = @TobaccoDuraton, " +
                        "Alcohol = @Alcohol, AlcoholQuantity = @AlcoholQuantity, AlcoholDuration = @AlcoholDuration, " +
                        "Drug = @Drug, DrugType = @DrugType, DrugDuration = @DrugDuration, Dietary = @Dietary, " +
                        "BloodType = @BloodType, Rh = @Rh, NumberOfChildren = @NumberOfChildren, LMPStatus = @LMPStatus, " +
                        "MensesMonthlyYes = @MensesMonthlyYes, MensesMonthlyNo = @MensesMonthlyNo, MensesFreq = @MensesFreq, " +
                        "MedicalHistoryNotes = @MedicalHistoryNotes, HxObtainedBy = @HxObtainedBy, " +
                        "deleted = 0 WHERE PatientID = @PatientID = @patientID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", currentPatientID);
                    cmd.Parameters.AddWithValue("@MaritalStatus", cmb_MaritalStatus.Text);
                    cmd.Parameters.AddWithValue("@Education", txt_Education.Text);
                    cmd.Parameters.AddWithValue("@BehavioralHistory", txt_BehavioralHistory.Text);
                    cmd.Parameters.AddWithValue("@Tobacco", cmb_Tobacco.Text);
                    cmd.Parameters.AddWithValue("@TobaccoQuantity", txt_TobaccoQuantity.Text);
                    cmd.Parameters.AddWithValue("@TobaccoDuraton", txt_TobaccoDuration.Text);
                    cmd.Parameters.AddWithValue("@Alcohol", cmb_Alcohol.Text);
                    cmd.Parameters.AddWithValue("@AlcoholQuantity", txt_AlcoholQuantity.Text);
                    cmd.Parameters.AddWithValue("@AlcoholDuration", txt_AlcoholDuration.Text);
                    cmd.Parameters.AddWithValue("@Drug", txt_Drug.Text);
                    cmd.Parameters.AddWithValue("@DrugType", txt_DrugType.Text);
                    cmd.Parameters.AddWithValue("@DrugDuration", txt_DrugDuration.Text);
                    cmd.Parameters.AddWithValue("@Dietary", txt_Dietary.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txt_BloodType.Text);
                    cmd.Parameters.AddWithValue("@Rh", cmb_Rh.Text);
                    cmd.Parameters.AddWithValue("@NumberOfChildren", txt_NumberOfChildren.Text);
                    cmd.Parameters.AddWithValue("@LMPStatus", txt_LMPStatus.Text);
                    cmd.Parameters.AddWithValue("@MensesMonthlyYes", txt_MensesMonthlyYes.Text);
                    cmd.Parameters.AddWithValue("@MensesMonthlyNo", txt_MensesMonthlyNo.Text);
                    cmd.Parameters.AddWithValue("@MensesFreq", txt_MensesFreq.Text);
                    cmd.Parameters.AddWithValue("@MedicalHistoryNotes", rt_MedicalNotes.Text);
                    cmd.Parameters.AddWithValue("@HxObtainedBy", txt_HxObtainedBy.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medical history record updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating medical history: " + ex.Message, "Database Error");
                }
            }

        }




        private void btn_Modify_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (currentPatientID <= 0)
            {
                MessageBox.Show("Invalid Patient ID. Please load valid patient " +
                    "record before attempting to delete.", "Deletion Error");
                return;
            }
            // Confirm deletion
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this " +
                "medical history record?", "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm == DialogResult.Yes)
            {
                // Perform soft delete
                SoftDeleteMedicalHistory();
                LoadMedicalHistory();
            }

        }





            
            // Soft delete implementation
            private void SoftDeleteMedicalHistory()
            {


            }







        

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_selectpatient_nav_Click(object sender, EventArgs e)
        {
            Form f3 = new SelectPatient();
            f3.Show();
            this.Hide();
        }

        private void btn_gmh_nav_Click(object sender, EventArgs e)
        {
            Form f4 = new GMH();
            f4.Show();
            this.Hide();
        }
    }




}

   


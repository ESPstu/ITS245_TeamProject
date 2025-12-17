namespace ITS245_Project.Forms
{
    partial class FrmDemographics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPatientBanner = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEthnicity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNavSelectPatient = new System.Windows.Forms.Button();
            this.btnNavImmunizations = new System.Windows.Forms.Button();
            this.btnNavFamilyHistory = new System.Windows.Forms.Button();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatientBanner
            // 
            this.lblPatientBanner.BackColor = System.Drawing.SystemColors.Info;
            this.lblPatientBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBanner.Location = new System.Drawing.Point(0, 0);
            this.lblPatientBanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientBanner.Name = "lblPatientBanner";
            this.lblPatientBanner.Size = new System.Drawing.Size(1067, 39);
            this.lblPatientBanner.TabIndex = 0;
            this.lblPatientBanner.Text = "No patient Selected";
            this.lblPatientBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.label7);
            this.grpInputs.Controls.Add(this.label6);
            this.grpInputs.Controls.Add(this.label5);
            this.grpInputs.Controls.Add(this.label4);
            this.grpInputs.Controls.Add(this.label3);
            this.grpInputs.Controls.Add(this.label2);
            this.grpInputs.Controls.Add(this.label1);
            this.grpInputs.Controls.Add(this.cboGender);
            this.grpInputs.Controls.Add(this.dtpDob);
            this.grpInputs.Controls.Add(this.txtEmail);
            this.grpInputs.Controls.Add(this.txtEthnicity);
            this.grpInputs.Controls.Add(this.txtPhone);
            this.grpInputs.Controls.Add(this.txtLast);
            this.grpInputs.Controls.Add(this.txtFirst);
            this.grpInputs.Location = new System.Drawing.Point(13, 60);
            this.grpInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grpInputs.Size = new System.Drawing.Size(1017, 289);
            this.grpInputs.TabIndex = 1;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Patient Demographics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ethnicity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(705, 124);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(279, 24);
            this.cboGender.TabIndex = 6;
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(705, 66);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(279, 22);
            this.dtpDob.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(373, 124);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtEthnicity
            // 
            this.txtEthnicity.Location = new System.Drawing.Point(373, 68);
            this.txtEthnicity.Margin = new System.Windows.Forms.Padding(4);
            this.txtEthnicity.Name = "txtEthnicity";
            this.txtEthnicity.Size = new System.Drawing.Size(264, 22);
            this.txtEthnicity.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(36, 187);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(36, 124);
            this.txtLast.Margin = new System.Windows.Forms.Padding(4);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(264, 22);
            this.txtLast.TabIndex = 1;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(36, 68);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(264, 22);
            this.txtFirst.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(639, 400);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(639, 465);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(131, 33);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(851, 448);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(851, 394);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(131, 37);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(851, 505);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNavSelectPatient
            // 
            this.btnNavSelectPatient.Location = new System.Drawing.Point(49, 483);
            this.btnNavSelectPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavSelectPatient.Name = "btnNavSelectPatient";
            this.btnNavSelectPatient.Size = new System.Drawing.Size(200, 41);
            this.btnNavSelectPatient.TabIndex = 7;
            this.btnNavSelectPatient.Text = "Select Patient";
            this.btnNavSelectPatient.UseVisualStyleBackColor = true;
            this.btnNavSelectPatient.Click += new System.EventHandler(this.btnNavSelectPatient_Click);
            // 
            // btnNavImmunizations
            // 
            this.btnNavImmunizations.Location = new System.Drawing.Point(49, 394);
            this.btnNavImmunizations.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavImmunizations.Name = "btnNavImmunizations";
            this.btnNavImmunizations.Size = new System.Drawing.Size(200, 41);
            this.btnNavImmunizations.TabIndex = 8;
            this.btnNavImmunizations.Text = "Immunizations";
            this.btnNavImmunizations.UseVisualStyleBackColor = true;
            this.btnNavImmunizations.Click += new System.EventHandler(this.btnImunizations_Click);
            // 
            // btnNavFamilyHistory
            // 
            this.btnNavFamilyHistory.Location = new System.Drawing.Point(322, 394);
            this.btnNavFamilyHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavFamilyHistory.Name = "btnNavFamilyHistory";
            this.btnNavFamilyHistory.Size = new System.Drawing.Size(200, 41);
            this.btnNavFamilyHistory.TabIndex = 9;
            this.btnNavFamilyHistory.Text = "Family History";
            this.btnNavFamilyHistory.UseVisualStyleBackColor = true;
            this.btnNavFamilyHistory.Click += new System.EventHandler(this.btnNavFamilyHistory_Click);
            // 
            // FrmDemographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNavFamilyHistory);
            this.Controls.Add(this.btnNavImmunizations);
            this.Controls.Add(this.btnNavSelectPatient);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblPatientBanner);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDemographics";
            this.Text = "FrmDemographics";
            this.Load += new System.EventHandler(this.FrmDemographics_Load);
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientBanner;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEthnicity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNavSelectPatient;
        private System.Windows.Forms.Button btnNavImmunizations;
        private System.Windows.Forms.Button btnNavFamilyHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
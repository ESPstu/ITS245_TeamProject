namespace ITS245_Project.Forms
{
    partial class FrmImmunizations
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
            this.dgvImmunizations = new System.Windows.Forms.DataGridView();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpImmDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtImmName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNavSelectPatient = new System.Windows.Forms.Button();
            this.btnNavDemographics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImmunizations)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatientBanner
            // 
            this.lblPatientBanner.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPatientBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBanner.Location = new System.Drawing.Point(3, 9);
            this.lblPatientBanner.Name = "lblPatientBanner";
            this.lblPatientBanner.Size = new System.Drawing.Size(793, 41);
            this.lblPatientBanner.TabIndex = 0;
            this.lblPatientBanner.Text = "No Patient Selected";
            this.lblPatientBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvImmunizations
            // 
            this.dgvImmunizations.AllowUserToAddRows = false;
            this.dgvImmunizations.AllowUserToDeleteRows = false;
            this.dgvImmunizations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImmunizations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImmunizations.Location = new System.Drawing.Point(10, 64);
            this.dgvImmunizations.MultiSelect = false;
            this.dgvImmunizations.Name = "dgvImmunizations";
            this.dgvImmunizations.ReadOnly = true;
            this.dgvImmunizations.RowHeadersWidth = 51;
            this.dgvImmunizations.RowTemplate.Height = 24;
            this.dgvImmunizations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImmunizations.Size = new System.Drawing.Size(291, 245);
            this.dgvImmunizations.TabIndex = 1;
            this.dgvImmunizations.SelectionChanged += new System.EventHandler(this.dgvImmunizations_SelectionChanged);
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.label3);
            this.grpInputs.Controls.Add(this.dtpImmDate);
            this.grpInputs.Controls.Add(this.label2);
            this.grpInputs.Controls.Add(this.txtNotes);
            this.grpInputs.Controls.Add(this.txtImmName);
            this.grpInputs.Controls.Add(this.label1);
            this.grpInputs.Location = new System.Drawing.Point(331, 64);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(457, 244);
            this.grpInputs.TabIndex = 2;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Immunization Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes";
            // 
            // dtpImmDate
            // 
            this.dtpImmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImmDate.Location = new System.Drawing.Point(16, 128);
            this.dtpImmDate.Name = "dtpImmDate";
            this.dtpImmDate.ShowCheckBox = true;
            this.dtpImmDate.Size = new System.Drawing.Size(200, 22);
            this.dtpImmDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Immunization Date";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(246, 73);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(205, 153);
            this.txtNotes.TabIndex = 2;
            // 
            // txtImmName
            // 
            this.txtImmName.Location = new System.Drawing.Point(16, 61);
            this.txtImmName.Name = "txtImmName";
            this.txtImmName.Size = new System.Drawing.Size(100, 22);
            this.txtImmName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Immunization Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(347, 373);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(472, 373);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(472, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNavSelectPatient
            // 
            this.btnNavSelectPatient.Location = new System.Drawing.Point(24, 352);
            this.btnNavSelectPatient.Name = "btnNavSelectPatient";
            this.btnNavSelectPatient.Size = new System.Drawing.Size(85, 64);
            this.btnNavSelectPatient.TabIndex = 14;
            this.btnNavSelectPatient.Text = "Select Patient";
            this.btnNavSelectPatient.UseVisualStyleBackColor = true;
            this.btnNavSelectPatient.Click += new System.EventHandler(this.btnNavSelectPatient_Click);
            // 
            // btnNavDemographics
            // 
            this.btnNavDemographics.Location = new System.Drawing.Point(144, 352);
            this.btnNavDemographics.Name = "btnNavDemographics";
            this.btnNavDemographics.Size = new System.Drawing.Size(115, 64);
            this.btnNavDemographics.TabIndex = 16;
            this.btnNavDemographics.Text = "Demographics";
            this.btnNavDemographics.UseVisualStyleBackColor = true;
            this.btnNavDemographics.Click += new System.EventHandler(this.btnNavDemographics_Click);
            // 
            // FrmImmunizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavDemographics);
            this.Controls.Add(this.btnNavSelectPatient);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.dgvImmunizations);
            this.Controls.Add(this.lblPatientBanner);
            this.Name = "FrmImmunizations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Immunizations";
            this.Load += new System.EventHandler(this.FrmImmunizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImmunizations)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatientBanner;
        private System.Windows.Forms.DataGridView dgvImmunizations;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpImmDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtImmName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNavSelectPatient;
        private System.Windows.Forms.Button btnNavDemographics;
    }
}
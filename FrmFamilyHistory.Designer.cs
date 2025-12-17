namespace ITS245_Project.Forms
{
    partial class FrmFamilyHistory
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvFamily = new System.Windows.Forms.DataGridView();
            this.lblPatientBanner = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNavDemographics = new System.Windows.Forms.Button();
            this.btnNavImmunizations = new System.Windows.Forms.Button();
            this.btnNavSelectPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(835, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFamily
            // 
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Location = new System.Drawing.Point(39, 304);
            this.dgvFamily.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.RowHeadersWidth = 51;
            this.dgvFamily.Size = new System.Drawing.Size(453, 235);
            this.dgvFamily.TabIndex = 5;
            // 
            // lblPatientBanner
            // 
            this.lblPatientBanner.AutoSize = true;
            this.lblPatientBanner.BackColor = System.Drawing.SystemColors.Info;
            this.lblPatientBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPatientBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientBanner.Location = new System.Drawing.Point(0, 0);
            this.lblPatientBanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientBanner.Name = "lblPatientBanner";
            this.lblPatientBanner.Size = new System.Drawing.Size(115, 39);
            this.lblPatientBanner.TabIndex = 6;
            this.lblPatientBanner.Text = "label1";
            this.lblPatientBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.label3);
            this.grpInputs.Controls.Add(this.label2);
            this.grpInputs.Controls.Add(this.label1);
            this.grpInputs.Controls.Add(this.txtNotes);
            this.grpInputs.Controls.Add(this.txtCondition);
            this.grpInputs.Controls.Add(this.txtRelationship);
            this.grpInputs.Location = new System.Drawing.Point(536, 304);
            this.grpInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grpInputs.Size = new System.Drawing.Size(508, 234);
            this.grpInputs.TabIndex = 7;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Family History";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(39, 154);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(427, 72);
            this.txtNotes.TabIndex = 2;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(39, 108);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(427, 22);
            this.txtCondition.TabIndex = 1;
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(39, 53);
            this.txtRelationship.Margin = new System.Windows.Forms.Padding(4);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.Size = new System.Drawing.Size(427, 22);
            this.txtRelationship.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(835, 130);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(168, 60);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(835, 219);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 60);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(600, 76);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(168, 60);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 182);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 60);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNavDemographics
            // 
            this.btnNavDemographics.Location = new System.Drawing.Point(343, 42);
            this.btnNavDemographics.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavDemographics.Name = "btnNavDemographics";
            this.btnNavDemographics.Size = new System.Drawing.Size(168, 60);
            this.btnNavDemographics.TabIndex = 12;
            this.btnNavDemographics.Text = "Demographics";
            this.btnNavDemographics.UseVisualStyleBackColor = true;
            this.btnNavDemographics.Click += new System.EventHandler(this.btnNavDemographics_Click);
            // 
            // btnNavImmunizations
            // 
            this.btnNavImmunizations.Location = new System.Drawing.Point(343, 130);
            this.btnNavImmunizations.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavImmunizations.Name = "btnNavImmunizations";
            this.btnNavImmunizations.Size = new System.Drawing.Size(168, 60);
            this.btnNavImmunizations.TabIndex = 13;
            this.btnNavImmunizations.Text = "Immunizations";
            this.btnNavImmunizations.UseVisualStyleBackColor = true;
            this.btnNavImmunizations.Click += new System.EventHandler(this.btnNavImmunizations_Click);
            // 
            // btnNavSelectPatient
            // 
            this.btnNavSelectPatient.Location = new System.Drawing.Point(343, 219);
            this.btnNavSelectPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavSelectPatient.Name = "btnNavSelectPatient";
            this.btnNavSelectPatient.Size = new System.Drawing.Size(168, 60);
            this.btnNavSelectPatient.TabIndex = 14;
            this.btnNavSelectPatient.Text = "Select Patient";
            this.btnNavSelectPatient.UseVisualStyleBackColor = true;
            this.btnNavSelectPatient.Click += new System.EventHandler(this.btnNavSelectPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Relationship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes";
            // 
            // FrmFamilyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNavSelectPatient);
            this.Controls.Add(this.btnNavImmunizations);
            this.Controls.Add(this.btnNavDemographics);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblPatientBanner);
            this.Controls.Add(this.dgvFamily);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFamilyHistory";
            this.Text = "FrmFamilyHistory";
            this.Load += new System.EventHandler(this.FrmFamilyHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFamily;
        private System.Windows.Forms.Label lblPatientBanner;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNavDemographics;
        private System.Windows.Forms.Button btnNavImmunizations;
        private System.Windows.Forms.Button btnNavSelectPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
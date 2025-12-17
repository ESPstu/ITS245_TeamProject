namespace ITS245_Project.Forms
{
    partial class FrmSelectPatient
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbPatientId = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOpenDemographics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(59, 42);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.Size = new System.Drawing.Size(479, 348);
            this.dgvPatients.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(637, 133);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // rbPatientId
            // 
            this.rbPatientId.AutoSize = true;
            this.rbPatientId.Location = new System.Drawing.Point(804, 207);
            this.rbPatientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPatientId.Name = "rbPatientId";
            this.rbPatientId.Size = new System.Drawing.Size(85, 20);
            this.rbPatientId.TabIndex = 2;
            this.rbPatientId.Text = "Patient ID";
            this.rbPatientId.UseVisualStyleBackColor = true;
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Checked = true;
            this.rbLastName.Location = new System.Drawing.Point(604, 207);
            this.rbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(93, 20);
            this.rbLastName.TabIndex = 3;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Last Name";
            this.rbLastName.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(585, 272);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 74);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(349, 412);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(188, 71);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(804, 272);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(173, 74);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select Patient";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOpenDemographics
            // 
            this.btnOpenDemographics.Location = new System.Drawing.Point(59, 412);
            this.btnOpenDemographics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenDemographics.Name = "btnOpenDemographics";
            this.btnOpenDemographics.Size = new System.Drawing.Size(193, 71);
            this.btnOpenDemographics.TabIndex = 7;
            this.btnOpenDemographics.Text = "Open Demographics";
            this.btnOpenDemographics.UseVisualStyleBackColor = true;
            this.btnOpenDemographics.Click += new System.EventHandler(this.btnOpenDemographics_Click);
            // 
            // FrmSelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnOpenDemographics);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rbLastName);
            this.Controls.Add(this.rbPatientId);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvPatients);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSelectPatient";
            this.Text = "FrmSelectPatient";
            this.Load += new System.EventHandler(this.FrmSelectPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbPatientId;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOpenDemographics;
    }
}
namespace _245_Proj_Prototype
{
    partial class SelectPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_SearchPatient = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Medications = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btn_Medications);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(779, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 612);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Allergies";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "General Medical History";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "Select Patient ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(19, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 36);
            this.button4.TabIndex = 0;
            this.button4.Text = "Patient Demographics";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tb_SearchPatient
            // 
            this.tb_SearchPatient.Location = new System.Drawing.Point(94, 454);
            this.tb_SearchPatient.Name = "tb_SearchPatient";
            this.tb_SearchPatient.Size = new System.Drawing.Size(100, 22);
            this.tb_SearchPatient.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 384);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(322, 454);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 35);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Medications
            // 
            this.btn_Medications.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Medications.Location = new System.Drawing.Point(16, 376);
            this.btn_Medications.Name = "btn_Medications";
            this.btn_Medications.Size = new System.Drawing.Size(227, 36);
            this.btn_Medications.TabIndex = 4;
            this.btn_Medications.Text = "Medications ";
            this.btn_Medications.UseVisualStyleBackColor = false;
            // 
            // SelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 607);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_SearchPatient);
            this.Controls.Add(this.panel1);
            this.Name = "SelectPatient";
            this.Text = "SelectPatient";
            this.Load += new System.EventHandler(this.SelectPatient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_SearchPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Medications;
    }
}
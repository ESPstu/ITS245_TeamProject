namespace _245_Proj_Prototype
{
    partial class LoginForm
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
            this.tb_Login1 = new System.Windows.Forms.TextBox();
            this.tb_Login2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LoginEnter = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Login1
            // 
            this.tb_Login1.Location = new System.Drawing.Point(280, 87);
            this.tb_Login1.Name = "tb_Login1";
            this.tb_Login1.Size = new System.Drawing.Size(251, 22);
            this.tb_Login1.TabIndex = 0;
            // 
            // tb_Login2
            // 
            this.tb_Login2.Location = new System.Drawing.Point(280, 152);
            this.tb_Login2.Name = "tb_Login2";
            this.tb_Login2.Size = new System.Drawing.Size(251, 22);
            this.tb_Login2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // btn_LoginEnter
            // 
            this.btn_LoginEnter.Location = new System.Drawing.Point(446, 241);
            this.btn_LoginEnter.Name = "btn_LoginEnter";
            this.btn_LoginEnter.Size = new System.Drawing.Size(75, 27);
            this.btn_LoginEnter.TabIndex = 4;
            this.btn_LoginEnter.Text = "Login";
            this.btn_LoginEnter.UseVisualStyleBackColor = true;
            this.btn_LoginEnter.Click += new System.EventHandler(this.btn_LoginEnter_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(33, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_LoginEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Login2);
            this.Controls.Add(this.tb_Login1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login1;
        private System.Windows.Forms.TextBox tb_Login2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LoginEnter;
        private System.Windows.Forms.Button btn_back;
    }
}
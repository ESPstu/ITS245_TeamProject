using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _245_Proj_Prototype
{
    public partial class SelectPatient : Form
    {
        public SelectPatient()
        {
            InitializeComponent();
        }

        private void SelectPatient_Load(object sender, EventArgs e)
        {

        }

        private void btn_gmh_nav_Click(object sender, EventArgs e)
        {
            Form f4 = new GMH();
            f4.Show();
            this.Hide();
        }
    }
}

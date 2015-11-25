using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_QC
{
    public partial class ProjectListForm : Form
    {
        public ProjectListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateProjectTabForm forms = new CreateProjectTabForm();
            this.Hide();
            forms.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void tabDetail_Click(object sender, EventArgs e)
        {
            tabDetail.Focus();
        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click_1(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }
    }
}

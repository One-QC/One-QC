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
    }
}

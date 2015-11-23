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
    public partial class CreateProjectTabForm : Form
    {
        public CreateProjectTabForm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Create_Project_Tab_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewProjectMemberForm forms = new AddNewProjectMemberForm();
            forms.ShowDialog();
        }
    }
}

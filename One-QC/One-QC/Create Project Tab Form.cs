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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbProjectID.Text.Equals(String.Empty) && txbProjectName.Text.Equals(String.Empty) && txbDivision.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project ID, Project Name and Division is empty. Please fill the textbox.");
            }
            else if (txbProjectID.Text.Equals(String.Empty) && txbProjectName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project ID and Project Name is empty. Please fill the textbox.");
            }
            else if (txbProjectID.Text.Equals(String.Empty) && txbDivision.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project ID and Division is empty. Please fill the textbox.");
            }
            else if (txbProjectName.Text.Equals(String.Empty) && txbDivision.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project Name and Division is empty. Please fill the textbox.");
            }
            else if (txbProjectID.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project ID is empty. Please fill the textbox.");
            }
            else if (txbProjectName.Text.Equals(String.Empty))
            {
                MessageBox.Show("Project Name is empty. Please fill the textbox.");
            }
            else if (txbDivision.Text.Equals(String.Empty))
            {
                MessageBox.Show("Division is empty. Please fill the textbox.");
            }
            else
            {

            }
        }
    }
}

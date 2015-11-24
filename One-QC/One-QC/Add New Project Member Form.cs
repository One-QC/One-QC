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
    public partial class AddNewProjectMemberForm : Form
    {
        public AddNewProjectMemberForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_New_Project_Member_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString().Equals(String.Empty))
            {
                MessageBox.Show("Please select the Role.");
            }
        }

        private void cmbRole_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString().Equals(String.Empty))
            {
                cmbNama.Enabled = false;
            }
            else
            {
                cmbNama.Enabled = true;
            }
        }

    }
}

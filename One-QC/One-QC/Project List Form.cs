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
    public partial class Project_List_Form : Form
    {
        public Project_List_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Project_Tab_Form forms = new Create_Project_Tab_Form();
            this.Hide();
            forms.Show();
        }
    }
}

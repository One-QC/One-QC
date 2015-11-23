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
    public partial class Create_Project_Tab_Form : Form
    {
        public Create_Project_Tab_Form()
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
            Add_New_Project_Member_Form forms = new Add_New_Project_Member_Form();
            forms.ShowDialog();
        }
    }
}

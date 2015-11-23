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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (txbUser.Text.Equals(String.Empty) && txbPass.Text.Equals(String.Empty))
            {
                MessageBox.Show("User ID dan Password tidak diisi. Silahkan mengisi User ID dan Password Anda.");
            }
            else if (txbUser.Text.Equals(String.Empty))
            {
                MessageBox.Show("User ID tidak diisi. Silahkan mengisi User ID Anda.");
            }
            else if (txbPass.Text.Equals(String.Empty))
            {
                MessageBox.Show("Password tidak diisi. Silahkan mengisi Password Anda.");
            }
            else
            {
                ProjectListForm projectForm = new ProjectListForm();
                projectForm.Show();
            }
        }
    }
}

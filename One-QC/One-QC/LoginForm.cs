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
    public partial class LoginForm : Form , Interface.iLogin
    {
        Presenter.PresenterLogin presLogin;

        public LoginForm()
        {
            presLogin = new Presenter.PresenterLogin(this);
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
            if (txbUser.Text.Equals(String.Empty) && txbPass.Text.Equals(String.Empty))
            {
                MessageBox.Show("User ID and Password is empty. Please fill the textbox.");
            }
            else if (txbUser.Text.Equals(String.Empty))
            {
                MessageBox.Show("User ID is empty. Please fill the textbox.");
            }
            else if (txbPass.Text.Equals(String.Empty))
            {
                MessageBox.Show("Password is empty. Please fill the textbox.");
            }
            else
            {
                DataSet ds = this.presLogin.loginAuthentication();
                MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                this.Hide();
                ProjectListForm projectForm = new ProjectListForm();
                projectForm.Show();
            }
        }

        public string userID
        {
            get
            {
                return txbUser.Text;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string password
        {
            get
            {
                return txbPass.Text;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

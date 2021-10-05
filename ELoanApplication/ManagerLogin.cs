using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELoanApplication
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (textusername.Text == "")
            {
                MessageBox.Show("Username cant be null");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("password cant be null");
            }
            else if (textusername.Text == "Admin" && txtpassword.Text == "Admin")
            {


                ManagerHelp manager = new ManagerHelp();
                manager.Show();

            }
            else
            {
                MessageBox.Show("please enter valid credentials");
            }
        }
    }
}

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
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Username cant be null");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("password cant be null");
            }
            else if (txtusername.Text == "Admin" && txtpassword.Text == "Admin")
            {


                Registerbtn register = new Registerbtn();
                register.Show();

            }
            else
            {
                MessageBox.Show("please enter valid credentials");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frontpage front = new frontpage();
            front.Show();
          
        }
    }
}

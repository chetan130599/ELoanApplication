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
    public partial class frontpage : Form
    {
        public frontpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginpage login = new Loginpage();
            login.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Customerregister customer = new Customerregister();
            customer.Show();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            ManagerLogin manager = new ManagerLogin();
            manager.Show();
        }
    }
}

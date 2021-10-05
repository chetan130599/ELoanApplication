using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ELoanApplication
{
    public partial class Registerbtn : Form
    {
        public Registerbtn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          SqlConnection  connection = new SqlConnection(@"Data Source=DESKTOP-B227PU8\SQLEXPRESS;integrated security = sspi;initial catalog=Loan;");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into manager1 values('" + txtfname.Text + "','" +txtlname.Text + "','" +txtcontact.Text  + "','" + txtmail.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Book Added successfully.");
        }
    }
}

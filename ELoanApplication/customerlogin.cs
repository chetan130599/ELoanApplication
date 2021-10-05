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
    public partial class customerlogin : Form
    {
        public customerlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand;
            SqlDataReader reader;
            try
            {
                sqlConnection = new SqlConnection(@"Data source=DESKTOP-B227PU8\SQLEXPRESS;initial catalog=Loan;Integrated Security=SSPI");
                sqlCommand = new SqlCommand("select * from customer where Username=@user and password=@pass", sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("user", user);
                sqlCommand.Parameters.AddWithValue("pass", pass);
                reader = sqlCommand.ExecuteReader();
                bool read = reader.Read();
                if (read == true)
                {
                    // MessageBox.Show("Login Successful");
                    applylogin apply = new applylogin();
                    apply.Show();
                         

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Enter Valid Data");
            }
            finally
            {

                sqlConnection.Close();
            }

        }
    }
    }


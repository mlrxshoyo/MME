using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace MME
{
    public partial class Login : Form
    {

        OleDbConnection conn;

        OleDbCommand cmd;

        OleDbDataAdapter adapter;

        public Login()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {



        }



        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";
            string query = "SELECT COUNT(*) FROM loginAcc WHERE Username = @username AND Password = @password";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", txtUser.Text);
                command.Parameters.AddWithValue("@password", txtPass.Text);
                connection.Open();
                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    Form1 news = new Form1();
                    news.Show();
                    this.Hide();

                    news.lblName.Text = txtUser.Text;
                }
                else
                {
                    MessageBox.Show("Incorrect password or username");
                }
            }
        }
    }
}

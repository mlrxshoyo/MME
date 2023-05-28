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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        // Connection to database
        OleDbConnection conn;
        // Commands to insert delete or update, select, and Reader (ExecuteReader() and ExecuteNonQuery())
        OleDbCommand cmd;
        // To Connect the Tools like datagridview direct to database
        OleDbDataAdapter adapter;
        // This is a column and rows in our database and inserting in our Forms ( Database access to Windows Form )
        DataTable table;

        void showDetails()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb");


            table = new DataTable();


            adapter = new OleDbDataAdapter("SELECT * FROM BackgroundInfo", conn);


            conn.Open();


            adapter.Fill(table);

            conn.Close();

            // ...
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click_1(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";

                string searchTerm = tbSearchEmp.Text;

                string query = "SELECT * FROM BackgroundInfo WHERE hEmployee LIKE '%" + searchTerm + "%'";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {

                    OleDbCommand command = new OleDbCommand(query, connection);

                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        reader.Read();
                        resName.Text = reader["rName"].ToString();
                        resPosition.Text = reader["rPosition"].ToString();
                        resEmail.Text = reader["rEmail"].ToString();
                        resPhone.Text = reader["rPhone"].ToString();
                        lblHire.Text = reader["hDate"].ToString();
                        lblEmployee.Text = reader["hEmployee"].ToString();
                        showNation.Text = reader["pNationality"].ToString();
                        showGender.Text = reader["pGender"].ToString();
                        showBirth.Text = reader["pBirth"].ToString();
                        showStatus.Text = reader["pStatus"].ToString();
                        showWork.Text = reader["wInfo"].ToString();

                    }
                    else
                    {

                        MessageBox.Show("Not Found in Our Database");


                    }
                }
            }
            catch
            {

                MessageBox.Show("This is Error in our Database, Sorry!");
            }
        }

        private void Employee_Load_1(object sender, EventArgs e)
        {
            showDetails();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

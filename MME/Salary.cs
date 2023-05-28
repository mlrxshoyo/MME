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
    public partial class Salary : Form
    {
        public Salary()
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

        void Salarydata()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb");


            table = new DataTable();


            adapter = new OleDbDataAdapter("SELECT * FROM Salary", conn);


            conn.Open();


            adapter.Fill(table);


            salaryData.DataSource = table;


            conn.Close();

            // ...
        }


        // Update
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string updateQuery = "UPDATE Salary SET empID = @empID, empName = @empName, empSalary = @empSalary WHERE ID = @ID";

            OleDbCommand cmd = new OleDbCommand(updateQuery, connection);
            cmd.Parameters.AddWithValue("@empID", upEmpID.Text);
            cmd.Parameters.AddWithValue("@empName", txtName.Text);
            cmd.Parameters.AddWithValue("@empSalary", upEmpSalary.Text);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lbl.Text));

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Salarydata();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            Salarydata();
        }

        private void salaryData_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            lbl.Text = salaryData.CurrentRow.Cells[0].Value.ToString();
            upEmpID.Text = salaryData.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = salaryData.CurrentRow.Cells[2].Value.ToString();
            upEmpSalary.Text = salaryData.CurrentRow.Cells[3].Value.ToString();
        }

        // Load Data
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";

                string searchTerm = txtInput.Text;

                string query = "SELECT * FROM Salary WHERE empID LIKE '%" + searchTerm + "%'";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {

                    OleDbCommand command = new OleDbCommand(query, connection);

                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();


                    if (reader.HasRows)
                    {
                        reader.Read();
                        lblEmp.Text = reader["empID"].ToString();
                        lblName.Text = reader["empName"].ToString();
                        lblSalary.Text = reader["empSalary"].ToString();
                        lblID.Text = reader["ID"].ToString();
                    }
                    else
                    {

                        MessageBox.Show("No Record");

                        lblID.Text = "";
                        lblEmp.Text = "";
                        lblName.Text = "";
                        lblSalary.Text = "";
                    }
                }
            }
            catch
            {

                MessageBox.Show("This is Error in our Database, Sorry!");
            }
        }
    }
}


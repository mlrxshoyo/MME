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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Text.RegularExpressions;
using System.Windows.Forms.Design.Behavior;

namespace MME
{
    public partial class WorkDays : Form
    {
        public WorkDays()
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

        void Workdays()
        {
            // ...

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb");


            table = new DataTable();


            adapter = new OleDbDataAdapter("SELECT * FROM WorkDays", conn);


            conn.Open();


            adapter.Fill(table);


            data.DataSource = table;


            conn.Close();

            // ...
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void WorkDays_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           

        }

        // Load Data 
        private void WorkDays_Load_1(object sender, EventArgs e)
        {
            Workdays();
        }
        // Button Search
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";

                string searchTerm = txtSearch.Text;

                string query = "SELECT * FROM WorkDays WHERE newID LIKE '%" + searchTerm + "%'";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {

                    OleDbCommand command = new OleDbCommand(query, connection);

                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    // 1st Condition
                    if (reader.HasRows)
                    {
                        reader.Read();
                        lblemployee.Text = reader["newID"].ToString();
                        lblName.Text = reader["newName"].ToString();
                        lblDate.Text = reader["newDate"].ToString();
                        lblRemarks.Text = reader["newRemark"].ToString();
                        lblID.Text = reader["ID"].ToString();
                    }
                    else
                    {

                        MessageBox.Show("No Record");

                        lblID.Text = "";
                        lblemployee.Text = "";
                        lblName.Text = "";
                        lblRemarks.Text = "";
                        lblDate.Text = "";
                    }
                }
            }
            catch
            {

                MessageBox.Show("This is Error in our Database, Sorry!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        // Button for Add new in Database
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string addNew = "INSERT INTO WorkDays (newID,newName,newDate,newRemark) VALUES (@newID, @newName, @newDate, @newRemark)";
                cmd = new OleDbCommand(addNew, conn);

                cmd.Parameters.AddWithValue("@newID", txtEmp.Text);
                cmd.Parameters.AddWithValue("@newName", txtName.Text);
                cmd.Parameters.AddWithValue("@newDate", time.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@newRemark", txtRemarks.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Insert to Database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    Workdays();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void data_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIDS.Text = data.CurrentRow.Cells[0].Value.ToString();
            txtEmp.Text = data.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = data.CurrentRow.Cells[2].Value.ToString();    
            
            
            DateTime dateValue;
            if (DateTime.TryParse(data.CurrentRow.Cells[3].Value.ToString(), out dateValue))
            {
                time.Value = dateValue;
            }
            txtRemarks.Text = data.CurrentRow.Cells[4].Value.ToString();
        }

        // Button Update
        private void btnRemarks_Click(object sender, EventArgs e)
        {

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MMdatabase.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string updateQuery = "UPDATE WorkDays SET newID = @newID, newName = @newName, newDate = @newDate, newRemark = @newRemark WHERE ID = @ID";

            OleDbCommand cmd = new OleDbCommand(updateQuery, connection);

                cmd.Parameters.AddWithValue("@newID", txtEmp.Text);
                cmd.Parameters.AddWithValue("@newName", txtName.Text);
                cmd.Parameters.AddWithValue("@newDate", time.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@newRemark", txtRemarks.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtIDS.Text)); // set the id of the record to be updated
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

            Workdays();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDS.Text = "";
            txtEmp.Text = "";
            txtName.Text = "";
            txtRemarks.Text = "";

        }
    }
}



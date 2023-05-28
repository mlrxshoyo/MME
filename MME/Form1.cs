using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Load(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkDays_Click(object sender, EventArgs e)
        {

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Button
        private void btnSalary_Click_1(object sender, EventArgs e)
        {
            Load(new Salary());
        }

        private void btnWorkDays_Click_1(object sender, EventArgs e)
        {
            Load(new WorkDays());
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            Load(new Employee());
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Load(new About());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login sout = new Login();
                sout.Show();
                this.Hide();
            }

        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MME
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < 10)
            {
                progressBar2.Value += 1;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "10%";
                label3.Text = "Loading . . .";
            }
            else if (progressBar2.Value < 20)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "20%";
            }
            else if (progressBar2.Value < 30)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "30%";
            }
            else if (progressBar2.Value < 40)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "40%";
            }
            else if (progressBar2.Value < 50)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "50%";
            }
            else if (progressBar2.Value < 60)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "60%";
            }
            else if (progressBar2.Value < 70)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "70%";
            }
            else if (progressBar2.Value < 80)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "80%";
            }
            else if (progressBar2.Value < 90)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "90%";
            }
            else if (progressBar2.Value < 100)
            {
                progressBar2.Value += 2;
                progressBar2.ForeColor = Color.Blue;
                label4.Text = "100%";

                this.Hide();
                Login frm = new Login();
                timer1.Stop();
                frm.Show();
            }
        }
    }
}

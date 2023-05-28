namespace MME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblUser = new Label();
            btnSignOut = new Button();
            label3 = new Label();
            label2 = new Label();
            btnSalary = new Button();
            btnWorkDays = new Button();
            btnEmployee = new Button();
            btnDash = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 228, 222);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(btnSignOut);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSalary);
            panel1.Controls.Add(btnWorkDays);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnDash);
            panel1.Location = new Point(0, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 784);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(81, 604);
            lblName.Name = "lblName";
            lblName.Size = new Size(17, 19);
            lblName.TabIndex = 9;
            lblName.Text = "--";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(31, 603);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 19);
            lblUser.TabIndex = 8;
            lblUser.Text = "User :";
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.FromArgb(46, 79, 79);
            btnSignOut.FlatStyle = FlatStyle.Popup;
            btnSignOut.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignOut.ForeColor = SystemColors.ButtonFace;
            btnSignOut.Location = new Point(31, 637);
            btnSignOut.Margin = new Padding(3, 4, 3, 4);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(186, 57);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(46, 79, 79);
            label3.Location = new Point(115, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 45);
            label3.TabIndex = 5;
            label3.Text = "Me!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(46, 79, 79);
            label2.Location = new Point(115, 40);
            label2.Name = "label2";
            label2.Size = new Size(116, 37);
            label2.TabIndex = 4;
            label2.Text = "Manage";
            // 
            // btnSalary
            // 
            btnSalary.BackColor = Color.FromArgb(46, 79, 79);
            btnSalary.FlatStyle = FlatStyle.Popup;
            btnSalary.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalary.ForeColor = SystemColors.ButtonFace;
            btnSalary.Location = new Point(33, 328);
            btnSalary.Margin = new Padding(3, 4, 3, 4);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(186, 57);
            btnSalary.TabIndex = 3;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = false;
            btnSalary.Click += btnSalary_Click_1;
            // 
            // btnWorkDays
            // 
            btnWorkDays.BackColor = Color.FromArgb(46, 79, 79);
            btnWorkDays.FlatStyle = FlatStyle.Popup;
            btnWorkDays.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkDays.ForeColor = SystemColors.ButtonFace;
            btnWorkDays.Location = new Point(33, 251);
            btnWorkDays.Margin = new Padding(3, 4, 3, 4);
            btnWorkDays.Name = "btnWorkDays";
            btnWorkDays.Size = new Size(186, 57);
            btnWorkDays.TabIndex = 2;
            btnWorkDays.Text = "WorkDays";
            btnWorkDays.UseVisualStyleBackColor = false;
            btnWorkDays.Click += btnWorkDays_Click_1;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(46, 79, 79);
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.ButtonFace;
            btnEmployee.Location = new Point(33, 174);
            btnEmployee.Margin = new Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(186, 57);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click_1;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.FromArgb(46, 79, 79);
            btnDash.FlatStyle = FlatStyle.Popup;
            btnDash.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDash.ForeColor = SystemColors.ButtonFace;
            btnDash.Location = new Point(31, 702);
            btnDash.Margin = new Padding(3, 4, 3, 4);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(186, 57);
            btnDash.TabIndex = 0;
            btnDash.Text = "About";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(203, 228, 222);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(253, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 783);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(677, -21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(417, 328);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 785);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Me! - Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDash;
        private Button btnEmployee;
        private Button btnSalary;
        private Button btnWorkDays;
        private Label label3;
        private Label label2;
        private Label lblUser;
        private Button btnSignOut;
        private Label label1;
        public Label lblName;
        public Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
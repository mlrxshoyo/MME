namespace MME
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnCLear = new Button();
            btnLogin = new Button();
            label7 = new Label();
            label6 = new Label();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 228, 222);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnCLear);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 668);
            panel1.TabIndex = 0;
            // 
            // btnCLear
            // 
            btnCLear.BackColor = Color.FromArgb(46, 79, 79);
            btnCLear.FlatStyle = FlatStyle.Popup;
            btnCLear.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCLear.ForeColor = SystemColors.ButtonFace;
            btnCLear.Location = new Point(813, 426);
            btnCLear.Margin = new Padding(3, 4, 3, 4);
            btnCLear.Name = "btnCLear";
            btnCLear.Size = new Size(86, 29);
            btnCLear.TabIndex = 11;
            btnCLear.Text = "Clear";
            btnCLear.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 79, 79);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(723, 426);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 29);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(630, 351);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 9;
            label7.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(630, 285);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 8;
            label6.Text = "Username :";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(630, 379);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(269, 29);
            txtPass.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(630, 313);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(269, 29);
            txtUser.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(46, 79, 79);
            label5.Location = new Point(34, 304);
            label5.Name = "label5";
            label5.Size = new Size(424, 39);
            label5.TabIndex = 5;
            label5.Text = "Employee Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(46, 79, 79);
            label4.Location = new Point(34, 228);
            label4.Name = "label4";
            label4.Size = new Size(215, 60);
            label4.TabIndex = 4;
            label4.Text = "Effortless";
            // 
            // label3
            // 
            label3.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(46, 79, 79);
            label3.Location = new Point(225, 92);
            label3.Name = "label3";
            label3.Size = new Size(194, 122);
            label3.TabIndex = 3;
            label3.Text = "Me!";
            // 
            // label2
            // 
            label2.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(46, 79, 79);
            label2.Location = new Point(232, 14);
            label2.Name = "label2";
            label2.Size = new Size(286, 95);
            label2.TabIndex = 2;
            label2.Text = "Manage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 692);
            label1.Name = "label1";
            label1.Size = new Size(270, 26);
            label1.TabIndex = 1;
            label1.Text = "Powered by TeamSync ⓒ 2023";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(1026, 726);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCLear;
        private Button btnLogin;
        private Label label7;
        private Label label6;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
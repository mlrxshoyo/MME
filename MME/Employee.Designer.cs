namespace MME
{
    partial class Employee
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
            panel3 = new Panel();
            panel7 = new Panel();
            showStatus = new Label();
            showBirth = new Label();
            showGender = new Label();
            showNation = new Label();
            lblStatus = new Label();
            lblBirthDate = new Label();
            lblGender = new Label();
            lblNationality = new Label();
            lblPB = new Label();
            panel6 = new Panel();
            lblEmployee = new Label();
            lblHire = new Label();
            lblEmpId = new Label();
            lblHireDate = new Label();
            panel5 = new Panel();
            showWork = new Label();
            lblWorkInfo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            resPhone = new Label();
            resEmail = new Label();
            resPosition = new Label();
            resName = new Label();
            btnFetch = new Button();
            label1 = new Label();
            tbSearchEmp = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblPosition = new Label();
            lblName = new Label();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 79, 79);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(16, 277);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 493);
            panel3.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(203, 228, 222);
            panel7.Controls.Add(showStatus);
            panel7.Controls.Add(showBirth);
            panel7.Controls.Add(showGender);
            panel7.Controls.Add(showNation);
            panel7.Controls.Add(lblStatus);
            panel7.Controls.Add(lblBirthDate);
            panel7.Controls.Add(lblGender);
            panel7.Controls.Add(lblNationality);
            panel7.Controls.Add(lblPB);
            panel7.Location = new Point(18, 157);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(605, 317);
            panel7.TabIndex = 2;
            // 
            // showStatus
            // 
            showStatus.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            showStatus.ForeColor = Color.FromArgb(46, 79, 79);
            showStatus.Location = new Point(160, 215);
            showStatus.Name = "showStatus";
            showStatus.Size = new Size(457, 74);
            showStatus.TabIndex = 23;
            showStatus.Text = "--";
            // 
            // showBirth
            // 
            showBirth.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            showBirth.ForeColor = Color.FromArgb(46, 79, 79);
            showBirth.Location = new Point(160, 168);
            showBirth.Name = "showBirth";
            showBirth.Size = new Size(457, 74);
            showBirth.TabIndex = 22;
            showBirth.Text = "--";
            // 
            // showGender
            // 
            showGender.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            showGender.ForeColor = Color.FromArgb(46, 79, 79);
            showGender.Location = new Point(160, 121);
            showGender.Name = "showGender";
            showGender.Size = new Size(457, 74);
            showGender.TabIndex = 21;
            showGender.Text = "--";
            // 
            // showNation
            // 
            showNation.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            showNation.ForeColor = Color.FromArgb(46, 79, 79);
            showNation.Location = new Point(161, 73);
            showNation.Name = "showNation";
            showNation.Size = new Size(457, 74);
            showNation.TabIndex = 18;
            showNation.Text = "--";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(46, 79, 79);
            lblStatus.Location = new Point(19, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(80, 29);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthDate.ForeColor = Color.FromArgb(46, 79, 79);
            lblBirthDate.Location = new Point(19, 165);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(114, 29);
            lblBirthDate.TabIndex = 19;
            lblBirthDate.Text = "Birth Date:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.ForeColor = Color.FromArgb(46, 79, 79);
            lblGender.Location = new Point(19, 118);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(89, 29);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNationality.ForeColor = Color.FromArgb(46, 79, 79);
            lblNationality.Location = new Point(19, 73);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(123, 29);
            lblNationality.TabIndex = 16;
            lblNationality.Text = "Nationality:";
            // 
            // lblPB
            // 
            lblPB.AutoSize = true;
            lblPB.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPB.ForeColor = Color.FromArgb(46, 79, 79);
            lblPB.Location = new Point(17, 16);
            lblPB.Name = "lblPB";
            lblPB.Size = new Size(210, 27);
            lblPB.TabIndex = 17;
            lblPB.Text = "Personal Background:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(203, 228, 222);
            panel6.Controls.Add(lblEmployee);
            panel6.Controls.Add(lblHire);
            panel6.Controls.Add(lblEmpId);
            panel6.Controls.Add(lblHireDate);
            panel6.Location = new Point(17, 22);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(606, 128);
            panel6.TabIndex = 1;
            // 
            // lblEmployee
            // 
            lblEmployee.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmployee.ForeColor = Color.FromArgb(46, 79, 79);
            lblEmployee.Location = new Point(345, 66);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(258, 50);
            lblEmployee.TabIndex = 17;
            lblEmployee.Text = "--";
            // 
            // lblHire
            // 
            lblHire.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHire.ForeColor = Color.FromArgb(46, 79, 79);
            lblHire.Location = new Point(31, 66);
            lblHire.Name = "lblHire";
            lblHire.Size = new Size(258, 50);
            lblHire.TabIndex = 16;
            lblHire.Text = "--";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmpId.ForeColor = Color.FromArgb(46, 79, 79);
            lblEmpId.Location = new Point(331, 18);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(120, 26);
            lblEmpId.TabIndex = 15;
            lblEmpId.Text = "Employee ID:";
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHireDate.ForeColor = Color.FromArgb(46, 79, 79);
            lblHireDate.Location = new Point(18, 18);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(96, 26);
            lblHireDate.TabIndex = 14;
            lblHireDate.Text = "Hire Date:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(203, 228, 222);
            panel5.Controls.Add(showWork);
            panel5.Controls.Add(lblWorkInfo);
            panel5.Location = new Point(630, 22);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(395, 453);
            panel5.TabIndex = 0;
            // 
            // showWork
            // 
            showWork.Font = new Font("Segoe Fluent Icons", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            showWork.ForeColor = Color.FromArgb(46, 79, 79);
            showWork.Location = new Point(18, 66);
            showWork.Name = "showWork";
            showWork.Size = new Size(355, 369);
            showWork.TabIndex = 24;
            showWork.Text = "--";
            // 
            // lblWorkInfo
            // 
            lblWorkInfo.AutoSize = true;
            lblWorkInfo.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblWorkInfo.ForeColor = Color.FromArgb(46, 79, 79);
            lblWorkInfo.Location = new Point(137, 18);
            lblWorkInfo.Name = "lblWorkInfo";
            lblWorkInfo.Size = new Size(102, 27);
            lblWorkInfo.TabIndex = 16;
            lblWorkInfo.Text = "Work Info:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 79, 79);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(16, 22);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 244);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(203, 228, 222);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(12, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 214);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(46, 79, 79);
            panel4.Controls.Add(resPhone);
            panel4.Controls.Add(resEmail);
            panel4.Controls.Add(resPosition);
            panel4.Controls.Add(resName);
            panel4.Controls.Add(btnFetch);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(tbSearchEmp);
            panel4.Controls.Add(lblPhone);
            panel4.Controls.Add(lblEmail);
            panel4.Controls.Add(lblPosition);
            panel4.Controls.Add(lblName);
            panel4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel4.Location = new Point(22, 20);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(969, 179);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // resPhone
            // 
            resPhone.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resPhone.ForeColor = SystemColors.ButtonHighlight;
            resPhone.Location = new Point(157, 129);
            resPhone.Name = "resPhone";
            resPhone.Size = new Size(291, 35);
            resPhone.TabIndex = 22;
            resPhone.Text = "--";
            // 
            // resEmail
            // 
            resEmail.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resEmail.ForeColor = SystemColors.ButtonHighlight;
            resEmail.Location = new Point(157, 90);
            resEmail.Name = "resEmail";
            resEmail.Size = new Size(291, 35);
            resEmail.TabIndex = 21;
            resEmail.Text = "--";
            // 
            // resPosition
            // 
            resPosition.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resPosition.ForeColor = SystemColors.ButtonHighlight;
            resPosition.Location = new Point(157, 52);
            resPosition.Name = "resPosition";
            resPosition.Size = new Size(291, 35);
            resPosition.TabIndex = 20;
            resPosition.Text = "--";
            // 
            // resName
            // 
            resName.Font = new Font("Segoe Fluent Icons", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            resName.ForeColor = SystemColors.ButtonHighlight;
            resName.Location = new Point(157, 14);
            resName.Name = "resName";
            resName.Size = new Size(291, 35);
            resName.TabIndex = 19;
            resName.Text = "--";
            // 
            // btnFetch
            // 
            btnFetch.BackColor = Color.FromArgb(203, 228, 222);
            btnFetch.FlatStyle = FlatStyle.Popup;
            btnFetch.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFetch.ForeColor = SystemColors.ActiveCaptionText;
            btnFetch.Location = new Point(835, 14);
            btnFetch.Name = "btnFetch";
            btnFetch.Size = new Size(117, 34);
            btnFetch.TabIndex = 18;
            btnFetch.Text = "Fetch Data";
            btnFetch.UseVisualStyleBackColor = false;
            btnFetch.Click += btnFetch_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(203, 228, 222);
            label1.Location = new Point(463, 16);
            label1.Name = "label1";
            label1.Size = new Size(192, 27);
            label1.TabIndex = 17;
            label1.Text = "Search Employee ID:";
            // 
            // tbSearchEmp
            // 
            tbSearchEmp.BorderStyle = BorderStyle.None;
            tbSearchEmp.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchEmp.Location = new Point(661, 14);
            tbSearchEmp.Multiline = true;
            tbSearchEmp.Name = "tbSearchEmp";
            tbSearchEmp.Size = new Size(168, 34);
            tbSearchEmp.TabIndex = 17;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = SystemColors.ButtonHighlight;
            lblPhone.Location = new Point(21, 129);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 26);
            lblPhone.TabIndex = 16;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(21, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(136, 26);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email Address:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = SystemColors.ButtonHighlight;
            lblPosition.Location = new Point(21, 52);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(86, 26);
            lblPosition.TabIndex = 14;
            lblPosition.Text = "Position:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(21, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 26);
            lblName.TabIndex = 13;
            lblName.Text = "Name:";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 228, 222);
            ClientSize = new Size(1069, 783);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load_1;
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Label lblStatus;
        private Label lblBirthDate;
        private Label lblGender;
        private Label lblNationality;
        private Label lblPB;
        private Label lblEmpId;
        private Label lblHireDate;
        private Label lblWorkInfo;
        private Label showStatus;
        private Label showBirth;
        private Label showGender;
        private Label showNation;
        private Label lblEmployee;
        private Label lblHire;
        private Label showWork;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label resPhone;
        private Label resEmail;
        private Label resPosition;
        private Label resName;
        private Button btnFetch;
        private Label label1;
        private TextBox tbSearchEmp;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblPosition;
        private Label lblName;
    }
}
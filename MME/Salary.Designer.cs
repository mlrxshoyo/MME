namespace MME
{
    partial class Salary
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
            btnLoad = new Button();
            txtInput = new TextBox();
            label1 = new Label();
            salaryData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblID = new Label();
            lblEmp = new Label();
            lblName = new Label();
            lblSalary = new Label();
            upEmpID = new TextBox();
            upEmpSalary = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnUpdate = new Button();
            label10 = new Label();
            label11 = new Label();
            txtName = new TextBox();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)salaryData).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.FromArgb(46, 79, 79);
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.ForeColor = SystemColors.ButtonHighlight;
            btnLoad.Location = new Point(894, 43);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(147, 39);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(691, 43);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(195, 38);
            txtInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(547, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 26);
            label1.TabIndex = 2;
            label1.Text = "Employee ID:";
            // 
            // salaryData
            // 
            salaryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salaryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salaryData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            salaryData.Location = new Point(34, 108);
            salaryData.Margin = new Padding(3, 4, 3, 4);
            salaryData.Name = "salaryData";
            salaryData.ReadOnly = true;
            salaryData.RowTemplate.Height = 25;
            salaryData.Size = new Size(1007, 220);
            salaryData.TabIndex = 3;
            salaryData.CellEnter += salaryData_CellEnter_1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "Database ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "empID";
            Column2.HeaderText = "Employee ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "empName";
            Column3.HeaderText = "Employee Name";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "empSalary";
            Column4.HeaderText = "Monthly Salary";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(395, 351);
            label2.Name = "label2";
            label2.Size = new Size(253, 36);
            label2.TabIndex = 4;
            label2.Text = "Monthly Salary Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 529);
            label3.Name = "label3";
            label3.Size = new Size(136, 29);
            label3.TabIndex = 5;
            label3.Text = "Employee ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 581);
            label4.Name = "label4";
            label4.Size = new Size(172, 29);
            label4.TabIndex = 6;
            label4.Text = "Employee Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 641);
            label5.Name = "label5";
            label5.Size = new Size(163, 29);
            label5.TabIndex = 7;
            label5.Text = "Monthly Salary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 474);
            label6.Name = "label6";
            label6.Size = new Size(150, 29);
            label6.TabIndex = 8;
            label6.Text = "Entry Number:";
            // 
            // lblID
            // 
            lblID.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(243, 472);
            lblID.Name = "lblID";
            lblID.Size = new Size(327, 105);
            lblID.TabIndex = 9;
            lblID.Text = "--";
            // 
            // lblEmp
            // 
            lblEmp.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmp.Location = new Point(243, 528);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(327, 105);
            lblEmp.TabIndex = 10;
            lblEmp.Text = "--";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(243, 590);
            lblName.Name = "lblName";
            lblName.Size = new Size(327, 105);
            lblName.TabIndex = 11;
            lblName.Text = "--";
            // 
            // lblSalary
            // 
            lblSalary.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.Location = new Point(243, 651);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(327, 105);
            lblSalary.TabIndex = 12;
            lblSalary.Text = "--";
            // 
            // upEmpID
            // 
            upEmpID.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upEmpID.Location = new Point(827, 555);
            upEmpID.Margin = new Padding(3, 4, 3, 4);
            upEmpID.Multiline = true;
            upEmpID.Name = "upEmpID";
            upEmpID.Size = new Size(195, 38);
            upEmpID.TabIndex = 13;
            // 
            // upEmpSalary
            // 
            upEmpSalary.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            upEmpSalary.Location = new Point(827, 649);
            upEmpSalary.Margin = new Padding(3, 4, 3, 4);
            upEmpSalary.Multiline = true;
            upEmpSalary.Name = "upEmpSalary";
            upEmpSalary.Size = new Size(195, 38);
            upEmpSalary.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(705, 452);
            label7.Name = "label7";
            label7.Size = new Size(232, 26);
            label7.TabIndex = 15;
            label7.Text = "Update Employee's Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(593, 561);
            label8.Name = "label8";
            label8.Size = new Size(120, 26);
            label8.TabIndex = 16;
            label8.Text = "Employee ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(593, 655);
            label9.Name = "label9";
            label9.Size = new Size(185, 26);
            label9.TabIndex = 17;
            label9.Text = "Input Salary Update:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 79, 79);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(875, 694);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 39);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update Salary";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(593, 509);
            label10.Name = "label10";
            label10.Size = new Size(130, 26);
            label10.TabIndex = 19;
            label10.Text = "Entry Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(593, 608);
            label11.Name = "label11";
            label11.Size = new Size(199, 26);
            label11.TabIndex = 22;
            label11.Text = "Input Employee Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(827, 602);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 38);
            txtName.TabIndex = 21;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe Fluent Icons", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(825, 508);
            lbl.Name = "lbl";
            lbl.Size = new Size(27, 24);
            lbl.TabIndex = 23;
            lbl.Text = "ID";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 228, 222);
            ClientSize = new Size(1069, 765);
            Controls.Add(lbl);
            Controls.Add(label11);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(btnUpdate);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(upEmpSalary);
            Controls.Add(upEmpID);
            Controls.Add(lblSalary);
            Controls.Add(lblName);
            Controls.Add(lblEmp);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(salaryData);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(btnLoad);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Salary";
            Text = "Salary";
            Load += Salary_Load;
            ((System.ComponentModel.ISupportInitialize)salaryData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private TextBox txtInput;
        private Label label1;
        private DataGridView salaryData;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label lblID;
        private Label lblEmp;
        private Label lblName;
        private Label lblSalary;
        private TextBox upEmpID;
        private TextBox upEmpSalary;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnUpdate;
        private Label label10;
        private Label label11;
        private TextBox txtName;
        private Label lbl;
    }
}
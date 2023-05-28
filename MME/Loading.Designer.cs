namespace MME
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label1 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 228, 222);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(progressBar2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 429);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(564, 346);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(508, 283);
            label3.Name = "label3";
            label3.Size = new Size(66, 26);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(46, 79, 79);
            label2.Location = new Point(228, 115);
            label2.Name = "label2";
            label2.Size = new Size(141, 80);
            label2.TabIndex = 2;
            label2.Text = "Me !";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(63, 313);
            progressBar2.Margin = new Padding(3, 4, 3, 4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(557, 29);
            progressBar2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(46, 79, 79);
            label1.Location = new Point(228, 27);
            label1.Name = "label1";
            label1.Size = new Size(243, 80);
            label1.TabIndex = 0;
            label1.Text = "Manage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 451);
            label5.Name = "label5";
            label5.Size = new Size(270, 26);
            label5.TabIndex = 5;
            label5.Text = "Powered by TeamSync ⓒ 2023";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(704, 488);
            Controls.Add(label5);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label1;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}
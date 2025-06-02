namespace Dental_Clinic
{
    partial class DrBoard
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
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = SystemColors.GradientInactiveCaption;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(220, 395);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            splitter1.SplitterMoved += splitter1_SplitterMoved;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.GradientInactiveCaption;
            pictureBox1.Image = Properties.Resources.Logoo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(2, 15, 89);
            label1.Location = new Point(80, 22);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 2;
            label1.Text = "Smile with";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(2, 15, 89);
            label2.Location = new Point(80, 52);
            label2.Name = "label2";
            label2.Size = new Size(136, 38);
            label2.TabIndex = 3;
            label2.Text = "Confidence";
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 135);
            button1.Name = "button1";
            button1.Size = new Size(197, 48);
            button1.TabIndex = 4;
            button1.Text = "Patients";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 204);
            button3.Name = "button3";
            button3.Size = new Size(197, 48);
            button3.TabIndex = 6;
            button3.Text = "Appointments";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(27, 278);
            button4.Name = "button4";
            button4.Size = new Size(163, 48);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(2, 15, 89);
            label3.Location = new Point(52, 17);
            label3.Name = "label3";
            label3.Size = new Size(211, 23);
            label3.TabIndex = 8;
            label3.Text = "Upcoming Appointment:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.alarm;
            pictureBox2.Location = new Point(8, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(246, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 111);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(2, 15, 89);
            label4.Location = new Point(52, 42);
            label4.Name = "label4";
            label4.Size = new Size(261, 46);
            label4.TabIndex = 10;
            label4.Text = "Dental Cleaning on Jun 5, 2025\r\nat 2:00 PM with Dr. Ahmed Amer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(2, 15, 89);
            label5.Location = new Point(255, 51);
            label5.Name = "label5";
            label5.Size = new Size(194, 35);
            label5.TabIndex = 17;
            label5.Text = "Welcome back!";
            // 
            // DrBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(691, 395);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DrBoard";
            Text = " ";
            Load += DrBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
        private Label label5;
    }
}
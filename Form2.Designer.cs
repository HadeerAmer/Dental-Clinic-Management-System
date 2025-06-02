namespace Dental_Clinic
{
    partial class Form2
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
            linkLabel1 = new LinkLabel();
            signupButton = new Button();
            checkBox1 = new CheckBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtPass = new TextBox();
            label3 = new Label();
            txtPhoneNo = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            PatientRadioButton = new RadioButton();
            drRadioButton = new RadioButton();
            DOBPicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.ImeMode = ImeMode.NoControl;
            linkLabel1.Location = new Point(174, 578);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(223, 20);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Login!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.MidnightBlue;
            signupButton.Cursor = Cursors.Hand;
            signupButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            signupButton.ForeColor = Color.White;
            signupButton.ImeMode = ImeMode.NoControl;
            signupButton.Location = new Point(174, 515);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(223, 42);
            signupButton.TabIndex = 14;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.ForeColor = Color.MidnightBlue;
            checkBox1.ImeMode = ImeMode.NoControl;
            checkBox1.Location = new Point(393, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 27);
            txtEmail.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(54, 274);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 11;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(54, 218);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(208, 27);
            txtUsername.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(54, 195);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Design;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(174, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(317, 297);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(208, 27);
            txtPass.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(314, 274);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 18;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(314, 218);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(208, 27);
            txtPhoneNo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(314, 195);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 16;
            label4.Text = "Phone Number";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(PatientRadioButton);
            groupBox1.Controls.Add(drRadioButton);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(174, 359);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 71);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Are you Doctor or Patient?";
            // 
            // PatientRadioButton
            // 
            PatientRadioButton.AutoSize = true;
            PatientRadioButton.Cursor = Cursors.Hand;
            PatientRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientRadioButton.Location = new Point(122, 32);
            PatientRadioButton.Name = "PatientRadioButton";
            PatientRadioButton.Size = new Size(75, 24);
            PatientRadioButton.TabIndex = 1;
            PatientRadioButton.TabStop = true;
            PatientRadioButton.Text = "Patient";
            PatientRadioButton.UseVisualStyleBackColor = true;
            PatientRadioButton.CheckedChanged += PatientRadioButton_CheckedChanged;
            // 
            // drRadioButton
            // 
            drRadioButton.AutoSize = true;
            drRadioButton.Cursor = Cursors.Hand;
            drRadioButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drRadioButton.Location = new Point(18, 32);
            drRadioButton.Name = "drRadioButton";
            drRadioButton.Size = new Size(76, 24);
            drRadioButton.TabIndex = 0;
            drRadioButton.TabStop = true;
            drRadioButton.Text = "Doctor";
            drRadioButton.UseVisualStyleBackColor = true;
            drRadioButton.CheckedChanged += drRadioButton_CheckedChanged;
            // 
            // DOBPicker1
            // 
            DOBPicker1.Cursor = Cursors.Hand;
            DOBPicker1.Location = new Point(263, 31);
            DOBPicker1.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            DOBPicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            DOBPicker1.Name = "DOBPicker1";
            DOBPicker1.Size = new Size(208, 27);
            DOBPicker1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(2, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(DOBPicker1);
            panel1.Location = new Point(54, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 74);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.MidnightBlue;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(263, 8);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 23;
            label6.Text = "DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(2, 7);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 22;
            label5.Text = "Gender";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_Background;
            ClientSize = new Size(580, 626);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtPhoneNo);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(signupButton);
            Controls.Add(checkBox1);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button signupButton;
        private CheckBox checkBox1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtPhoneNo;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton PatientRadioButton;
        private RadioButton drRadioButton;
        private DateTimePicker DOBPicker1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label6;
        private Label label5;
    }
}
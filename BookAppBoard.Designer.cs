namespace Dental_Clinic
{
    partial class BookAppBoard
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
            label4 = new Label();
            button1 = new Button();
            appDateTimePicker = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            dentistComboBox = new ComboBox();
            treatmentComboBox = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            label3 = new Label();
            txtPatientName = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(2, 15, 89);
            label4.Location = new Point(97, 19);
            label4.Name = "label4";
            label4.Size = new Size(379, 82);
            label4.TabIndex = 19;
            label4.Text = "Effortless Online Booking\r\nfor Your Dental Visit";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 8.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(203, 423);
            button1.Name = "button1";
            button1.Size = new Size(68, 30);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // appDateTimePicker
            // 
            appDateTimePicker.Location = new Point(270, 279);
            appDateTimePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            appDateTimePicker.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            appDateTimePicker.Name = "appDateTimePicker";
            appDateTimePicker.Size = new Size(188, 27);
            appDateTimePicker.TabIndex = 21;
            appDateTimePicker.ValueChanged += appDateTimePicker_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(2, 15, 89);
            label5.Location = new Point(270, 251);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 22;
            label5.Text = "Date and Time:";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(2, 15, 89);
            label2.Location = new Point(270, 152);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 24;
            label2.Text = "Dentist:";
            // 
            // dentistComboBox
            // 
            dentistComboBox.FormattingEnabled = true;
            dentistComboBox.Items.AddRange(new object[] { "Dr. Ahmed Amer", "Dr. Amira", "Dr. Yamen", "Dr. Lobna" });
            dentistComboBox.Location = new Point(270, 180);
            dentistComboBox.Name = "dentistComboBox";
            dentistComboBox.Size = new Size(188, 28);
            dentistComboBox.TabIndex = 25;
            dentistComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // treatmentComboBox
            // 
            treatmentComboBox.FormattingEnabled = true;
            treatmentComboBox.Items.AddRange(new object[] { "General Dentistry", "Dental Implant", "Teeth Whitening", "Orthodontics", "Tooth Extractions", "Wisdom Teeth Removal", "Broken Tooth Repairs", "Smile Makeover", "Oral Surgery" });
            treatmentComboBox.Location = new Point(20, 279);
            treatmentComboBox.Name = "treatmentComboBox";
            treatmentComboBox.Size = new Size(188, 28);
            treatmentComboBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(2, 15, 89);
            label1.Location = new Point(20, 251);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 26;
            label1.Text = "Treatment type:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(186, 358);
            button2.Name = "button2";
            button2.Size = new Size(102, 43);
            button2.TabIndex = 30;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(2, 15, 89);
            label3.Location = new Point(20, 152);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 28;
            label3.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(20, 179);
            txtPatientName.Multiline = true;
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(188, 28);
            txtPatientName.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.appointment;
            pictureBox1.Location = new Point(20, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // BookAppBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(481, 470);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(txtPatientName);
            Controls.Add(label3);
            Controls.Add(treatmentComboBox);
            Controls.Add(label1);
            Controls.Add(dentistComboBox);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(appDateTimePicker);
            Controls.Add(button1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookAppBoard";
            Text = "BookAppBoard";
            Load += BookAppBoard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private DateTimePicker appDateTimePicker;
        private Label label5;
        private Label label2;
        private ComboBox dentistComboBox;
        private ComboBox treatmentComboBox;
        private Label label1;
        private Button button2;
        private Label label3;
        private TextBox txtPatientName;
        private PictureBox pictureBox1;
    }
}
namespace Dental_Clinic
{
    partial class DrsPatients
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
            button1 = new Button();
            patientsDataGridView = new DataGridView();
            button2 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 8.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(91, 377);
            button1.Name = "button1";
            button1.Size = new Size(68, 30);
            button1.TabIndex = 21;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.BackgroundColor = Color.AliceBlue;
            patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsDataGridView.Location = new Point(50, 100);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 51;
            patientsDataGridView.Size = new Size(469, 243);
            patientsDataGridView.TabIndex = 22;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(413, 377);
            button2.Name = "button2";
            button2.Size = new Size(68, 30);
            button2.TabIndex = 23;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(2, 15, 89);
            label5.Location = new Point(50, 34);
            label5.Name = "label5";
            label5.Size = new Size(157, 35);
            label5.TabIndex = 24;
            label5.Text = "All patients:";
            // 
            // DrsPatients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(570, 446);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(patientsDataGridView);
            Controls.Add(button1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DrsPatients";
            Text = "Drs Patients";
            Load += DrsPatients_Load;
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView patientsDataGridView;
        private Button button2;
        private Label label5;
    }
}
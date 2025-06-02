using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic
{
    public partial class DrsPatients : Form
    {
        public DrsPatients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrBoard drBoard = new DrBoard();
            drBoard.Show();
            this.Hide();
        }

        private void DrsPatients_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinicDB;Integrated Security=True;";
            string query = "SELECT * FROM PatientsTable";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    // Clear existing data source first
                    patientsDataGridView.DataSource = null;

                    // Set the data source
                    patientsDataGridView.DataSource = dt;

                    // Force refresh and update
                    patientsDataGridView.Refresh();
                    patientsDataGridView.Update();

                    // Auto-resize columns to fit content
                    patientsDataGridView.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message);
                }
            }
        }

        public void RefreshPatientData()
        {
            DrsPatients_Load(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPatientInfo addPatientInfo = new AddPatientInfo();
            addPatientInfo.Show();
        }
    }
}

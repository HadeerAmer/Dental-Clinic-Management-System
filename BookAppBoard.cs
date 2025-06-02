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
    public partial class BookAppBoard : Form
    {
        public BookAppBoard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Patient = txtPatientName.Text;
            string? Doctor = dentistComboBox.SelectedItem?.ToString();
            string? Treatment = treatmentComboBox.SelectedItem?.ToString();
            DateTime Date = appDateTimePicker.Value;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinicDB;Integrated Security=True;";
            string query = "INSERT INTO AppointmentsTable (Patient, Doctor, Treatment, Date) " +
                           "VALUES (@Patient, @Doctor, @Treatment, @Date)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Patient", Patient);
                cmd.Parameters.AddWithValue("@Doctor", Doctor);
                cmd.Parameters.AddWithValue("@Treatment", Treatment);
                cmd.Parameters.AddWithValue("@Date", Date);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment booked successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error booking appointment: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientBoard patientBoard = new PatientBoard();
            patientBoard.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BookAppBoard_Load(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void appDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
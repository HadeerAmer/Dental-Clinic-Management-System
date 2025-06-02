using System.Data.SqlClient;

namespace Dental_Clinic
{
    public partial class AddPatientInfo : Form
    {
        public AddPatientInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string gender = comboBox1.Text;
            DateTime? dob = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(gender) || dob == null)
            {
                MessageBox.Show("Please fill all the required fields", "Failed to add patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=DentalClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "INSERT INTO PatientsTable (Name, Phone, Gender, DOB) " +
                           "VALUES (@Name, @Phone, @Gender, @DOB)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dob);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the parent form's DataGridView
                            if (this.Owner is DrsPatients parentForm)
                            {
                                parentForm.RefreshPatientData();
                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add patient. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occurred while adding the patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful addition
            }
        }

        private void AddPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

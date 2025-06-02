using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dental_Clinic
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            
            // Input collection
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text;
            string phoneNo = txtPhoneNo.Text.Trim();
            string userType = PatientRadioButton.Checked ? "Patient" : "Doctor";


            string connectionString = "Server=localhost\\SQLEXPRESS;Database=DentalClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

            // Input validation BEFORE saving
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phoneNo))
            {
                MessageBox.Show("Please fill all the required fields", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string genderr = "";
            DateTime? doob = null;

            if (userType == "Patient")
            {
                string name = txtUsername.Text;
                string phone = txtPhoneNo.Text;
                string gender = comboBox1.Text;
                DateTime? dob = DOBPicker1.Value.Date;

                if (string.IsNullOrEmpty(name) ||
                    string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(gender) || 
                    dob == null)
                {
                    MessageBox.Show("Please fill all the required fields", "Failed to add patient", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                    // MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after successful addition
                }


                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a gender.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                genderr = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                doob = DOBPicker1.Value.Date;
            }

            string query1 = "INSERT INTO UsersTable (Username, Password, Email, PhoneNumber, UserType, Genderr, DateOfBirth) " +
                           "VALUES (@Username, @Password, @Email, @Phone, @UserType, @Genderr, @DateOfBirth)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phoneNo);
                        cmd.Parameters.AddWithValue("@UserType", userType);
                        cmd.Parameters.AddWithValue("@Genderr", (object?)genderr ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateOfBirth", (object?)doob ?? DBNull.Value);

                        // Open connection and run
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK);
                            Form1 login = new Form1();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void PatientRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PatientRadioButton.Checked)
            {
                panel1.Enabled = true;
            }
        }

        private void drRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (drRadioButton.Checked)
            {
                panel1.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

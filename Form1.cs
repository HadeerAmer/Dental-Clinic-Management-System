using System.Data.SqlClient;

namespace Dental_Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinicDB;Integrated Security=True;";

            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all the fields", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT UserType FROM UsersTable WHERE Email = @Email AND Password = @Password";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();
                        string userType = (string)cmd.ExecuteScalar();
                        if (userType != null)
                        {
                            if (userType == "Patient")
                            {
                                PatientBoard patientBoard = new PatientBoard();
                                patientBoard.Show();
                            }
                            else if (userType == "Doctor")
                            {
                                DrBoard drBoard = new DrBoard();
                                drBoard.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 sign = new Form2();
            sign.Show();
            this.Hide();
        }
    }
}

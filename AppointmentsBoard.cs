using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic
{
    public partial class AppointmentsBoard : Form
    {
        public AppointmentsBoard()
        {
            InitializeComponent();
        }

        private void AppointmentsBoard_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DentalClinicDB;Integrated Security=True;";
            string query = "SELECT * FROM AppointmentsTable";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    // To clear existing data source first
                    dataGridView1.DataSource = null;

                    // To set the data source
                    dataGridView1.DataSource = dt;

                    // To force refresh and update
                    dataGridView1.Refresh();
                    dataGridView1.Update();

                    // Auto-resize columns to fit content
                    dataGridView1.AutoResizeColumns();

                    //MessageBox.Show($"Records found: {dt.Rows.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading appointments: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DrBoard drBoard = new DrBoard();
            drBoard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

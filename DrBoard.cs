namespace Dental_Clinic
{
    public partial class DrBoard : Form
    {
        public DrBoard()
        {
            InitializeComponent();
        }

        private void DrBoard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentsBoard appointmentsBoard = new AppointmentsBoard();
            appointmentsBoard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrsPatients drsPatients = new DrsPatients();
            drsPatients.Show();
            this.Hide();
        }
    }
}

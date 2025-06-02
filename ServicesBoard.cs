using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic
{
    public partial class ServicesBoard : Form
    {
        public ServicesBoard()
        {
            InitializeComponent();
        }

        private void ServicesBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientBoard patientBoard = new PatientBoard();
            patientBoard.Show();
            this.Hide();
        }
    }
}

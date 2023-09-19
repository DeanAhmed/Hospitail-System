using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamienHospitalAssignment
{
    public partial class DataGrid : Form
    {
       public List<Doctor> DoctorList = new List<Doctor>();
        public List<Nurse> NurseList = new List<Nurse>();
        public List<PartTime> PartTimeList = new List<PartTime>();
        internal List<Patient> PatientList = new List<Patient>();

        public DataGrid()
        {
            InitializeComponent();
        }
        private void btnSDoc_Click(object sender, EventArgs e)
        {
            dgv.DataSource = true;
            dgv.DataSource = DoctorList;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = true;
            dgv.DataSource = NurseList;
        }

        private void btnPartTime_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = PartTimeList;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = PatientList;
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}

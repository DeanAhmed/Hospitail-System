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
    public partial class Form1 : Form
    {

        DataGrid dgv = new DataGrid();
       
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm(dgv, this);
            emp.Show();
            //EmployeeForm emp = new EmployeeForm(dgv, this); 
            //emp.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientForm pati = new PatientForm(dgv, this);
            pati.Show();
            //PatientForm pati = new PatientForm(dgv, this); 
            //pati.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm(dgv, this);
            emp.Show();
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            PatientForm pati = new PatientForm(dgv, this);
            pati.Show();
        }
    }
}

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
    public partial class EmployeeForm : Form
    {
        DataGrid dgv;
        Form f;

        public EmployeeForm(DataGrid dg, Form form)
        {
            InitializeComponent();

            dgv = dg;
            f = form;

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgv.Show();
        }

        private void rdoDoc_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Enabled = false;
            txtSalary.Enabled = false;
            lblhours.Enabled = false;
            txtHours.Enabled = false;
            lblspeci.Enabled = true;
            cbospeci.Enabled = true;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            cboCy.DataSource = Enum.GetValues(typeof(Counties));
            cbospeci.DataSource = Enum.GetValues(typeof(Speciality));
        }

        private void rdoNur_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Enabled = true;
            txtSalary.Enabled = true;
            lblhours.Enabled = false;
            txtHours.Enabled = false;
            lblspeci.Enabled = false;
            cbospeci.Enabled = false;
        }

        private void rdoPT_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Enabled = false;
            txtSalary.Enabled = false;
            lblhours.Enabled = true;
            txtHours.Enabled = true;
            lblspeci.Enabled = false;
            cbospeci.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            double age = double.Parse(txtage.Text);
            string addr = txtaddr.Text;
            string cy = cboCy.SelectedItem.ToString();
            double ph = double.Parse(txtPh.Text);
            string email = txtemail.Text;
            double empId = double.Parse(txtempid.Text);
            string speci = cbospeci.SelectedItem.ToString();
            double salary = 0;
            double hours = 0;
            
            if (rdoDoc.Checked)
            { 
                Doctor doctor = new Doctor(name, age, addr, cy, ph, email, empId, speci);
                dgv.DoctorList.Add(doctor);
                txtname.Clear();
                txtage.Clear();
                txtaddr.Clear();
                txtPh.Clear();
                txtemail.Clear();
                txtempid.Clear();
            }
            else if (rdoNur.Checked)
            {
                salary = double.Parse(txtSalary.Text);

                Nurse nurse = new Nurse(name, age, addr, cy, ph, email, empId, salary);
                dgv.NurseList.Add(nurse);
                txtname.Clear();
                txtage.Clear();
                txtaddr.Clear();
                txtPh.Clear();
                txtemail.Clear();
                txtempid.Clear();
                txtSalary.Clear();
            }
            else if (rdoPT.Checked)
            {
                hours = double.Parse(txtHours.Text);

                PartTime pt = new PartTime(name, age, addr, cy, ph, email, empId, hours);
                dgv.PartTimeList.Add(pt);
                txtname.Clear();
                txtage.Clear();
                txtaddr.Clear();
                txtPh.Clear();
                txtemail.Clear();
                txtempid.Clear();
                txtHours.Clear();
            }
        }

        private void grpboxPatientForm_Enter(object sender, EventArgs e)
        {

        }
    }
}

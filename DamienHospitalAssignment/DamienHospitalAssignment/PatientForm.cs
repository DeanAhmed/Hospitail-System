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
    public partial class PatientForm : Form
    {
        DataGrid dgv;
        Form f;

        public PatientForm(DataGrid dg, Form form)
        {
            InitializeComponent();

            dgv = dg;
            f = form;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            cboCy.DataSource = Enum.GetValues(typeof(Counties));
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            f.BringToFront();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgv.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            double age = double.Parse(txtage.Text);
            string addr = txtaddr.Text;
            string cy = cboCy.SelectedItem.ToString();
            double ph = double.Parse(txtPh.Text);
            string email = txtemail.Text;
            double totalb = double.Parse(txttotbill.Text);
         
            DataGrid dg = new DataGrid();

            Patient pati = new Patient(name, age, addr, cy, ph, email, totalb);
            dg.PatientList.Add(pati);
            txtname.Clear();
            txtage.Clear();
            txtaddr.Clear();
            txtPh.Clear();
            txtemail.Clear();
            txttotbill.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
    class Patient : Person
    {
        public double TotalBill { get; set; }
        public Patient(string name, double age, string addr, string cy, double ph, string email, double totalb)
            : base(name, age, addr, cy, ph, email)
        {
            TotalBill = totalb;
        }
    }
}

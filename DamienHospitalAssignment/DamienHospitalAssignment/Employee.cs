using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
   public class Employee : Person
    {
        public double Employeeid { get; set; }

        public Employee(string name, double age, string addr, string cy, double ph, string email, double id)
            :base(name, age, addr, cy, ph, email)
        {
            Employeeid = id;
        }
    }
}

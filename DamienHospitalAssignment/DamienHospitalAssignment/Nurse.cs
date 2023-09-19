using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
    public class Nurse : Employee
    {
        public double Salary { get; set; }

        public Nurse(string name, double age, string addr, string cy, double ph, string email, double id, double salary)
            :base(name, age, addr, cy, ph, email, id)
        {
            Salary = salary;
        }
    }
}

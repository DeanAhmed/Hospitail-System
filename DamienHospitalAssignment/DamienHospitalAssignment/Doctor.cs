using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
    public class Doctor : Employee
    {
        public string Speciality { get; set; }
        public Doctor(string name, double age, string addr, string cy, double ph, string email, double id, string speci)
            : base(name, age, addr, cy, ph, email, id)
            {
                Speciality = speci;
            }
    }
}

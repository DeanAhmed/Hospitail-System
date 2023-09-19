using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
    public class PartTime : Employee
    {
        public double numbofHours { get; set; }
        public PartTime(string name, double age, string addr, string cy, double ph, string email, double id, double numHrs)
            : base(name, age, addr, cy, ph, email, id)
        {
            numbofHours = numHrs;
        }
    }
}

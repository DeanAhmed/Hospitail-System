using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamienHospitalAssignment
{
    public class Person
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public double Phone { get; set; }
        public string Email { get; set; }

        public Person(string name, double age, string addr, string cy, double ph, string email)
        {
            Name = name;
            Age = age;
            Address = addr;
            County = cy;
            Phone = ph;
            Email = email;
        }







    }
}

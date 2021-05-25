using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public abstract class Department
    {
        public Chief Chief { get; }
        public List<Person> Staff { get; set; }

        public Department()
        {
        }

        public Department(Chief chief, List<Person> staff)
        {
            Chief = chief;
            Staff = staff;
        }
    }
}

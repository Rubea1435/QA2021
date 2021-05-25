using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class Docent : Teacher
    {
        public Docent()
        {
        }

        public Docent(string firstName, string lastName, List<Course> courses) : base(firstName, lastName, courses)
        {
        }
    }
}

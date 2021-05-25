using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class Professor : Teacher
    {
        public Professor() : base()
        {
        }

        public Professor(string firstName, string lastName, List<Course> courses) : base(firstName, lastName, courses)
        {
            FirstName = "Mr. " + FirstName;
        }
    }
}

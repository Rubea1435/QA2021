using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class Teacher : Person
    {
        public List<Course> Courses { get; set; }

        public Teacher() : base()
        {
        }

        public Teacher(string firstName, string lastName, List<Course> courses) : base(firstName, lastName)
        {
            Courses = courses;
        }
    }
}

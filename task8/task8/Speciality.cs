using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    [Serializable]
    public class Speciality
    {
        public SpecialityName Name { get; set; }
        public List<Course> Courses { get; set; }

        public Speciality(SpecialityName name, List<Course> courses)
        {
            Name = name;
            Courses = courses;
        }

        public Speciality()
        {
        }
    }
}

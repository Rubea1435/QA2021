using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    [Serializable]
    public class Course
    {
        public CourseName Name { get; set; }

        public Course(CourseName name)
        {
            Name = name;
        }

        public Course()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class Student : Person
    {
        public int IDnumber { get; set; }
        public List<Speciality> Specialities { get; set; }

        public Student() : base()
        {
        }

        public Student(string firstName, string lastName, int id, List<Speciality> specs) : base(firstName, lastName)
        {
            IDnumber = id;
            Specialities = specs;
        }
    }
}

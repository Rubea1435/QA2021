using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class University
    {
        public Administration Administration { get; }
        public Maintenance Maintenance { get; }
        public ResearchDepartment ResearchDepartment { get; }
        public Security Security { get; }
        public List<Faculty> Faculties { get; set; }   

        public University(List<Faculty> facs)
        {
            Faculties = facs;
        }

        public List<Professor> GetProfessorsReadingMoreThanSeveralCourses(int howMany)
        {
            var ListofListStaff = Faculties.Select(x => x.Staff).ToList();
            List<Person> Staff = new List<Person>();
            foreach (List<Person> staff in ListofListStaff)
                foreach (Person pers in staff)
                    Staff.Add(pers);

            var x1 = Staff.Select(x => x as Professor);
            var x2 = x1.Where(x => x.Courses.Count > howMany);
            var x3 = x2.ToList();
            return x3;
            //return Staff.Select(x => x as Professor).Where(x => x.Courses.Count > howMany).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    [Serializable]
    public class Faculty : Department
    {
        public List<Student> Students { get; set; }
        public List<Speciality> Specialities { get; set; }
        public List<Course> Courses { get; set; }

        public Faculty() : base()
        {
        }
        public Faculty(Chief chief, List<Person> staff, List<Student> studs, List<Speciality> specs, List<Course> courses) : base(chief, staff)
        {
            Students = studs;
            Specialities = specs;
            Courses = courses;
        }

        public List<Student> GetStudentsBySpeciality(Speciality spec)
        {
            return Students.Where(x => x.Specialities.Contains(spec)).ToList();
        }

        public List<Student> GetStudentsByCourse(Course course)
        {
            return Students.Where(x => x.Specialities.Intersect(x.Specialities.Where(y => y.Courses.Contains(course))).Count() == 1).ToList();
        }

        public List<Professor> GetProfessorsReadingMoreThanSeveralCourses(int howMany)
        {
            return Staff.Select(x => x as Professor).Where(x => x.Courses.Count > howMany).ToList();
        }
        /*public List<Course> GetCoursesListenedOnMoreThanSeveralSpecialities(int howMany)
        {
            var xex = Specialities.Select(x => x.Courses).Distinct().ToList();
            return Specialities.Select(x => x.Courses).Except(xex).ToList();
        }*/
    }
}

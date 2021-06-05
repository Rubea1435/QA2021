using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathStudents = "D:/ТехПрог/QA/task8/task8/XMLStudents.xml";
            string filePathCourses = "D:/ТехПрог/QA/task8/task8/XMLCourses.xml";
            string filePathSpecialities = "D:/ТехПрог/QA/task8/task8/XMLSpecialities.xml";
            string filePathProfessors = "D:/ТехПрог/QA/task8/task8/XMLProfessors.xml";
            string filePathDocents = "D:/ТехПрог/QA/task8/task8/XMLDocents.xml";

            var studBuilder = new ListBuilder<Student>();
            List<Student> students = studBuilder.Create(filePathStudents);
            /*foreach (Student stud in students)
                foreach (Speciality spec in stud.Specialities)
                    foreach (Course cour in spec.Courses)
                        Console.WriteLine(cour.Name);*/

            var courseBuilder = new ListBuilder<Course>();
            List<Course> courses = courseBuilder.Create(filePathCourses);

            var professorBuilder = new ListBuilder<Professor>();
            List <Professor> professors = professorBuilder.Create(filePathProfessors);

            var specialityBuilder = new ListBuilder<Speciality>();
            List<Speciality> specialities = specialityBuilder.Create(filePathSpecialities);

            var docentBuilder = new ListBuilder<Docent>();
            List <Docent> docents = docentBuilder.Create(filePathDocents);
            List<Person> staff = new List<Person>();
            foreach (Professor prof in professors)
                staff.Add(prof);
            foreach (Docent doc in docents)
                staff.Add(doc);

            Faculty RFiKT = new Faculty(new Chief("SV", "Malyj"), staff, students, specialities, courses);
            var faculties = new List<Faculty> { RFiKT };

            University BSU = new University(faculties);
            //List<Professor> profsMoreOneCourse = RFiKT.GetProfessorsReadingMoreThanSeveralCourses(1);
            List<Student> studsKB = RFiKT.GetStudentsBySpeciality(specialities[0]);
            foreach (Student stud in studsKB)
                Console.WriteLine(stud.FirstName);

            /*Course course1 = new Course(CourseName.Matanalysis);
            Course course2 = new Course(CourseName.TheoryOfInformation);
            Course course3 = new Course(CourseName.Physics);
            List<Course> courseL = new List<Course> { course1, course2 };

            Speciality spec1 = new Speciality(SpecialityName.ComputerSecurity, courseL);
            Speciality spec2 = new Speciality(SpecialityName.PhysicalElectronics, courseL);
            List<Speciality> specL = new List<Speciality> { spec1 };

            Professor prof1 = new Professor("Kislyh", "Schey", courseL);
            Professor prof2 = new Professor("Lopuh", "Apparatura", courseL);
            Docent doc1 = new Docent("Dzhentljmen", "Udachi", courseL);
            List<Professor> profL = new List<Professor> { prof1, prof2 };
            List<Docent> docL = new List<Docent> { doc1 };
            List<Teacher> teachL = new List<Teacher> { prof1, prof2, doc1 };

            Student stud1 = new Student("Nasteo", "Cheger", 1821269, specL);
            Student stud2 = new Student("Rubea", "Pardo", 1435, specL);*/

            /*foreach (Speciality spec in specialities)
                foreach (Course course in spec.Courses)
                    Console.WriteLine(course.Name);*/


            /*XmlSerializer formatter = new XmlSerializer(typeof(List<Faculty>));
            using (FileStream fs = new FileStream("facs.xml", FileMode.Create))
            {
                formatter.Serialize(fs, facL);
            }*/
        }
    }
}

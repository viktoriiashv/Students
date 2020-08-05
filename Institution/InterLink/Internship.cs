using System.Collections.Generic;
using InternshipTest.Person;
namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string name;
        List<Student> selectedStudents = new List<Student>();
        public Internship(string name)
        {
            this.name = name;
        }

        public string GetStudents()
        {
            string studentsString = "";

            foreach (Student student in selectedStudents)
            {
                studentsString += student.Name + "\n";
            }

            return studentsString;
        }

        public void SelectStudents(University university)
        {
            int averageKnowledge = university.GetAverageKnowledge();
            foreach(Student student in university.Students)
            {
                if(student.Knowledge.Level > averageKnowledge)
                {
                    selectedStudents.Add(student);
                }
            }
        }
    }
}

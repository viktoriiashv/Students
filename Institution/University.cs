using InternshipTest.Person;
using System;
using System.Collections.Generic;
namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        List<Student> students = new List<Student>();
        public University(string name)
        {
            this.name = name;
        }

        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public int GetAverageKnowledge()
        {
            int averageKnowledge = 0;
            if (students.Count == 0)
            {
                Console.WriteLine("There is no students in university.");
            }
            else
            {
                foreach (Student student in students)
                {
                    averageKnowledge += student.Knowledge.Level;
                }
                averageKnowledge /= students.Count;
            }
            return averageKnowledge;
        }
    }
}

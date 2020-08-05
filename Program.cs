using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            s.SetKnowledge(new Knowledge(5));
            University university = new University("CH.U.I.");
            University universityWithoutStudents = new University("Sad university");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(5)));
            university.AddStudent(new Student("Julia Veselkina", new Knowledge(4)));
            university.AddStudent(new Student("Maria Perechrest", new Knowledge(3)));
            university.AddStudent(new Student("Roma Danilyk", new Knowledge(4)));
            university.AddStudent(new Student("Oleg Pilipenko", new Knowledge(3)));
            university.AddStudent(s);
            Internship internship = new Internship("Interlink");
            internship.SelectStudents(university);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());

            Console.WriteLine(universityWithoutStudents.GetAverageKnowledge());
        }
    }
}

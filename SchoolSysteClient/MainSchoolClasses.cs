//Problem 1. School classes• We are given a  school . In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//• Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
//define the class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolClasses;

namespace SchoolSysteClient
{
    class MainSchoolClasses
    {
        static void Main()
        {
            School plovdiv = new School("School Baro");
            Classes class12a = new Classes("Class 12a");
            Classes class11b = new Classes("Class 11b");
            plovdiv.AddClasses(class12a);
            plovdiv.AddClasses(class11b);
            Console.WriteLine(plovdiv.SchoolName);
            foreach (var item in plovdiv.ClassesofStudents)
            {
                Console.WriteLine(item);
            }
            class12a.AddSrtudents(new Students("Ivan", "Ivanov", 200032));
            class12a.AddSrtudents(new Students("Asen", "Borat", 500232));
            foreach (var item in class12a.SetStudents)
            {
                Console.WriteLine(item);
            }
            List<Disciplines> listDisciplines = new List<Disciplines>();
            listDisciplines.Add(new Disciplines("Math",20,15));
            listDisciplines.Add(new Disciplines("Literature",12,5));
            class11b.AddTeachers(new Teachers("Inj.Jivko", "Gospodinov",listDisciplines));
            class11b.AddTeachers(new Teachers("Inj.Ho", "Gov", listDisciplines));
            foreach (var teacher in class11b.SetTeachers)
            {
                Console.WriteLine(teacher);
                foreach (var item in listDisciplines)
                {
                    Console.WriteLine(item);
                }
            }
            class11b.Comment = "Peace, no war";
            Console.WriteLine(class11b.Comment);

           

        }
        public static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

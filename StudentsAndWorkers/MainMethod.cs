//Problem 2. Students and workers
//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    class MainMethod
    {
        static void Main()
        {
            Console.BufferHeight = Console.BufferHeight = 100;
            var listStudents = new List<Student>()
            {
                new Student("Asen","Nikolov",4.60),
                new Student("Ivan","Dimitrov",3.30),
                new Student("Gosho","Simov",2.50),
                new Student("Mitko","Donchev",5.25),
                new Student("Nedqlko","Georgiev",5.34),
                new Student("Antonia","Ivanova",2.57),
                new Student("Geori","Nikolova",3.45),
                new Student("Georgi","Toshkov",4.18),
                new Student("Jivko","Stamenov",3.17),
                new Student("Diliana","Peeva",4.78)
            };
            var sortByGrade =
                from students in listStudents
                orderby students.Grade
                select students;
            PrintCollection(sortByGrade);

            Console.WriteLine();
            var sortByGrade1 = listStudents.OrderBy(x => x.Grade);
            PrintCollection(sortByGrade1);

            Console.WriteLine();
            var listWorkers = new List<Worker>()
            {
                new Worker("Kalin","Tropchev",300m,5),
                new Worker("Emiliq","Ivanova",450m,6),
                new Worker("Jivka","Simova",230m,5),
                new Worker("Dimi","Zlatarov",250m,5),
                new Worker("Nasko","Ganushev",286m,4),
                new Worker("Dian","Petkov",297m,3),
                new Worker("Todor","Pendev",380m,2),
                new Worker("Prandar","Toshkov",345m,4),
                new Worker("Denis","Grigorov",120m,4),
                new Worker("Delqn","Peevski",150m,8)
            };
            var sortWorkersByMoney =
                from workers in listWorkers
                orderby workers.MoneyPerHour() descending
                select workers;
            
            var sortWorkersByMoney1 = listWorkers.OrderByDescending(x => x.MoneyPerHour());
            PrintCollection(sortWorkersByMoney);
            Console.WriteLine();
            PrintCollection(sortWorkersByMoney1);
                       
            Console.WriteLine();
            var mergeAddRange = new List<Human>();
            mergeAddRange.AddRange(listStudents);
            mergeAddRange.AddRange(listWorkers);
            PrintCollection(mergeAddRange.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName));

            Console.WriteLine();
            var mergeConcat = listStudents.Concat<Human>(listWorkers).OrderBy(x=> x.FirstName).ThenBy(x=> x.LastName);
            PrintCollection(mergeConcat);
            
        }
        private static void PrintCollection(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

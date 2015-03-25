//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalHierarchy
{
    class MainMethod
    {
        static void Main()
        {
            Dog[] myDogs = 
            {
                new Dog("Sharo",Gender.Male,3),
                new Dog("Rex",Gender.Male,7),
                new Dog("Nana",Gender.Female,2)
            };
            PrintCollection(myDogs);
            Console.Write("Dogs sound:");
            myDogs[0].Sound();
            Console.WriteLine("Average age:{0:0.00}",Animals.AverageAge(myDogs));
            Console.WriteLine();   
            
            Frog[] myFrogs = 
            {
                new Frog("Green",Gender.Male,2),
                new Frog("Pison",Gender.Female,3),
                new Frog("Yellow",Gender.Female,2)
            };
            PrintCollection(myFrogs);
            Console.Write("Frog sound:");
            myFrogs[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myFrogs));
            Console.WriteLine();

            Cat[] myCats = 
            {
                new Cat("Muci",Gender.Female,4),
                new Cat("Guci",Gender.Male,5),
                new Cat("Nini",Gender.Female,7)
            };
            PrintCollection(myCats);
            Console.Write("Cat sound:");
            myCats[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myCats));
            Console.WriteLine();

            Kitten[] myKittens = 
            {
                new Kitten("Kitt",1),
                new Kitten("Kuti",1),
                new Kitten("Kati",2)
            };
            PrintCollection(myKittens);
            Console.Write("Kittens sound:");
            myKittens[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myKittens));
            Console.WriteLine();

            Tomcats[] myTomcats = 
            {
                new Tomcats("Zoro",4),
                new Tomcats("Toro",3),
                new Tomcats("Goro",4)
            };
            PrintCollection(myTomcats);
            Console.Write("Kittens sound:");
            myTomcats[0].Sound();
            Console.WriteLine("Average age:{0:0.00}", Animals.AverageAge(myTomcats));
            Console.WriteLine();
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

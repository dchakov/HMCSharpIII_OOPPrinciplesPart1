using System;

namespace AnimalHierarchy
{
    public class Dog : Animals
    {
        public Dog(string name, Gender gender, int age)
            : base(name, gender, age)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Bauuuuu");
        }
        public override string ToString()
        {
            return this.Name + " " + this.Gender + " " + this.Age;
        }
        
    }
}

using System;

namespace AnimalHierarchy
{
    public class Cat : Animals
    {
        public Cat(string name, Gender gender, int age)
            : base(name, gender, age)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Miauuu");
        }
        public override string ToString()
        {
            return this.Name + " " + this.Gender + " " + this.Age;
        }
    }
}

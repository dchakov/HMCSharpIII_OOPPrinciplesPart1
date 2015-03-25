using System;

namespace AnimalHierarchy
{
    public class Frog : Animals
    {
        public Frog(string name, Gender gender, int age)
            : base(name, gender, age)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Qwak,Qwak,Qwak");
        }
        public override string ToString()
        {
            return this.Name + " " + this.Gender + " " + this.Age;
        }
    }
}

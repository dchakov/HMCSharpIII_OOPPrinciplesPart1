using System;

namespace AnimalHierarchy
{
    public class Kitten:Cat
    {
        public Kitten(string name, int age)
            : base(name,Gender.Female, age)
        {
        }
    }
}

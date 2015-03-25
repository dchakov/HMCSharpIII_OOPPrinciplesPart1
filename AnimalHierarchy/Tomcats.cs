using System;

namespace AnimalHierarchy
{
    public class Tomcats:Cat
    {
        public Tomcats(string name, int age)
            : base(name, Gender.Male, age)
        { 
        }
    }
}

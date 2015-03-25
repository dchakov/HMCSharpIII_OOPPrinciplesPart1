using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Grade must be positive");
                }
                this.grade = value;
            }
        }

        public Student(string firstName,string lastName,double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:0.00}",this.FirstName,this.LastName,this.Grade);
        }
    }
}

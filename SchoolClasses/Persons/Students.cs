using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Students:Person,IComment
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Class number must be positive");
                }
                this.classNumber = value;
            }
        }
        public Students(string firstName,string secondName,int classNumber)
            :base(firstName,secondName)
        {
            this.ClassNumber = classNumber;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FirstName, this.LastName,this.ClassNumber);
        }
        public string Comment { get; set; }
    }
}

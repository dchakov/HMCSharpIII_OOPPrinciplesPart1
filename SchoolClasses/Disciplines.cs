using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Disciplines:IComment
    {
        private string disciplinesName;
        private int numberOfLectures;
        private int numberOfExercises;

        public string DisciplinesName
        {
            get
            {
                return this.disciplinesName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline cannot be null or empty");
                }
                this.disciplinesName = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be null or negative");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be null or negative");
                }
                this.numberOfExercises = value;
            }
        }
        public Disciplines(string disciplinesName,int numberOfLectures,int numberOfExercises )
        {
            this.DisciplinesName = disciplinesName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}",this.DisciplinesName,this.NumberOfLectures,this.NumberOfExercises);
        }

        public string Comment { get; set; }
       
    }
}
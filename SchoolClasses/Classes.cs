using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Classes:IComment
    {
        private string textIdentifier;
        private List<Teachers> setTeachers = new List<Teachers>();
        private List<Students> setStudents = new List<Students>();
        private string comment;
                
        public string TextIdentifier
        {
            get { return this.textIdentifier; }
            set { this.textIdentifier = value; }
        }
        public List<Teachers> SetTeachers
        {
            get { return this.setTeachers; }
        }
        public List<Students> SetStudents
        {
            get { return this.setStudents; }
        }

        public Classes(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.setTeachers = new List<Teachers>();
            this.setStudents = new List<Students>();
        }

        public void AddTeachers(Teachers teacher)
        {
            this.setTeachers.Add(teacher);
        }
        public void AddSrtudents(Students student)
        {
            this.setStudents.Add(student);
        }

        
        public override string ToString()
        {
            return this.TextIdentifier;
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}

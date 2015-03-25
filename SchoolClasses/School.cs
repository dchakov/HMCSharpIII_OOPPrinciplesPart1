using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class School
    {
        private List<Classes> classesOfStudents;
        private string schoolName;

        public List<Classes> ClassesofStudents
        {
            get { return this.classesOfStudents; }
        }
        public string SchoolName
        {
            get { return this.schoolName; }
            set { this.schoolName = value; }
        }

        public School(string name)
        {
            this.SchoolName = name;
            this.classesOfStudents = new List<Classes>();
        }
        public void AddClasses(Classes classes)
        {
            this.classesOfStudents.Add(classes);
        }
        public void RemoveClasses(Classes classes)
        {
            this.classesOfStudents.Add(classes);
        }
        public override string ToString()
        {
            return this.schoolName;
        }
    }
}

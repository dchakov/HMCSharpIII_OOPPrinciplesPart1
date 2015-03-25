using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolClasses
{
    public class Teachers:Person,IComment
    {
        private List<Disciplines> setDisciplines;

        public List<Disciplines> SetDisciplines
        {
            get
            {
                return new List<Disciplines>(this.setDisciplines);
            }
            
        }
        public void AddDisciplines(Disciplines set)
        {
            this.setDisciplines.Add(set);
        }
        public void RemoveDiscipline(Disciplines set)
        {
            this.setDisciplines.Remove(set);
        }
        public Teachers(string firstName,string lastName,List<Disciplines> setdiscipline)
            :base(firstName,lastName)
        {
            this.setDisciplines = new List<Disciplines>();

        }
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

        public string Comment { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker:Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Salary must be positive");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Work hours must be positive");
                }
                this.workHoursPerDay = value;
            }
        }
        public Worker(string firstName, string lastName, decimal weekSalary, int workHour)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHour;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5m*WorkHoursPerDay);
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",this.FirstName,this.LastName,this.WeekSalary,this.WorkHoursPerDay);
        }
    }
}

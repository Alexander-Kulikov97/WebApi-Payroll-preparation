using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Driver : IEmployee
    {
        private decimal Salary { get; set; }

        private decimal Bonus { get; set; }

        private int TimeWork { get; set; }

        private decimal Category { get; set; }

        public Driver(decimal salary, decimal bonus, int timeWorked, char category)
        {
            Salary = salary;
            Bonus = bonus;
            TimeWork = timeWorked;
            switch (category)
            {
                case 'A':
                    Category = 125;
                    break;
                case 'B':
                    Category = 115;
                    break;
                case 'C':
                    Category = 100;
                    break;
            }
        }

        public decimal GetSalary()
        {
            return (Salary * (Category / 100)) * TimeWork + Bonus;
        }
    }
}

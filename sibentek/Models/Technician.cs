using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Technician : IEmployee
    {
        private decimal Salary { get; set; }

        private decimal Bonus { get; set; }

        private decimal Category { get; set; }

        public Technician(decimal salary, decimal bonus, char category)
        {
            Salary = salary;
            Bonus = bonus;
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
            return (Category / 100) * Salary + Bonus;
        }
    }
}

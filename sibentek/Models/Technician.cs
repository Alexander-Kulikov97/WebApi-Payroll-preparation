using Sibintek.Models.Enum;
using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Technician : IEmployee
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public decimal Bonus { get; set; }

        public Category Category { get; set; }

        public Technician(string position, decimal salary, decimal bonus, Category category)
        {
            Position = position;
            Salary = salary;
            Bonus = bonus;
            Category = category;
        }

        public decimal GetSalary()
        {
            return ((decimal)Category / 100) * Salary + Bonus;
        }
    }
}

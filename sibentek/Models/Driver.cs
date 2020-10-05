using Sibintek.Models.Enum;
using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Driver : IEmployee
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public decimal Bonus { get; set; }

        public int TimeWork { get; set; }

        public Category Category { get; set; }

        public Driver(string position, decimal salary, decimal bonus, int timeWorked, Category category)
        {
            Position = position;
            Salary = salary;
            Bonus = bonus;
            TimeWork = timeWorked;
            Category = category;
        }

        public decimal GetSalary()
        {
            return (Salary * ((decimal)Category / 100)) * TimeWork + Bonus;
        }
    }
}

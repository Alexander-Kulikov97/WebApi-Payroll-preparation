using Sibintek.Models.Enum;
using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Manager : IEmployee
    {
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public decimal Bonus { get; set; }

        public Manager(string position, decimal salary, decimal bonus)
        {
            Position = position;
            Salary = salary;
            Bonus = bonus;
        }

        public decimal GetSalary()
        {
            return Salary + Bonus;
        }
    }
}

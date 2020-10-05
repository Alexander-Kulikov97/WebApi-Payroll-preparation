using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models
{
    public class Manager : IEmployee
    {
        private decimal Salary { get; set; }

        private decimal Bonus { get; set; }

        public Manager(decimal salary, decimal bonus)
        {
            Salary = salary;
            Bonus = bonus;
        }

        public decimal GetSalary()
        {
            return Salary + Bonus;
        }
    }
}

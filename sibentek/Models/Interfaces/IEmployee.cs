using Sibintek.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sibintek.Models.Interfaces
{
    public interface IEmployee
    {
        public string Position { get; }

        public decimal GetSalary();
    }
}

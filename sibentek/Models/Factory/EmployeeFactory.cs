using Sibintek.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Sibintek.Models.Factory
{
    public class EmployeeFactory
    {
        public IEmployee Create(JObject data)
        {
            var position = data.Value<string>("position");

            if (position == null)
                throw new Exception("Invalid data");

            switch (position)
            {
                case "driver":
                    return data.ToObject<Driver>();
                case "manager":
                    return data.ToObject<Manager>();
                case "technician":
                    return data.ToObject<Technician>();
                default:
                    throw new NotImplementedException("Unknown position");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json.Linq;
using Sibintek.Models.Factory;

namespace sibentek.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class GetSalaryController : ControllerBase
    {
        /// <summary>
        /// Gets information about the company's employees and calculates how much the company should pay its employees at the end of the month
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     [
        ///        {
        ///             "position":"manager",
        ///             "salary": "150000",
        ///             "bonus": "0"
        ///         },
        ///         {
        ///             "position":"technician",
        ///             "salary": "35000",
        ///             "bonus": "5000",
        ///             "category": "B"
        ///         },
        ///         {
        ///             "position":"driver",
        ///             "salary": "250",
        ///             "bonus": "10000",
        ///             "timeWorked": "80",
        ///             "category": "A"
        ///         }
        ///     ]
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Total amount of salary payments for all employees</returns>
        /// <response code="200">Returns total amount of salary payments for all employees</response>
        [HttpPost]
        public decimal GetSalary([FromBody] JArray data)
        {
            return data.Select(x => new EmployeeFactory().Create((JObject)x).GetSalary()).Sum();
        }
    }
}
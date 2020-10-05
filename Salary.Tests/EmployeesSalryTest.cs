using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using sibentek.Controllers;
using Sibintek.Models;

namespace Salary.Tests
{
    [TestFixture]
    public class EmployeesSalryTest
    {
        [Test]
        public void GetSalary_Manager150000returned()
        {
            //arrange

            decimal salary = 150000;

            decimal bonus = 0;

            //act
            decimal actual = new Manager(salary, bonus).GetSalary();

            //assert
            Assert.That(actual, Is.EqualTo(150000));
        }

        [Test]
        public void GetSalary_Driver35000returned()
        {
            //arrange

            decimal salary = 250;

            decimal bonus = 10000;

            int timeWorked = 80;

            char category = 'A';

            //act
            decimal actual = new Driver(salary, bonus, timeWorked, category).GetSalary();

            //assert
            Assert.That(actual, Is.EqualTo(35000));
        }

        [Test]
        public void GetSalary_Technician45250returned()
        {
            //arrange

            decimal salary = 35000;

            decimal bonus = 5000;

            char category = 'B';

            //act
            decimal actual = new Technician(salary, bonus, category).GetSalary();

            //assert
            Assert.That(actual, Is.EqualTo(45250));
        }

        [Test]
        public void GetSalaryController_230250returned()
        {
            //arrange

            string json = @"[
                  {
                    'position': 'manager',
                    'salary': '150000',
                    'bonus': '0'
                  },
                  {
                    'position': 'technician',
                    'salary': '35000',
                    'bonus': '5000',
                    'category': 'B'
                  },
                  {
                    'position': 'driver',
                    'salary': '250',
                    'bonus': '10000',
                    'timeWorked': '80',
                    'category': 'A'
                  }
                ]";

            JArray jArray = JArray.Parse(json);

            //act
            decimal actual = new GetSalaryController().GetSalary(jArray);

            //assert
            Assert.That(actual, Is.EqualTo(230250));
        }
    }
}
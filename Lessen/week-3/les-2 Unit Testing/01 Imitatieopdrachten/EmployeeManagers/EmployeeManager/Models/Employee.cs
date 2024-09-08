using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public Salary Salary { get; set; }

        public Employee(string name, int salary)
        {
            Salary = new Salary();
            Name = name;
            Salary.Value = salary;
        }
    }
}

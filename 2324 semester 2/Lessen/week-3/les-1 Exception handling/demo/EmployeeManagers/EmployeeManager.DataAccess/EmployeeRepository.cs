using EmployeeManager.Models;
using EmployeeManager.Repositories;

namespace EmployeeManager.DataAccess
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private Employee[] employees;

        public EmployeeRepository()
        {
            employees = new Employee[3];
            employees[0] = new Employee("Aukje", 25000);
            employees[1] = new Employee("Jan", 20000);
            employees[2] = new Employee("Renée", 30000);
        }

        public Employee[] GetAll()
        {
            return employees;
        }

        public Employee? FindFirstByName(string? name)
        {
            Employee? employee = null;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Name == name)
                {
                    employee = employees[i];
                    break;
                }
            }
            return employee;
        }

    }
}

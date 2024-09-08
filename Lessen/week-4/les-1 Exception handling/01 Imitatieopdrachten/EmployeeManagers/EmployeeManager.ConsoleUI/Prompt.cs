using EmployeeManager.Models;
using EmployeeManager.Repositories;
using static Messages;

namespace EmployeeManager.ConsoleUI
{
    public class Prompt
    {
        private readonly IEmployeeRepository _employeeRepository;

        private Employee[] employees { get; set; }

        public Prompt(IEmployeeRepository employeeRepository)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            _employeeRepository = employeeRepository; // <<<<< de prompt klasse maakt nu niet meer de repository aan, hierdoor kan van verschillende gegevensbronnen gebruik gemaakt worden.
            employees = _employeeRepository.GetAll();
        }

        public string EmployeeList
        {
            get
            {
                string result = EmployeeListTitle;
                for (int i = 0; i < employees.Length; i++)
                {
                    result += string.Format(EmployeeListEntry, employees[i].Name, employees[i].Salary.Value);
                }
                return result;
            }
        }

        public void ShowEmployees()
        {
            Console.WriteLine(EmployeeList);
        }

        public bool DoYouWantToRaiseSalaries()
        {
            Console.WriteLine(RaiseSalaryQuestion);
            return Console.ReadLine().Trim().ToLower().Contains(ExpectedRaiseSalaryAnswer);
        }

        public void RaiseAnEmployeesSalary()
        {
            Console.WriteLine(GetEmployeeQuestion);
            var employeeName = Console.ReadLine();
            Employee? employee = _employeeRepository.FindFirstByName(employeeName);
            if (employee is not null)
            {
                Console.WriteLine(SalaryIncreaseQuestion, employee.Name, employee.Salary.Value);
                var verhoging = int.Parse(Console.ReadLine());
                employee.Salary.Raise(verhoging);
            }
            Console.Clear();
        }

        public void Exit()
        {
            Console.WriteLine(ProgramExitMessage);
            Console.ReadLine();
        }
    }
}

namespace OO_EmployeeManager.Models
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

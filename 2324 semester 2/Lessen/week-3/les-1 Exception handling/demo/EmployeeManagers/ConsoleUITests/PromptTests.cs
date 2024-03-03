using EmployeeManager.ConsoleUI;
using EmployeeManager.Models;
using EmployeeManager.Repositories;
using Moq; // >>>>>>>>>>> Install NuGet Package: Moq

namespace ConsoleUITests
{
    public class PromptTests
    {
        public readonly Mock<IEmployeeRepository> _repositoryMock = new();

        [Fact]
        public void EmployeeList_ListOneEmployee()
        {
            var employees = new Employee[] { new Employee("Jamy", 200000) };
            _repositoryMock.Setup(x => x.GetAll()).Returns(employees);

            var prompt = new Prompt(_repositoryMock.Object);
            string expected = "De volgende werknemers staan in het systeem:\n-\tJamy, salaris €200000)\n";
            string actual = prompt.EmployeeList;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmployeeList_ListMultipleEmployees()
        {
            var employees = new Employee[] { new Employee("Jamy", 200000), new Employee("James", 300000) };
            _repositoryMock.Setup(x => x.GetAll()).Returns(employees);

            var prompt = new Prompt(_repositoryMock.Object);
            string expected = "De volgende werknemers staan in het systeem:\n-\tJamy, salaris €200000)\n-\tJames, salaris €300000)\n";
            string actual = prompt.EmployeeList;

            Assert.Equal(expected, actual);
        }
    }
}
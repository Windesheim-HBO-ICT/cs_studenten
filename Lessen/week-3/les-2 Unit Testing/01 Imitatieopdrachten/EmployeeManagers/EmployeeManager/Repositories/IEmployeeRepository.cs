using EmployeeManager.Models;

namespace EmployeeManager.Repositories
{
    public interface IEmployeeRepository
    {
        Employee[] GetAll();

        Employee? FindFirstByName(string? name);
    }
}

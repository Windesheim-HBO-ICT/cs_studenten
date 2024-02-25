using OO_EmployeeManager.Models;
using OO_EmployeeManager.DataAccess;
using OO_EmployeeManager.UI;

var prompt = new Prompt();

do
{
    prompt.ShowEmployees();

    if (!prompt.DoYouWantToRaiseSalaries())
    {
        break;
    }

    prompt.RaiseAnEmployeesSalary();

} while (true);

prompt.Exit();
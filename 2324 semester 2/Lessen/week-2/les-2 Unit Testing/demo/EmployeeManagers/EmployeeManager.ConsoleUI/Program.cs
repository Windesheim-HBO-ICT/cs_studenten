using EmployeeManager.ConsoleUI;
using EmployeeManager.DataAccess;


var prompt = new Prompt(new EmployeeRepository()); //Hier wordt de repository geïnjecteerd in de prompt als dependency.

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

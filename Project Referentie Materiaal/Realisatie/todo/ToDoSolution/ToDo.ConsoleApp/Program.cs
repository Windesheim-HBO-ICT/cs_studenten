using ToDo;
using ToDo.DataAccess.InMemory;

var todoDataAccess = new ToDoRepository();
var todoService = new ToDoService(todoDataAccess);

Console.WriteLine("Do you want to create a new todo item? (y/n)");
char answer = Console.ReadKey().KeyChar;
Console.Clear();

if (answer == 'y')
{
    var newToDoItem = new ToDoItem();

    Console.Write("Please enter a title: ");
    newToDoItem.Title = Console.ReadLine();
    Console.Clear();

    Console.Write("Please enter a description: ");
    newToDoItem.Description = Console.ReadLine();
    Console.Clear();

    Console.Write("Please enter the name to assign this item to do: ");
    newToDoItem.AssignedTo = Console.ReadLine();
    Console.Clear();

    Console.Write("Please enter a due date: ");
    DateTime due;
    if (DateTime.TryParse(Console.ReadLine(), out due)) 
    {
        newToDoItem.Due = due;
    }
    Console.Clear();

    todoService.CreateNewToDoItem(newToDoItem);
    Console.WriteLine($"New todo-item {newToDoItem.Title} succesfully saved.\n\n");


}

var todoItems = todoService.GetAll();
Console.WriteLine("All ToDo items:");
foreach (var todoItem in todoItems)
{
    Console.WriteLine($"\t{todoItem.Title}");
}

Console.WriteLine("\n\nPress <enter> to exit..\n\n");
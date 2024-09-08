using Generics_HistoryList;


HistoryList<Person> historyList = new HistoryList<Person>();

historyList.Add(new Employee() { FirstName = "Marie", Surname = "Mariessens" });
historyList.Add(new Employee() { FirstName="Mart", Surname="Martiessen" });
historyList.Add(new Employee() { FirstName="Marc", Surname="Marcssen" });

historyList.Add(new Customer() { FirstName = "Jacob", Surname = "Jacobson" });
historyList.Add(new Customer() { FirstName = "Jean", Surname = "Jeanson" });
historyList.Add(new Customer() { FirstName = "Jan", Surname = "Janson" });


List<Employee> employees = historyList.ReadItems<Employee>();
foreach (Employee employee in employees) 
{
    Console.WriteLine($"Employee: {employee.Fullname}");
}

Console.ReadLine();

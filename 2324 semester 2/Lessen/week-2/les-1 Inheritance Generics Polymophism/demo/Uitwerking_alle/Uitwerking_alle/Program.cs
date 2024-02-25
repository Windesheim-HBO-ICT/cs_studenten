
using Personen = Uitwerking_alle.Personen;
using Generic = Uitwerking_alle.Generic;
using Uitwerking_alle.Gebouwen;



Personen.Printer printer = new();
printer.Print(new Personen.Customer("Jeanmarie"));
printer.Print(new Personen.Employee("Mariejean"));





Console.WriteLine("\n");

Generic.Customer paul = new Generic.Customer() { Firstname = "Paul", Surname = "Paulussen", SurnamePrefix = "den" };
Generic.Customer pauline = new Generic.Customer() { Firstname = "Pauline", Surname = "Paulussen", SurnamePrefix = "den" };
Generic.Customer paulus = new Generic.Customer() { Firstname = "Paulus", Surname = "Paulussen", SurnamePrefix = "den" };

Generic.Employee emi = new Generic.Employee() { Firstname = "Emi", Surname = "Emissen", SurnamePrefix = "de" };
Generic.Employee emy = new Generic.Employee() { Firstname = "Emy", Surname = "Emissen", SurnamePrefix = "de" };
Generic.Employee amy = new Generic.Employee() { Firstname = "Amy", Surname = "Emissen", SurnamePrefix = "de" };

Generic.HistoryList<Generic.Person> historyList = new Generic.HistoryList<Generic.Person>();

historyList.Add(paul);
historyList.Add(pauline);
historyList.Add(paulus);
historyList.Add(amy);
historyList.Add(emi);
historyList.Add(amy);

historyList.Remove(pauline);
historyList.Remove<Generic.Employee>(amy);

Console.WriteLine("\nPrinting people:\n");
foreach (var employee in historyList.ReadAll<Generic.Employee>()) 
{
    Console.WriteLine(employee.Fullname);
}




Console.WriteLine("\nPrinting history:\n");
Console.WriteLine(historyList.History);




Console.ReadLine();

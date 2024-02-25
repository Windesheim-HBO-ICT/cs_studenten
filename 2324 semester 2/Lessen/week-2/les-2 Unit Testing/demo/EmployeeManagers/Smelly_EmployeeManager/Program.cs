Console.OutputEncoding = System.Text.Encoding.UTF8;

string[,] employees = new string[3, 3];
employees[0, 0] = "Aukje";
employees[0, 1] = "25000";

employees[1, 0] = "Jan";
employees[1, 1] = "20000";

employees[2, 0] = "Renée";
employees[2, 1] = "30000";

do
{
    Console.WriteLine("De volgende werknemers staan in het systeem:");
    for (int i = 0; i < employees.GetLength(0); i++) 
    {
        Console.WriteLine($"-\t{employees[i, 0]}, salaris €{employees[i, 1]})");
    }

    Console.WriteLine("Wilt u een werknemer een loonsverhoging geven? (ja/nee)");
    if (!Console.ReadLine().Equals("ja"))
    {
        break;
    }

    Console.WriteLine("Welke werknemer wilt u een loonsverhoging geven?");
    var employee = Console.ReadLine();
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        if (employees[i, 0] == employee)
        {
            Console.WriteLine($"{employees[i, 0]} heeft een salaris van {employees[i, 1]}.\nGeef het bedrag van de loonsverhoging op:");
            employees[i, 1] = (int.Parse(employees[i, 1]) + int.Parse(Console.ReadLine())).ToString();
        }
    }
    Console.Clear();
} while (true);

Console.WriteLine("Geef een [ENTER] om af te sluiten");
Console.ReadLine();
using Uitwerking_CallByValOrRef.Models;

Paper p = new Paper();
Book b = new Book();

Printer printer = new Printer();

printer.Print(p);//paper is een value-type, er wordt een kopie van de value als argument meegegeven
printer.Print(b);//book is een reference-type, er wordt een kopie van de reference als argument meegegeven

Console.WriteLine($"Paperprints: {p.TimesPrinted}");
Console.WriteLine($"Bookprints: {b.TimesPrinted}");



printer.PrintRef(ref p);//paper is een value-type, er wordt nu een verwijzing naar de value als argument meegegeven
printer.PrintRef(ref b);//book is een reference-type, de reference zelf wordt nu als argument meegegeven

Console.WriteLine($"Paperprints: {p.TimesPrinted}");
Console.WriteLine($"Bookprints: {b.TimesPrinted}");


Console.ReadLine();
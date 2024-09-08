
### Opdrachtoplossing
```csharp
using System;

namespace EenvoudigQuizspelOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            // Vraag 1
            Console.WriteLine("Wat is de hoofdstad van Nederland?");
            Console.WriteLine("A. Amsterdam");
            Console.WriteLine("B. Parijs");
            Console.WriteLine("C. Berlijn");
            Console.WriteLine("D. Rome");
            Console.Write("Antwoord: ");
            char antwoord1 = Console.ReadKey().KeyChar;
            if (antwoord1 == 'A' || antwoord1 == 'a')
            {
                score++;
            }
            Console.WriteLine();

            // Vraag 2
            Console.WriteLine("Welk jaar is het huidige jaar?");
            Console.WriteLine("A. 2020");
            Console.WriteLine("B. 2021");
            Console.WriteLine("C. 2022");
            Console.WriteLine("D. 2023");
            Console.Write("Antwoord: ");
            char antwoord2 = Console.ReadKey().KeyChar;
            if (antwoord2 == 'D' || antwoord2 == 'd')
            {
                score++;
            }
            Console.WriteLine();

            // Vraag 3
            Console.WriteLine("Hoeveel is 15 gedeeld door 3?");
            Console.WriteLine("A. 5");
            Console.WriteLine("B. 3");
            Console.WriteLine("C. 2");
            Console.WriteLine("D. 10");
            Console.Write("Antwoord: ");
            char antwoord3 = Console.ReadKey().KeyChar;
            if (antwoord3 == 'A' || antwoord3 == 'a')
            {
                score++;
            }
            Console.WriteLine();

            // Vraag 4
            Console.WriteLine("Is de stelling 'C# is een programmeertaal' waar?");
            Console.WriteLine("A. Ja");
            Console.WriteLine("B. Nee");
            Console.Write("Antwoord: ");
            char antwoord4 = Console.ReadKey().KeyChar;
            if (antwoord4 == 'A' || antwoord4 == 'a')
            {
                score++;
            }
            Console.WriteLine();

            // Vraag 5
            DateTime huidigeDatum = DateTime.Now;
            Console.WriteLine("Wat is de huidige dag van de week?");
            Console.WriteLine($"A. Maandag, {huidigeDatum.AddDays(-(int)huidigeDatum.DayOfWeek + 1).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"B. Dinsdag, {huidigeDatum.AddDays(-(int)huidigeDatum.DayOfWeek + 2).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"C. Woensdag, {huidigeDatum.AddDays(-(int)huidigeDatum.DayOfWeek + 3).ToString("dd/MM/yyyy")}");
            Console.WriteLine($"D. Donderdag, {huidigeDatum.AddDays(-(int)huidigeDatum.DayOfWeek + 4).ToString("dd/MM/yyyy")}");
            Console.Write("Antwoord: ");
            char antwoord5 = Console.ReadKey().KeyChar;
            if (antwoord5 == 'B' || antwoord5 == 'b')
            {
                score++;
            }
            Console.WriteLine();

            // Toon de score aan het einde
            Console.WriteLine($"Je score is: {score} van de totale vragen.");
        }
    }
}
```

In deze oplossing zijn er vijf vragen toegevoegd die verschillende soorten gegevenstypen en berekeningen gebruiken, zoals `DateTime`, integers, bool en double. De gebruiker kan antwoorden op de vragen geven door de relevante toetsen in te drukken (bijv. A, B, C, D), en aan het einde wordt de score weergegeven op basis van de gegeven antwoorden.
```

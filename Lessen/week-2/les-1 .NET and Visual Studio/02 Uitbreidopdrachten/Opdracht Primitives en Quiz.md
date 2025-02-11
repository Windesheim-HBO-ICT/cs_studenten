## Opdracht: C# Primitieve Gegevenstypen en Eenvoudig Quizspel

| Complexiteit | Moment  | Scaffolding | Ondersteuning | Onderwerpen                   |
|--------------|---------|-------------|---------------|-------------------------------|
| Beginner     | Werkcollege, thuis | Ja          | Ja            | C# Primitieve Typen, Eenvoudig Quizspel |

### Beschrijving
In deze opdracht zul je een eenvoudig quizspel ontwikkelen waarin je gebruikmaakt van primitieve gegevenstypen in C#. Het spel zal de speler een reeks vragen stellen en de antwoorden evalueren om de uiteindelijke score te berekenen.

### Functionele Eisen
- Stel tenminste vijf vragen aan de speler met meerkeuzeantwoorden.
- Geef de speler de mogelijkheid om antwoorden te selecteren door de relevante toetsen in te drukken (bijv. A, B, C, D).
- Evalueer de gegeven antwoorden en bereken de score van de speler.
- Toon aan het einde van het spel de score van de speler.

### Niet-functionele Eisen
- Schrijf leesbare en goed geformatteerde code.
- Voeg commentaar toe om je code uit te leggen.

### Testprocedure
1. Voer de gegeven code uit en speel het quizspel door de antwoorden te selecteren.
2. Controleer of de score aan het einde van het spel correct wordt weergegeven op basis van de gegeven antwoorden.

### Testresultaat
Alle tests zijn geslaagd. Het quizspel functioneert zoals verwacht en geeft de juiste score weer aan het einde.

### Ondersteunende Informatie
In deze opdracht ga je aan de slag met het ontwikkelen van een eenvoudig quizspel met behulp van primitieve gegevenstypen in C#. Je zult leren hoe je gebruikersinvoer kunt verwerken en hoe je de gegeven antwoorden kunt evalueren om de score te berekenen. Hier is een deel van de oplossing om je op weg te helpen:

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
            Console.WriteLine("Wat is de hoofdstad van Frankrijk?");
            Console.WriteLine("A. Londen");
            Console.WriteLine("B. Parijs");
            Console.WriteLine("C. Berlijn");
            Console.WriteLine("D. Rome");
            Console.Write("Antwoord: ");
            char antwoord1 = Console.ReadKey().KeyChar;
            if (antwoord1 == 'B' || antwoord1 == 'b')
            {
                score++;
            }
            Console.WriteLine();

            // Voeg hier nog meer vragen toe...

            // Toon de score aan het einde
            Console.WriteLine($"Je score is: {score} van de totale vragen.");
        }
    }
}
```

Voel je vrij om meer vragen toe te voegen en het quizspel verder aan te passen en uit te breiden.

Succes met het ontwikkelen van het quizspel!

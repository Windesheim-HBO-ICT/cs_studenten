# Opdracht: C# Multidimensionale Arrays


| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|-----------------|--------------|--------------|------------------|---------------------------------------|
| Novice          | College      | Nee          | Ja               | Multidimensionale arrays in C#        |

## Beschrijving

In deze opdracht zul je werken met multidimensionale arrays in C#. Je zult leren hoe je deze arrays kunt declareren, initialiseren en gebruiken in je programma's. Deze opdracht is bedoeld voor beginners om vertrouwd te raken met het werken met multidimensionale arrays. Je ontwikkelt een eenvoudige versie van het spel zeeslag.


## Functionele vereisten

- Declareer en initialiseer een tweedimensionale array met 10 rijen en 10 kolommen van het type `String`.
- Vul het 'bord' met een aantal schepen, met de letter 'S'.
- Plaats eem aantal schoten, met de letter 'X'.
- Bereken het percentage van de velden met een schip dat geraakt is.
- Druk de inhoud van de array af op het scherm.
- Druk het percentage van geraakte schepen af op het scherm.

## Niet-functionele vereisten

- De code moet goed georganiseerd en leesbaar zijn.
- Gebruik de juiste namen voor variabelen en functies.
- Voeg opmerkingen toe om de code uit te leggen.

## Testprocedure

1. Compileer en voer het programma uit.
2. Controleer of de inhoud van de array correct wordt afgedrukt.
3. Controleer of het berekende percentage correct wordt afgedrukt.

## Testresultaat

- De inhoud van de array wordt correct afgedrukt.
- Het percentage is correct.

## Ondersteunende informatie

In deze opdracht zul je werken met multidimensionale arrays.

Een multidimensionale array is een verzameling van elementen die is georganiseerd in meerdere dimensies, zoals een tabel met rijen en kolommen. Hiermee kun je gegevens structureren die meerdere dimensies hebben, zoals een raster of een matrix.

Hier is een voorbeeld van hoe je een tweedimensionale array kunt declareren, initialiseren en gebruiken:


```csharp
using System;

int[,] matrix = new int[3, 4]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
}

Console.WriteLine("Inhoud van de matrix:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Som van de elementen: " + sum);
```

**Opmerking:** Zorg ervoor dat je de code in een `Main`-functie plaatst om deze uitvoerbaar te maken.

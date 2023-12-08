
## Opdrachtoplossing



```csharp
char[,] zeegevechtKaart = new char[10, 10]
{
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
};

// Plaats schepen op de zeegevecht kaart
zeegevechtKaart[2, 3] = 'S';  // Schip 1
zeegevechtKaart[4, 5] = 'S';  // Schip 2
zeegevechtKaart[7, 2] = 'S';  // Schip 3

// Druk de zeegevecht kaart af
for (int i = 0; i < zeegevechtKaart.GetLength(0); i++)
{
    for (int j = 0; j < zeegevechtKaart.GetLength(1); j++)
    {
        Console.Write(zeegevechtKaart[i, j] + " ");
    }
    Console.WriteLine();
}
```

In dit voorbeeld hebben we een zeegevecht kaart van 10x10, gerepresenteerd door een tweedimensionale char array `zeegevechtKaart`. Lege zeevakken worden aangeduid met het spatiekarakter `' '`, en schipposities worden gemarkeerd met het karakter `'S'`. We initialiseren de zeegevecht kaart met lege vakken en plaatsen vervolgens drie schepen op specifieke coördinaten. Ten slotte drukken we de zeegevecht kaart af op het scherm.


Plaats de bovenstaande code in een `Main`-functie om het uitvoerbaar te maken.
# Game Karaktersysteem in C# met Generieke Methode en Springapparaten**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Gevorderd        | College      | Nee          | Ja               | C# klassen en objecten, overerving, polymorfisme, generieke methoden      |


## Beschrijving  
In deze geavanceerde opdracht ga je een game karaktersysteem in C# ontwikkelen met een extra dimensie. Je zult niet alleen een basis `Character`-klasse en afgeleide subklassen maken, maar ook een generieke methode toevoegen voor karakters om te springen met behulp van verschillende springapparaten zoals veren, vleugels of raketten.

## Functionele Vereisten:  
- Definieer een basis `Character`-klasse met eigenschappen zoals naam, levenspunten (HP) en aanvalskracht.
- Maak afgeleide klassen voor ten minste drie verschillende karakters (bijvoorbeeld Krijger, Magiër, Schurk).
- Elk karaktertype moet unieke vaardigheden hebben die worden geactiveerd wanneer ze worden aangevallen.
- Implementeer een methode om de informatie van elk karakter weer te geven, inclusief hun speciale vaardigheden.
- Voeg een generieke methode `Jump` toe aan de `Character`-klasse die het type springapparaat als argument accepteert en een bijbehorend bericht weergeeft.

## Niet-functionele Vereisten:  
- Gebruik passende naamgeving en commentaar voor een duidelijke code.
- Houd je code goed georganiseerd met behulp van geschikte namespaces.

## Testprocedure:  
1. Maak instanties van elk karaktertype en stel hun eigenschappen in.
2. Voer een reeks aanvallen uit op elk karakter en observeer hoe hun unieke vaardigheden worden geactiveerd.
3. Roep de `Jump`-methode aan voor elk karakter, waarbij je verschillende typen springapparaten doorgeeft, en observeer de bijbehorende springberichten.
4. Toon de informatie van elk karakter aan de hand van de implementeerde methode.

## Testresultaat:  
- Alle karakters moeten correcte informatie, speciale vaardigheden tijdens aanvallen en juiste springberichten met bijbehorende springapparaten weergeven.

## Ondersteunende Informatie:  
Bij geavanceerde complexiteit:
- **C# klassen en objecten**: Dit verwijst naar het concept van objectgeoriënteerd programmeren waarbij klassen sjablonen zijn voor objecten en eigenschappen.
- **Overerving**: Overerving stelt je in staat om een hiërarchie van klassen te maken, waarbij afgeleide klassen eigenschappen en methoden van een basis (ouder) klasse overnemen.
- **Polymorfisme**: Polymorfisme maakt het mogelijk dat objecten van verschillende klassen kunnen worden behandeld als objecten van een gemeenschappelijke basis-klasse.
- **Generieke methoden**: Generieke methoden stellen je in staat om methoden te schrijven die werken met verschillende datatypes terwijl de herbruikbaarheid en typeveiligheid behouden blijven.

Scaffolded code:
```csharp
using System;

class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks with a normal attack.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}\nHP: {HP}\nAttack Power: {AttackPower}");
    }

    public void Jump<T>(T device)
    {
        Console.WriteLine($"{Name} is jumping using a {device}!");
    }
}

class Warrior
{
    // Implement unique properties and override Attack method
    // Instructions for unique attack
}

class Mage
{
    // Implement unique properties and override Attack method
    // Instructions for unique attack
}

class Rogue
{
    // Implement unique properties and override Attack method
    // Instructions for unique attack
}

class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior("Aldric");
        Mage mage = new Mage("Elara");
        Rogue rogue = new Rogue("Sylas");

        Character[] characters = { warrior, mage, rogue };

        foreach (Character character in characters)
        {
            character.Attack();
            character.DisplayInfo();
            character.Jump<Character>("feather"); // use implementation of device
            Console.WriteLine();
        }
    }
}
```


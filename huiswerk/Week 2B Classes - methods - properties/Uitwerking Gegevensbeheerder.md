# Opdracht oplossing

```csharp
using System;
using System.Collections.Generic;

public class Klant
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }
    public string Adres { get; set; }
    public string Telefoonnummer { get; set; }
}

public class Klantbeheerder
{
    private List<Klant> klanten;

    public Klantbeheerder()
    {
        klanten = new List<Klant>();
    }

    public void VoegKlantToe(Klant klant)
    {
        // Voeg de klant toe aan de lijst
        klanten.Add(klant);
    }

    public void VerwijderKlant(string naam)
    {
        // Zoek de klant op basis van de naam en verwijder deze uit de lijst
        klanten.RemoveAll(k => k.Naam == naam);
    }

    public void BewerkKlant(string naam, Klant nieuweGegevens)
    {
        // Zoek de klant op basis van de naam en bewerk

 de gegevens
        var klant = klanten.Find(k => k.Naam == naam);
        if (klant != null)
        {
            klant.Naam = nieuweGegevens.Naam;
            klant.Leeftijd = nieuweGegevens.Leeftijd;
            klant.Adres = nieuweGegevens.Adres;
            klant.Telefoonnummer = nieuweGegevens.Telefoonnummer;
        }
    }

    public List<Klant> ZoekKlant(Func<Klant, bool> criteria)
    {
        // Zoek klanten op basis van het opgegeven criterium
        return klanten.FindAll(criteria);
    }

    public void ToonAlleKlanten()
    {
        // Toon alle klanten in het klantenbestand
        foreach (var klant in klanten)
        {
            Console.WriteLine($"Naam: {klant.Naam}, Leeftijd: {klant.Leeftijd}, Adres: {klant.Adres}, Telefoonnummer: {klant.Telefoonnummer}");
        }
    }
}

// Voorbeeldgebruik van de klasse Klantbeheerder:
var beheerder = new Klantbeheerder();

var klant1 = new Klant { Naam = "John Doe", Leeftijd = 30, Adres = "123 Main Street", Telefoonnummer = "555-1234" };
beheerder.VoegKlantToe(klant1);

var klant2 = new Klant { Naam = "Jane Smith", Leeftijd = 25, Adres = "456 Elm Street", Telefoonnummer = "555-5678" };
beheerder.VoegKlantToe(klant2);

// Voeg meer klanten toe...

beheerder.ToonAlleKlanten();

// Uitvoer:
// Naam: John Doe, Leeftijd: 30, Adres: 123 Main Street, Telefoonnummer: 555-1234
// Naam: Jane Smith, Leeftijd: 25, Adres: 456 Elm Street, Telefoonnummer: 555-5678
```

Dit is de oplossing voor de opdracht. Je kunt deze gebruiken als referentie om je eigen implementatie te voltooien.
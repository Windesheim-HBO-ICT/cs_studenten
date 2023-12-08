# Opdracht: Gegevensbeheerder

| Complexiteit | Moment     | Scaffolding | Ondersteuning | Onderwerpen               |
|--------------|------------|-------------|---------------|---------------------------|
| Gevorderd    | Huiswerk   | Ja          | Ja            | C# klassen, methoden, eigenschappen |

## Beschrijving
Je bent ingehuurd als gegevensbeheerder voor een bedrijf dat klantinformatie opslaat. Je taak is om een C#-programma te ontwikkelen dat een klantenbestand beheert. Het programma moet in staat zijn om klanten toe te voegen, te verwijderen, te bewerken en te zoeken op basis van verschillende criteria.

## Functionele vereisten
- Het programma moet een klasse genaamd `Klant` bevatten met de volgende eigenschappen:
  - `Naam`: een string die de naam van de klant opslaat.
  - `Leeftijd`: een integer die de leeftijd van de klant opslaat.
  - `Adres`: een string die het adres van de klant opslaat.
  - `Telefoonnummer`: een string die het telefoonnummer van de klant opslaat.
- Het programma moet een methode genaamd `VoegKlantToe` bevatten waarmee een nieuwe klant aan het klantenbestand kan worden toegevoegd.
- Het programma moet een methode genaamd `VerwijderKlant` bevatten waarmee een klant uit het klantenbestand kan worden verwijderd op basis van de naam.
- Het programma moet een methode genaamd `BewerkKlant` bevatten waarmee de gegevens van een klant kunnen worden bewerkt op basis van de naam.
- Het programma moet een methode genaamd `ZoekKlant` bevatten waarmee klanten kunnen worden gezocht op basis van de naam, leeftijd, adres of telefoonnummer. De methode moet alle klanten retourneren die aan de opgegeven criteria voldoen.
- Het programma moet een methode genaamd `ToonAlleKlanten` bevatten waarmee alle klanten in het klantenbestand worden weergegeven.

## Niet-functionele vereisten
- Het programma moet efficiënt en geoptimaliseerd zijn voor het beheren van grote aantallen klanten.
- Het programma moet robuust zijn en omgaan met mogelijke fouten, zoals het toevoegen van een klant met een bestaande naam.

## Testprocedure
1. Maak een instantie van de `Klantbeheerder`-klasse.
2. Voeg enkele klanten toe met behulp van de `VoegKlantToe`-methode.
3. Verwijder een klant met behulp van de `VerwijderKlant`-methode.
4. Bewerk de gegevens van een klant met behulp van de `BewerkKlant`-methode.
5. Zoek klanten op basis van verschillende criteria met behulp van de `ZoekKlant`-methode.
6. Toon alle klanten in het klantenbestand met behulp van de `ToonAlleKlanten`-methode.

## Testresultaat
Het programma moet correct werken en de verwachte result

aten opleveren bij het uitvoeren van de bovenstaande testprocedure.

## Ondersteunende informatie
Dit is een geavanceerde opdracht waarbij je je kennis van C# klassen, methoden en eigenschappen moet toepassen om een klantenbeheerprogramma te implementeren. Het is belangrijk om de principes van objectgeoriënteerd programmeren te begrijpen en toe te passen.

### Verschillende methodesignaturen
Hier zijn enkele voorbeelden van verschillende methodesignaturen die je kunt gebruiken bij het implementeren van de `ZoekKlant`-methode:

```csharp
public List<Klant> ZoekKlant(string zoekterm)
{
    // Zoek klanten op basis van de opgegeven zoekterm
    return klanten.FindAll(k => k.Naam.Contains(zoekterm) ||
                                k.Adres.Contains(zoekterm) ||
                                k.Telefoonnummer.Contains(zoekterm));
}

public List<Klant> ZoekKlant(int minimumLeeftijd)
{
    // Zoek klanten op basis van de minimumleeftijd
    return klanten.FindAll(k => k.Leeftijd >= minimumLeeftijd);
}

// Voeg meer methodesignaturen toe op basis van andere criteria...
```

### Verschillende implementaties van eigenschappen
Hier zijn enkele voorbeelden van verschillende implementaties van eigenschappen in de `Klant`-klasse:

```csharp
private string naam;

public string Naam
{
    get { return naam; }
    set { naam = value.Trim(); } // Trim de invoer om witruimte aan het begin en einde te verwijderen
}

private int leeftijd;

public int Leeftijd
{
    get { return leeftijd; }
    set
    {
        if (value >= 0) // Controleer of de leeftijd niet negatief is
            leeftijd = value;
        else
            throw new ArgumentException("Leeftijd mag niet negatief zijn.");
    }
}

// Voeg meer eigenschappen toe met verschillende validaties en logica...
```

Dit is een voorbeeldoplossing voor de opdracht. Je kunt het aanpassen en uitbreiden om aan je specifieke behoeften te voldoen.


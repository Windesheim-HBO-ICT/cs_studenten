# Appels en peren vergelijken**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Basis        | Huiswerk      | Nee          | Ja               | polymorphism, generics      |


## Beschrijving  
In deze opdracht leer je polymorfisme en generics toe te passen door interfaces en methodes uit bestaande .NET bibliotheken te implementeren. Je gaat appels sorteren op kleur en appels met peren vergelijken. Daarna sorteer je fruit op gewicht.

## Functionele Vereisten:  
- Appels worden vergeleken op basis van kleur (rood, geel en groen).
- Appels worden gesorteerd op kleur volgorde: rood, geel, groen.
- Vergelijk een appel met een peer, waarbij altijd ze altijd ongelijk moeten zijn.


## Niet-functionele Vereisten:  
- Implementeer de .NET interface `IComparable<T>` in de Appel klasse om appels op kleur te vergelijken.
- Gebruik een generic `List<T>` en sorteer de lijst met de `Sort()` methode.
- Implementeer de .NET interface `IEquatable<T>` om een appel met een peer te vergelijken.
- Implementeer de `IComparer<T>` in een nieuwe GewichtVergelijker klasse om fruit op gewicht te sorteren.
- Gebruik een generic `List<T>` en sorteer de lijst met de `Sort()` methode en geef een nieuwe instantie van de GewichtVergelijker mee.

## Testprocedure:  
1. Neem meerdere (en verschillend gekleurde) appels op in een nieuwe lijst.
2. Print de ongesorteerde lijst in het scherm.
3. Sorteer de lijst en print de lijst opnieuw.
4. Vergelijk een appel met een peer en print de uitkomst van de vergelijking.
5. Neem meerdere (en met verschillend gewicht) peren op in een nieuwe lijst.
7. Print de ongesorteerde lijst.
8. Sorteer de lijst met een gewicht vergelijker en print de lijst opnieuw.

## Testresultaat:  
- De appels worden eerst ongesorteerd weergegeven, daarna wordt een gesorteerde lijst met appels weergegeven. 
- De vergelijking van de appel met de peer resulteert de volgende tekst: Een 'appel' is wel/niet vergelijkbaar met een peer.. ;).
- De peren worden eerst ongesorteerd weergegeven, daarna wordt een op gewicht gesorteerde lijst van peren weergegeven.




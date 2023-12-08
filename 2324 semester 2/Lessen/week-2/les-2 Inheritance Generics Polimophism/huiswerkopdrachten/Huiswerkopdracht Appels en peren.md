# Appels en peren vergelijken**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Basis        | College      | Nee          | Ja               | polymorfisme, generics      |


## Beschrijving  
In deze opdracht leer je polymorfisme en generics toe te passen door interfaces en methodes uit bestaande .NET bibliotheken te implementeren. Je gaat appels en/met peren vergelijken om ze gesorteerd weer te kunnen geven. 

## Functionele Vereisten:  
- Appels worden vergeleken op basis van kleur (rood, geel en groen)
- Appels worden gesorteerd op kleur volgorde: rood, geel, groen.
- Peren hoeven niet gesorteerd te worden, maar peren worden bovenin een lijst met appels weergegeven.


## Niet-functionele Vereisten:  
- Implementeer de .NET interface `IComparable<T>` om appels op kleur te vergelijken
- Gebruik de generic `List<T>` en de `Sort()` methode om te sorteren
- Implementeer de .NET interface `IComparable<T>` om appels met peren te vergelijken

## Testprocedure:  
1. Neem meerdere (en verschillend gekleurde) appels op in een lijst.
2. Print de ongesorteerde lijst in het scherm
3. Sorteer de lijst
3. Print de gesorteerde lijst
4. Voeg een peer aan de lijst toe
5. Print de lijst

## Testresultaat:  
- De appels worden eerst ongesorteerd weergegeven, daarna worden de appels op kleur gesorteerd weergegeven, daarna wordt een gesorteerde lijst met appels weergegeven, waarin bovenaan een peer staat.




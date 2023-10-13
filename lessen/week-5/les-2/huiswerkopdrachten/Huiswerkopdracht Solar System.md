# Solar System**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Gemiddeld        | Huiswerk      | Nee          | Ja               | LINQ, anonymous types, delegates      |


## Beschrijving  
In deze opdracht implementeer je een klassenstructuur voor ons zonnestelsel. Daarna gebruik je LINQ om zoek- en berekenvraagstukken te beantwoorden.


## Functionele Vereisten:  
- Toon een lijst van planeten oplopend gesorteerd op naam.
- Toon een lijst van planeten waarvan de temperatuur boven nul kan zijn.
- Tel en toon het aantal manen van Jupiter als volgt: "Jupiter heeft <aantal> manen."
- Zoek de planeten waar een ‘p’ en een ‘t’ in de naam zit.
- Toon een lijst van planeten aflopend gesorteerd op de lengte van de naam.
- Toon een lijst van planeten oplopend gesorteerd op basis van de gemiddelde afstand tot de zon, selecteer en toon de naam en de afstand.
- Toon een lijst van alle soorten van planeten (dwergplaneten samen met planeten) aflopend gesorteerd op diameter.
- Toon een lijst van alle planeten (dwergplaneten samen met planeten) aflopend gesorteerd op het grootste aantal manen.
- Tel het totaalaantal manen van het zonnestelsel.
- Bereken het gemiddelde aantal manen over alle soorten van planeten.
- Toon de gemiddelde oppervlaktetemperatuur van de dwergplaneten, van de planeten en de zon en toon deze in drie regels.
- Toon een lijst met het totaalaantal zonnen, planeten, dwergplaneten en manen bij elkaar opgeteld.
- Toon de twee planeten die het dichts bij elkaar staan (op basis van gemiddelde afstand tot de zon).


## Niet-functionele Vereisten: 
- Object oriëntatie wordt in het ontwerp toegepast, waarbij in de klassenstructuur het zonnestelsel, de planeten en manen als een type zijn gedefinieerd.
- Waar mogelijk worden LINQ opdrachten als één statement geformuleerd (keuze query- of method-syntax is vrij).
- Waar passend wordt een anoniem type gebruikt.
- Standaard codeerconventies worden aangehouden.


## Testprocedure:  
1. Open de bestanden waarin de relaties tussen klassen duidelijk gemaakt worden.
2. Open de bestanden met de LINQ query’s.
3. Voer de applicatie uit.


## Testresultaat:  
- In de bestanden met de gedefinieerde klassenstructuur worden de relaties ‘is een’ en ‘heeft een’ tussen de klassen toegepast.
- In de bestanden worden LINQ query- of method-syntax toegepast en waar mogelijk als één statement geformuleerd.
- In (ten minste) een van de queries is een anoniem type gebruikt.
- De query resultaten worden na de omschrijving van de functionele eis, per eis geprint in de Console.


## Ondersteunende Informatie

Gebruik de informatie uit de volgende afbeelding om het zonnestelsel met planeten en manen aan te maken. Maak een klasse aan voor de zon, planeten en manen. De manen hoeven niet met gegevens (properties) gevuld te worden. Een maan kan bij een planeet horen en een planeet kan een collectie van manen hebben. Gebruik de gegevens uit de afbeelding.

![afbeeldingen en gegevens van de planeten uit ons zonnestelsel](SolarSystem.png)

De complexiteit van de functionele eisen neemt toe per eis. Houd rekening met de beschikbare tijd en sla een eis over wanneer de geplande tijd overschreden wordt.

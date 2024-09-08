# Solar System**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Gemiddeld        | Huiswerk      | Nee          | Ja               | LINQ, anonymous types, delegates      |


## Beschrijving  
In deze opdracht implementeer je een klassenstructuur voor ons zonnestelsel. Daarna gebruik je LINQ om zoek- en berekenvraagstukken te beantwoorden.


## Functionele Vereisten:  
- Toon de namen van alle planeten van de zon oplopend gesorteerd op naam.
- Toon de namen en temperaturen van de planeten van de zon waarvan de oppervlaktetemperatuur boven nul kan zijn.
- Zoek de eerste planeet van de zon met de naam Jupiter, tel en toon het aantal manen van Jupiter als volgt: "<planeet> heeft <aantal> manen."
- Zoek de planeten van de zon waar een ‘p’ en een ‘t’ in de naam zit.
- Toon de namen van alle planeten van de zon aflopend gesorteerd in een Array op de lengte van de naam.
- Toon de naam en diameter van alleen de planeten (geen dwergplaneten) aflopend gesorteerd op diameter. 
- Toon de naam en het aantal manen van alle dwergplaneten aflopend gesorteerd op het grootste aantal manen. 
- Tel het totaalaantal manen van alle planeten van de zon.
- Bereken het gemiddelde aantal manen over alle soorten van planeten.
- Toon de gemiddelde oppervlaktetemperatuur over alle planeten van de zon.
- Tel en toon het aantal planeten en dwergplaneten.(Implementeer voor type/class en aantal een nieuwe klasse)
- Toon het type planeet en tel het aantal manen per type planeet en sorteer aflopend op aantal. 
- Tel het aantal aantal planeten, aantal dwergplaneten en manen en toon dit aflopend op aantal.
- Toon de twee planeten die het dichts bij elkaar staan (op basis van gemiddelde afstand tot de zon).


## Niet-functionele Vereisten: 
- Object oriëntatie wordt toegepast in het ontwerp, waarbij in de klassenstructuur het zonnestelsel, de planeten en manen als een type zijn gedefinieerd.
- Daar waar mogelijk wordt LINQ toegepast en als één statement geformuleerd (keuze query- of method-syntax is vrij). Dus gebruik LINQ zoveel mogelijk om de gegevensstructuren op te bouwen.
- Waar passend wordt een anoniem type gebruikt.
- Standaard codeerconventies worden aangehouden.
- Een eenvoudige UI wordt gebruikt (bijv. Console Applicatie).


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

Gebruik de informatie uit de volgende afbeelding (of gebruik andere bronnen) om het zonnestelsel met planeten en manen aan te maken. Maak een klasse aan voor de ster(ren), planeten en manen. De manen hoeven niet met gegevens (properties) geïmplementeerd te worden. Een maan hoort bij een planeet en een planeet kan een collectie van manen hebben. Een planeet of dwergplaneet hoort bij een ster en een ster heeft een collectie van planeten waarin ook de dwergplaneten opgenomen zijn. Uiteraard zijn er andere oplossingen mogelijk. Ontwerp eerst zelfstandig een klassestructuur. Vergelijk na het implementeren je eigen klassestructuur met het voorbeeld (SolarSystem_Uitwerking_1) op GitHub.

Voor de (ontbrekende) temperatuurwaarden mag je de volgende oplossing gebruiken: Wanneer de minimum en maximum temperaturen ontbreken (en er alleen een temperatuur is), stel deze gelijk aan de temperatuur. Wanneer de temperatuur ontbreekt, en alleen de minimum en maximum temperatuur weergegeven is, bereken dan de temperatuur op basis van het gemiddelde.

![afbeeldingen en gegevens van de planeten uit ons zonnestelsel](SolarSystem.png)

De complexiteit van de functionele eisen neemt toe per eis. Houd rekening met de beschikbare tijd en sla een eis over wanneer de geplande tijd overschreden wordt.

De aangedragen uitwerking houdt niet op alle plekken rekening met mogelijke null-waarden terwijl dit wel zou moeten. Er worden voorbeelden gegeven hoe er wel rekening mee gehouden kan worden.
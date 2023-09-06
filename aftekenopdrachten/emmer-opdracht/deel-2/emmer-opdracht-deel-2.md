# Opdracht Emmer - deel 2
**Onderwerpen:** Exceptions, Unit-Testing  
**Complexiteit:** novice 

## Opdrachtbeschrijving  
In deze opdracht ga je verder met Opdracht Emmer - deel 1, waarbij je nu testen gaat toevoegen en exceptions implementeren gaat.

## Functionele eisen
-	De functionele eisen uit Opdracht Emmer - deel 1 blijven van toepassing.
-	Voorkom dat een onjuiste capaciteit ingesteld kan worden.

## Non-functionele eisen
-	De non-functionele eisen uit Opdracht Emmer -deel 1 blijven van toepassing.
-	Genereer een foutmelding waarmee voorkomen wordt dat een onjuiste capaciteit ingesteld kan worden. 
-	Schrijf een nieuwe klasse voor de exception. De exception toont de onjuiste en juiste waarde van de capaciteit in de Message property.

## Test procedure
-	Schrijf unit testen om de correcte werking van de gestelde eisen aan te tonen. Houd rekening met de impliciete en ongewenste scenario’s die voortvloeien uit de gestelde eisen.

## Test resultaat
-	Alle testen slagen

## Ondersteunende informatie

### Exceptions
Wanneer code defensief is ontworpen, dan wordt er in de code rekening gehouden met onverwachte en ongewenste situaties. Het ontwerp gaat er van uit dat aanroepen verkeerd gedaan zouden kunnen worden. Alle input wordt eerst gevalideerd voordat het gebruikt wordt. Dit is een verantwoordelijkheid die in de klassen zelf aangelegd wordt en niet alleen aanwezig is in de User Interface.
In het geval van een onjuiste situatie wordt een foutmelding gegeven. Een foutmelding genereer je in C# door een Exception te ‘throwen’.
`throw new System.DivideByZeroException();`
Een veel voorkomend type is het InvalidOperationException en ArgumentOutOfRangeException. Je kunt ook overerven van deze typen en bijvoorbeeld NegativeAgeException maken en gebruiken, wanneer gepoogd wordt een leeftijd met een negatieve waarde te vullen.  

Een Exception onderbreekt het uitvoeren van de normale flow van de applicatie en dient met een try-catch statement afgevangen te worden. Wanneer een exception niet door de applicatie afgevangen wordt dan wordt het uitvoeren van de applicatie onderbroken. De .NET runtime vangt dan de exception af waardoor het onderliggende besturingssysteem normaal blijft opereren.  

Om dit in werking te zien kun je een applicatie uitvoeren in de release modus en starten vanuit de bin/release map.
Een exception is een uitzondering (letterlijke vertaling). Gebruik een exception nooit om de normale flow van een applicatie te bepalen. Je ontwikkeld code om het uitvoeren van exceptions te voorkomen en gebruikt exceptions om ongewenste situaties te voorkomen.

### Testing
Voeg een Unit Test project toe aan je solution. Er zijn verschillende unit-test frameworks: MsTest, nUnit of xUnit, de laatste twee genoemde zijn de populairste en worden aanbevolen. Maak mappen aan in je test project om de testen te groeperen. Let op de naamgeving van de mappen, code bestanden en de test procedures. Daar zijn standaarden voor, maar consistentie en een logische structuur is het belangrijkste.  

Schrijf testen voor alle gespecificeerde functionaliteiten uit deel 1 van de opdracht en schrijf ook testen om te controleren of de door jou geïmplementeerde Exceptions ook optreden bij onjuiste aanroepen of invalide gegevens.

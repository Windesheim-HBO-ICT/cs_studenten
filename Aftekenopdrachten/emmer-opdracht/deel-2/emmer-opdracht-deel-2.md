# Opdracht Emmer - deel 2
**Onderwerpen:** Exceptions, Unit-Testing  
**Complexiteit:** intermediate 

## Opdrachtbeschrijving  
In deze opdracht ga je verder met Opdracht Emmer-deel 1, waarbij je nu unit-testen toevoegt en exceptions implementeert.

## Functionele eisen
-	De functionele eisen uit Opdracht Emmer-deel 1 blijven van toepassing.
-	Voorkom dat een onjuiste capaciteit ingesteld kan worden.

## Non-functionele eisen
-	De non-functionele eisen uit Opdracht Emmer-deel 1 blijven van toepassing.
-	Genereer een exception bij een onjuiste capaciteit waarde. 
-	Implementeer een nieuwe klasse voor de exception. De exception beschrijft de situatie met de onjuiste en juiste waarde(n) van de capaciteit in de Message property.

## Test procedure (eisen tijdens aftekenmoment)
-	Voer de unit-testen uit en toon de correcte werking van de gestelde eisen aan. Houd daarbij rekening met de impliciete en ongewenste scenario’s die voortvloeien uit de gestelde eisen.
-	Toon implementaties en licht ontwerpkeuzes toe.

## Test resultaat (eisen tijdens aftekenmoment)
-	De unit-testen slagen en tonen de correcte werking van de gestelde eisen aan.
-	Ontwerpkeuzes zijn toegelicht, waarmee de kwaliteit van de code en de testen aangetoond is.


## Ondersteunende informatie

### Exceptions
Wanneer code defensief is ontworpen, dan wordt er in de code rekening gehouden met onverwachte en ongewenste situaties. Het ontwerp gaat er van uit dat aanroepen verkeerd gedaan zouden kunnen worden. Alle input wordt eerst gevalideerd voordat het gebruikt wordt. Dit is een verantwoordelijkheid die in de klassen zelf aangelegd wordt en niet alleen aanwezig is in de User Interface.\
In het geval van een onjuiste situatie wordt een foutmelding gegeven. Een foutmelding genereer je in C# door een Exception te ‘throwen’.\
`throw new System.DivideByZeroException();`\
Een veel voorkomend type is het `InvalidOperationException` en `ArgumentOutOfRangeException`. Je kunt ook overerven van deze typen en bijvoorbeeld `NegativeAgeException` maken en gebruiken, wanneer gepoogd wordt een leeftijd met een negatieve waarde te vullen.  

Wanneer een exception optreedt, wordt het uitvoeren van de normale flow van de applicatie onderbroken. Daarom dienen exceptions met een try-catch statement afgevangen te worden. Wanneer een exception niet door de applicatie afgevangen wordt dan wordt het uitvoeren van de applicatie onderbroken. De .NET runtime vangt dan de exception af waardoor het onderliggende besturingssysteem normaal blijft opereren. Om dit in werking te zien kun je een applicatie uitvoeren in de release modus en starten vanuit de bin/release map.

Een exception is een uitzondering (letterlijke vertaling). Alle operaties zouden eerst gevalideerd kunnen worden voordat ze aangegaan worden. Om gegevens in een database op te slaan kan heel veel mis gaan: Netwerk fout, server fout, database fout, rechten fout, tabel fout, kolom fout, regel fout etc. Maar om  bij iedere interactie met de database alles opnieuw te valideren, kost onnodig veel tijd, wanneer het toch meestal zonder fouten werkt. Wanneer het een keer niet werkt, treedt de uitzondering op, dat is de typische Exception.

Gebruik een exception nooit om de normale flow van een applicatie te bepalen. Je valideert altijd eerst input om het uitvoeren van exceptions te voorkomen en valt er alleen op terug wanneer een UI-developer bijvoorbeeld vergeten is om input te valideren. We implementeren Exceptions wel in de Business laag, maar verwachten niet dat er op geleund wordt.

#### Unit Testing
Voeg een Unit-Test project toe aan je solution. Er zijn verschillende unit-test frameworks: MsTest, nUnit of xUnit, de laatste twee genoemde zijn de populairste en worden aanbevolen. Gebruik MsTest dus niet! Maak mappen aan in je test project om de testen te groeperen. Let op de naamgeving van de mappen, code bestanden en de test procedures. Daar zijn standaarden voor, maar consistentie en een logische structuur is het belangrijkste.  

Schrijf testen voor alle gespecificeerde functionaliteiten uit deel 1 van de opdracht en schrijf ook testen om te controleren of de door jou geïmplementeerde Exceptions ook optreden bij onjuiste aanroepen of invalide gegevens.

Sommige softwarebedrijven hechten veel waarde aan een hoge code coverage met unit-testen. Dan is minimaal 80% heel gebruikelijk. Een hoge code coverage zegt alleen niets over de kwaliteit van de geteste code. Slechte programmeurs schijven namelijk ook slechte testen. Het schrijven van een goede test helpt je bij het schrijven van goede code. Door eerst na te denken wat fout kan gaan en code te vereenvoudigen in opzichzelfstaande onderdelen verbeter je de kwaliteit en de testbaarheid van de code. Met 'unit' wordt een 'unit of work' bedoeld, dat is een onderdeel (meestal een method) in de code dat de verantwoordelijkheid heeft om maar 1 ding te doen. Voor dezelfde unit kunnen meerdere testen geschreven worden het gedrag bij verschillende scenario's aan te tonen.

### Belangrijk
Welke code is het belangrijkste om te testen met een unit-test? Dat is de code in de business laag! Schrijf niet alleen unit-tests voor de happy flow maar ook voor de unhappy- of evil-flow.

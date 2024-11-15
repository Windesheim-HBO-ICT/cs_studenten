# Memory Spel
**Onderwerpen:** Object oriëntatie, applicatielagen, grafische UI, unit-testen  
**Complexiteit:** (college, homework) scaffold (no), advanced

## Opdrachtbeschrijving
Maak een memory spel met verschillende grafische interfaces (Console en WPF of MAUI). In de applicatiearchitectuur worden lagen aangebracht.

## Functionele eisen
Het basis memory spel kan door 1 speler gespeeld worden en heeft minimaal 10 kaarten (5 paren). Van een uitgespeeld spel wordt een score berekent en alleen bijgehouden in een lijst van highscores wanneer de score in de top 10 valt.
De highscore wordt berekend op basis van het aantal kaarten en de tijdsduur waarmee het spel uitgespeeld wordt. Het aantal kaarten telt dubbel zo zwaar mee als het aantal pogingen en de tijdsduur. Over alle gespeelde spellen wordt een top 10 van highscores bijgehouden.

## Non-functionele eisen
-	Het spel kan gespeeld worden in een Console én in een WPF (of MAUI) applicatie.
-	De applicatie is opgebouwd in lagen, waarbij UI, Business en Data Access gescheiden zijn. De Business-laag heeft daarbij geen referenties naar andere lagen. En de Business-laag specificeert met een repository interface de communicatie naar de dataopslag. De Data Access-laag geeft implementatie aan deze interface.
-	De oplossing maakt gebruik van zelf gedefinieerde class libraries, classes, interfaces, enums, methods, properties, constructors, events, delegates en exceptions.
-	Kwaliteit is in de code aangebracht door o.a. dubbele code te vermijden, standaard naamgevingsconventies aan te houden, defensieve aard van de code en het voorzien van commentaar op een gestandaardiseerde manier.
-	Implementeer de applicatie in lagen waarbij het domein als een geïsoleerde laag getest kan worden met unit-testing. Er zijn unit-testen geschreven voor alle business functionaliteiten. Er wordt rekening gehouden met de impliciete scenario’s die voortvloeien uit de gestelde eisen.
-	De high-scores worden opgeslagen in een database of een andere vorm van gestructureerde gegevensopslag.
-	In WPF (of MAUI) wordt gebruik gemaakt van databinding.

## Test procedure (eisen tijdens aftekenmoment)
-	Speel een een spel in een WPF (of MAUI) applicatie en toon de highscores.
-	Voer unit-testen uit.
-	Toon implementaties en licht ontwerpkeuzes toe (o.a. Data Binding en de repository interface).

## Test resultaat (eisen tijdens aftekenmoment)
-	Het spel is gespeeld, de score wordt getoond en is alleen opgeslagen wanneer het een top 10 highscore is.
-	De unit-testen slagen en tonen de correcte werking van de gestelde eisen aan.
-	Ontwerpkeuzes zijn toegelicht, waarmee de kwaliteit van de code en architectuur aangetoond is.


## Ondersteunende informatie
Een memory spel is een spel waarbij meerdere kaarten op de kop de liggen. Per beurt mogen twee kaarten omgedraaid worden. Wanneer twee dezelfde kaarten omgedraaid worden, blijven ze omgedraaid liggen anders worden ze weer terug gedraaid. Wanneer alle kaarten omgedraaid zijn is het spel afgelopen en wordt de score getoond. 

### Highscore
Van de gespeelde spellen wordt een lijst van highscores bijgehouden. Alleen wanneer een highscore in de top 10 komt, wordt de score opgeslagen.
Het aantal kaarten, de tijd en het aantal pogingen bepalen de score. ((Aantal kaarten)<sup>2</sup> / (Tijd in seconden * aantal pogingen)) * 1000

|**Aantal kaarten**| **Tijd**| **Aantal pogingen**| **Score**|
|--|--|--|--|
|4|10|2|(16 / 20 wordt 0,8) * 1000 => score:  800|  
|10|20|5|(100 / 100 wordt 1) * 1000 => score: 1000|
|4|20|2|(16 / 40 wordt 0,4) * 1000 => score: 400|
|4|10|3|(16 / 30 wordt 0,53) * 1000 => score: 533|

### Verduidelijking van de eisen
-	Van iedere unieke kaart zijn er maximaal twee in een spel.
-	Kaarten worden willekeurig gepositioneerd bij ieder spel dat gespeeld wordt.
-	Wanneer het spel gestart wordt liggen alle kaarten omgekeerd.
-	Voor iedere unieke kaart is een duplicaat in het spel.
-	De weergave van de highscores bevat minimaal de naam van de speler, de score en het aantal kaarten van het gespeelde spel.
-	Het spel in de Console applicatie heeft standaard 5 unieke kaarten die bijvoorbeeld een nummer, teken, tekst of figuur met of zonder kleur weergeven.
-	Het spel in de WPF (of MAUI) applicatie kan gespeeld worden met eigen afbeeldingen op de kaarten en kan het aantal kaarten ingesteld worden.

### Applicatie architectuur
-	Zet de applicatie in lagen op volgens de ‘The big three’: UI, Business, DataAccess.
-	Begin met een opzet in de code waarbij de logica van het spel getest kan worden zonder dat de UI- of gegevensopslag-laag geladen wordt.
-	Je hebt een solution met (minimaal) één project voor de Console applicatie, één project voor de WPF (of MAUI) applicatie en één voor de business logica en één voor de data access logica. Het project voor de business logica heeft geen verwijzing naar een van de andere projecten. De andere projecten mogen wel naar elkaar of naar het business project verwijzen.
-	Houd de referentie architectuur aan: [https://github.com/Windesheim-HBO-ICT/cs_studenten/Project%20Referentie%20Materiaal/Realisatie/todo](https://github.com/Windesheim-HBO-ICT/cs_studenten/tree/main/Project%20Referentie%20Materiaal/Realisatie/todo)

### Database aanmaken
Gebruik in Visual Studio de SQL Server Object Explorer om een MsSql LocalDb database aan te maken. Een andere mogelijkheid is een SqLite of MariaDb database. Je kunt een designer gebruiken om een tabel aan te maken of een create table script uitvoeren. 

### Testen met Moq
Mocking helpt je om het gedrag van het object dat je wilt testen te isoleren van zijn afhankelijkheden. De "mocks" zijn gesimuleerde versies van objecten of componenten waarvan de code die je wilt testen gebruik maakt. 

![img_5.png](img_5.png)

-	NuGet package Moq toevoegen aan testproject via NuGet Package manager
-	Mock de data access laag zodat de business laag getest kan worden zonder dat een ander project aangesproken hoeft te worden. Er is dus geen Sql-Server database nodig om unit-testen uit te voeren. De mock vervangt dus de data-access laag én de database met data.

### Extra uitdaging (optioneel)
Mocht je extra uitdaging willen dan kun je de volgende uitbreidingen aanbrengen:
-	Het aantal kaarten kan ingesteld worden.
-	Eigen afbeeldingen van kaarten kunnen ingevoerd en opgeslagen worden en gebruikt worden bij nieuwe spellen.
-	In plaats van een match op twee gelijke kaarten, kunnen spellen gespeeld worden waarbij er drie (of meer) gelijke kaarten omgedraaid moeten zijn.
-	De kaarten bewegen en verplaatsen zich, bijvoorbeeld op een draaiplaat of in een cirkel.
-	MVVM wordt als UI pattern in WPF (of MAUI) aangehouden.
-	Het spel kan met meerdere spelers gespeeld worden (in toenemende moeilijkheid: in hetzelfde venster, op hetzelfde systeem met meerdere applicaties, over verschillende systemen in een netwerk).
-	Stel de applicatie beschikbaar, waarbij deze geïnstalleerd en gebruikt kan worden buiten de ontwikkelomgeving om.

Uiteraard mag je zelf ook de opdracht uitbreiden met je eigen ideeën.




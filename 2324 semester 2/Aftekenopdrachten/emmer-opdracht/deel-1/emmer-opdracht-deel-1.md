# Emmer opdracht - DEEL 1

**Onderwerpen:** class design, implementing properties, constructor chaining, inheritance, overloading, enum, unit-testing  
**Complexiteit:** intermediate

## Beschrijving  
In deze opdracht pas je object oriëntatie toe om een emmer, regenton en olievat te maken. In een eenvoudige applicatie toon je aan dat deze correct gevuld en geleegd kunnen worden. 
Functionele eisen
-	De capaciteit geeft aan hoeveel er in een emmer, regenton of olievat kan
-	De inhoud geeft aan hoeveel er in een emmer, regenton of olievat zit. 
-	De capaciteit en inhoud van een emmer, regenton en olievat kan niet negatief zijn.
-	De maximale capaciteit van een emmer is nooit meer dan 2500. 
-	De capaciteit en inhoud van een emmer, regenton en olievat moet uitgelezen kunnen worden (public property).
-	De inhoud van een emmer, regenton en olievat moet ingesteld kunnen worden (public property).
-	Een emmer, regenton en olievat kun je vullen en legen met een bepaalde hoeveelheid. Deze hoeveelheid wordt dan aan de inhoud toegevoegd of in mindering gebracht (implementeer een public method).
-	Een emmer, regenton of olievat kun je in één keer legen (implementeer een public method) 
-	De standaard capaciteit van een emmer is 12, maar de capaciteit kan ook ingesteld worden tijdens het aanmaken, en de minimum capaciteit is 10.
-	De capaciteit van een olievat is altijd 159.
-	De capaciteit van een regenton kan alleen 80, 100 of 120 zijn.
-	De capaciteit van een emmer, regenton of olievat mag na het aanmaken niet meer aangepast worden.
-	Een emmer kan gevuld worden een andere emmer. De inhoud van de andere emmer wordt dan gebruikt om de emmer te vullen.

## Non-functionele eisen
-	Alle Emmer, Regenton en Olievat functionaliteiten worden in een class-library geïmplementeerd
-	Alle (gebruikers en) grafische functionaliteiten worden in een Console Application geïmplementeerd
-	De standaard naamgevingsconventies worden aangehouden, gebruik Engels
-	Vermijd dubbele, overbodige code.

## Test procedure
-	Voer de Console Applicatie uit, waarbij zonder gebruikerinteractie een of meerdere emmers, regentonnen en olievaten gebruikt worden. 
- 
## Test resultaat
-	Het uitvoeren van de console applicatie toont tekst in beeld, waaruit blijkt dat voldaan wordt aan de gestelde eisen.
-	Er wordt een lijst geprint van de uitgevoerde acties en resultaten om de correcte werking van de gestelde eisen aan te tonen. 
-	Er is rekening gehouden met de impliciete en ongewenste scenario’s die voortvloeien uit de gestelde eisen en dubbele of overbodige code wordt voorkomen.

## Ondersteunende informatie  
In de uitwerking maak je gebruik van de volgende object georiënteerde principes en technieken:
-	Abstraction, encapsulation, inheritance en polymorphism
-	Properties
-	Methods
-	Conditional logic
-	Method and constructor overloading
-	Access modifiers
-	Constants
-	Class inheritance
-	Constructor chaining
-	Enum
-	Type conversion, casting

Je kunt de bovenstaande lijst van oo-principes gebruiken om online hulp te zoeken of om te valideren of je ze wel allemaal hebt toegepast.

In deze opdracht maak je wel een console applicatie, maar verwerkt je geen gebruikersinput (om onnodige complexiteit te voorkomen). Werk de scenario's dus 'hard-coded' uit.  

De opdracht bestaat uit meerdere delen. De delen sluiten aan op de inhoud van de colleges. Later ga je dus met deze opdracht verder.

Gebruik de volgende naamgeving:
Klassen:
	Emmer -> Bucket
	Regenton -> Rainbarrel
	Olievat -> Oilbarrel

Properties:
	Capacity
	Content

Methods:
	Vullen -> Fill
	Legen -> Empty

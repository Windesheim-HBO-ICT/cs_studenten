# Studiefinanciering**



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Basis        | College      | Nee          | Ja               | delegates, events, event handlers      |


## Beschrijving  
In deze opdracht werk je in een bestaand project met event handlers en events. Je gaat het uitbetalings-'event' van de studiefinanciering hacken, zodat een bepaalde student meer of misschien zelfs het volledige landelijke budget ontvangt.

## Functionele Vereisten:  
- Voeg een nieuwe student aan het programma toe.
- Abonneer de student op de uitbetaling van studiefinanciering


## Niet-functionele Vereisten: 
- Er wordt voortgebouwd op het project dat te downloaden is van GitHub (zelfde map, zie Opdracht_studiefinanciering)
- Alle code is geschreven binnen de region 'Opdracht' (zie Program.cs in het opstartproject)

## Testprocedure:  
1. Start het programma.

## Testresultaat:  
- De bedragen van de bankrekeningen van alle studenten worden geprint in het scherm.
- De nieuw toegevoegde student ontvangt een hoger bedrag dan de andere studenten.

## Ondersteunende Informatie
Neem eerst alle code van de projecten door. Plaats een breakpoint op interessante plekken in de code en voer het programma stap voor stap uit in de debug modus. Inspecteer de objecten en gebruik daarvoor de 'Locals' en 'Call Stack' deelvensters. Deze maak je tijdens het debuggen zichtbaar via menu Debug en dan Windows.

Extra opdracht (zie Bankrekening.cs in de StudentLibrary)
In de bankrekening klasse zit een extra stukje code waarmee bedragen met een valuta symbool geprint kunnen worden. De implementatie is gedaan volgens een 'expression bodied' syntax van C#. Als extra oefening kan gekeken worden hoe de bedragen geprint worden wanneer het saldo van de bankrekening op deze manier aangesproken wordt.
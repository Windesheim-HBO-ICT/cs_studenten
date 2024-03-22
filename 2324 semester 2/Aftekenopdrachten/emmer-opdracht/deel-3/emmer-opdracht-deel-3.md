# Opdracht Emmer - deel 3
**Onderwerpen:** Events
**Complexiteit:** novice 

## Opdrachtbeschrijving
In deze opdracht ga je verder met Opdracht Emmer - deel 1 en deel 2, waarbij je nu events gaat implementeren die gebruikt worden om te signaleren wanneer een emmer vol is of overstroomt. Met unit-testen toon je wederom aan dat je oplossing voldoet aan de gestelde nieuwe én reeds bestaande eisen. 

## Functionele eisen
-	De functionele eisen uit Opdracht Emmer - deel 1 en deel 2 blijven van toepassing.
-	Wanneer een emmer, regenton of olievat vol is, wordt dat met een event gecommuniceerd.
-	Wanneer een emmer, regenton of olievat overstroomd, wordt met een event gecommuniceerd hoeveel de container overstroomd.
-	Wanneer een emmer, regenton of olievat op het punt staat om te overstromen, wordt met een event de mogelijkheid gegeven om de overstroom hoeveelheid in te stellen of het overstromen te annuleren. (optioneel, niet verplicht voor het aftekenen)

## Technische eisen
-	Definieer eigen delegate typen voor de events.
-	De non-functionele eisen uit Opdracht Emmer -deel 1 en deel 2 blijven van toepassing.

## Test procedure
-	Schrijf een lijst van unit testen om de correcte werking van de gestelde eisen aan te tonen. Houd rekening met de impliciete en ongewenste scenario’s die voortvloeien uit de gestelde eisen.
-	Test de events met unit-tests.

## Test resultaat
-	Alle testen slagen

## Ondersteunende informatie

Gebruik de volgende naamgeving, voor de events:
	Full
	Overflowed
	Overflowing (object sender, OverflowingEventArgs args)

Gebruik voor het derde event Overflowing de standaard event signature met 'object sender' en 'EventArgs e' als basis type. Maak een nieuwe klasse en erf over van EventArgs. Gebruik deze in de oplossing waarmee het overstromen geannuleerd kan worden en waarmee gecommuniceerd kan worden met hoeveel er anders overstroomd mag worden.
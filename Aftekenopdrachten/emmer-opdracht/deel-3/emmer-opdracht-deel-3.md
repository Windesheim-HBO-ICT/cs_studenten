# Opdracht Emmer - deel 3
**Onderwerpen:** Events
**Complexiteit:** intermediate 

## Opdrachtbeschrijving
In deze opdracht ga je verder met Opdracht Emmer - deel 1 en deel 2, waarbij je nu events gaat implementeren die gebruikt worden om te signaleren wanneer een emmer vol is of overstroomt. Met unit-testen toon je wederom aan dat je oplossing voldoet aan de gestelde nieuwe én reeds bestaande eisen. 

## Functionele eisen
-	De functionele eisen uit Opdracht Emmer - deel 1 en deel 2 blijven van toepassing.
-	Wanneer een emmer, regenton of olievat vol is, wordt dat met een event gecommuniceerd.
-	Wanneer een emmer, regenton of olievat overstroomd, wordt met een event gecommuniceerd hoeveel de container overstroomd.
-	Wanneer een emmer, regenton of olievat op het punt staat om te overstromen, wordt met een event de mogelijkheid gegeven om de overstroom hoeveelheid in te stellen of het overstromen te annuleren. (optioneel, niet verplicht voor het aftekenen)

## Non-functionele eisen
-	Implementeer events waarbij custom delegates gebruikt worden of maak gebruik van bestaande delegates.
-	Houd de standaard 'object sender, eventargs e' signature aan waarbij, eventargs een afgeleide klasse is.
-	De non-functionele eisen uit Opdracht Emmer -deel 1 en deel 2 blijven van toepassing.
-	Schrijf een lijst van unit-testen om de correcte werking van de gestelde eisen aan te tonen. Houd rekening met de impliciete en ongewenste scenario’s die voortvloeien uit de gestelde eisen.
-	Test de events met unit-tests (nUnit of xUnit).

### Naamgeving
| **Events**|
|--|
|Full (object sender, EventArgs args)|
|Overflowed (object sender, OverflowedEventArgs args)|
|Overflowing (object sender, OverflowingEventArgs args)|

## Test procedure
-	Voer unit-testen uit
-	Toon implementaties en licht ontwerpkeuzes toe.

## Test resultaat
-	De unit-testen slagen en tonen de correcte werking van de gestelde eisen aan.
-	Ontwerpkeuzes zijn toegelicht, waarmee de kwaliteit van de code en testen aangetoond is.


## Ondersteunende informatie


Gebruik voor het event Overflowing de standaard event signature met 'object sender' en een afgeleide van 'EventArgs e'. Maak een nieuwe klasse en erf over van EventArgs (of zoek een betere kandidaat). Gebruik deze in de oplossing waarmee het overstromen geannuleerd kan worden en waarmee terug gecommuniceerd kan worden met hoeveel er overstroomd mag worden.
# Car Servicing



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Basis        | College      | Nee          | Ja               | delegates      |


## Beschrijving  
In deze opdracht leer je een van de mogelijkheden waarop een delegate toegepast kan worden. Je laat een garage het repareren van een ruit delegeren naar een glasreparatiebedrijf. 

## Functionele Vereisten:  
- Alle onderhoudsactiviteiten worden in het onderhoudsboekje van de auto geregistreerd. 
- Een onderhoudsactiviteit bestaat in deze opdracht enkel uit het schrijven van een registratie in het onderhoudsboekje van de auto.
- Een garage voert onderhoudsactiviteiten in de volgende volgorde uit: 'bandenspanning-service', 'olie-service', 'lampen-service', 'computer-service', 'was-, en schoonmaak-service'.
- Een auto kan bij de garage aangeboden worden voor onderhoud, en dan worden alle onderhoudsactiviteiten uitgevoerd.
- Een auto kan ook bij de garage aangeboden worden voor onderhoud, waarbij tussen de 'computer-service' en 'was-, en schoonmaak-service' een 'sterretje in ruit-service' uitgevoerd wordt.
- Een glasreparatiebedrijf voert de onderhoudsactiviteit 'sterretje in ruit-service' uit.


## Niet-functionele Vereisten: 
- Maak alleen een klassedefinitie voor de volgende entiteiten: auto, onderhoudsboekje, garage en glasreparatiebedrijf.
- Gebruik een delegate waarmee de garage de 'sterretje in raam-service' delegeert naar een glasreparatiebedrijf.
- De naam van de klasse glasreparatiebedrijf (het type) mag niet in de klasse van de garage gebruikt worden.
- Houd je aan standaard naamgevingsconventies en gebruik herkenbare en passende namen in de geschreven code.

## Testprocedure:  
1. Maak twee glasreparatiebedrijven aan: een met de naam AutoTotaalGlas en een met de naam CarGlass.
2. Maak drie auto's aan: Tesla, Ferrari en Mercedes.
3. Maak een garage aan.
4. De Tesla krijgt een standard onderhoudsbeurt (zonder glasreparatie)
5. De Ferrari krijgt een garage onderhoudsbeurt inclusief een sterretje in ruit service door AutoTotaalGlas.
6. De Mercedes krijgt een garage onderhoudsbeurt inclusief een sterretje in ruit service door CarGlass.
7. Print de onderhoudsboekjes van de auto's in het scherm.

## Testresultaat:  
- Drie onderhoudsboekjes zijn geprint in het venster met de merknamen van de auto's, de onderhoudsactiviteiten van de garage en de glasreparaties met de namen van de glasreparatiebedrijven.

## Ondersteunende Informatie
Werk in deze opdracht eerst het eenvoudige uit. Schrijf de code voor een garage, auto en het onderhoudsboekje. 

Implementatie onderhoudsboekje:
Een onderhoudsboekje kan bijvoorbeeld met een method een melding registreren en met een property alle meldingen (inclusief het merk van de auto) onder elkaar als één string terug geven. 

Implementatie auto:
Een auto hoeft alleen een merk en een onderhoudsboekje als property te krijgen. 

Implementatie garage:
Een garage hoeft (om het eenvoudig te houden) voor maar één auto tegelijkertijd onderhoud uit te voeren. Daarvoor kun je de garage een methode geven met een auto als parameter. Deze methode schrijft de onderhoudsactiviteiten in het onderhoudsboekje.


De tot nu toe geschreven code en de klassen kunnen al gebruikt worden. Schrijf de code om de auto's en de garage aan te maken. Geef de auto's een onderhoudsbeurt en print daarna de onderhoudsboekjes in het scherm.

Wanneer het eerste gedeelte correct in het verste weergegeven wordt, kan verder gegaan worden met het implementeren van de onderhoudsactiviteit 'sterretje in ruit-service'.

Implementatie glasreparatiebedrijf:
Een glasreparatiebedrijf kan netzoals een garage een methode krijgen waarmee een auto als parameter opgenomen is. In deze methode schrijft het glasreparatiebedrijf de onderhoudsactiviteit met de naam van het glasreparatiebedrijf in het onderhoudsboekje.

Implementatie delegate
Voor het delegeren van de 'sterretje in ruit-service' onderhoudsactiviteit door de garage naar het glasreparatiebedrijf, zal de garage de methode van het glasreparatiebedrijf moeten aanspreken. Daarvoor zal deze methode eerst doorgegeven moeten worden aan de garage. Dat kan als parameter, een parameter van het type delegate. Daarna kan de garage de delegate uitvoeren, waardoor de methode van het glasreparatiebedrijf aangesproken wordt. Maak daarvoor wel eerst een delegate definitie aan, die overeenkomt met de signatuur van de methode. De signature geldt als de communicatie afspraak tussen de twee objecten garage en glasreparatiebedrijf. Het return type en de parameters van de delegate definitie dienen overeen te komen met de methode van het glasreparatiebedrijf waarmee de glasreparatie uitgevoerd wordt. Gebruik de delegate definitie als type voor de parameter.







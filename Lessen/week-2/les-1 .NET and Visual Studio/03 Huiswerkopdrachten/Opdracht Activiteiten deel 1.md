## Opdracht: Activiteiten

| Complexiteit | Moment  | Scaffolding | Ondersteuning | Onderwerpen                   |
|--------------|---------|-------------|---------------|-------------------------------|
| Beginner     | College | Ja          | Ja            | C# Primitieve datatypen |

### Beschrijving
Om activiteiten te houden wil een organisator aan meerdere genodigden uitnodigingen sturen. In deze opdracht schrijf je een programma om gegevens in te voeren en om uitnodigingen weer te geven.

### Functionele Eisen
- Een organisator kan eigen gegevens invoeren zoals een naam en email. 
- Een organisator kan gegevens voor een activiteit invoeren, zoals een titel, datum en beschrijving. 
- Een organisator kan gegevens invoeren voor een of meerdere genodigden, zoals een naam en email. 
- Het invoeren van de naam van de organisator, de titel van de activiteit en de naam van de genodigde is verplicht. 

 

### Niet-functionele Eisen
- Pas primitieve datatypen toe waaronder string en datetime.
- De gebruikersinterface is een gebruiksvriendelijke Console Application
- De code moet simpel zijn, zelf een klasse definitie maken is niet toegestaan.



### Testprocedure
1. Start de applicatie en voer jezelf in als organisator, waarbij je voor een activiteit zoals bijvoorbeeld een boswandeling alle gegevens invoert en een of meerdere genodigden opgeeft.

### Testresultaat
De applicatie print de uitnodiging(en) op basis van de ingevoerde gegevens. 

### Ondersteunende Informatie
In deze opdracht ga je aan de slag met het ontwikkelen van een eenvoudig Console Applicatie met behulp van primitieve gegevenstypen. 

Suggestie voor het sjabloon voor de uitnodiging:

Beste <naam genodigde>,
Op <datum activiteit> ben je uitgenodigd voor een <titel activiteit>.
Beschrijving:
<beschrijving activiteit>
Kom je ook?

Met vriendelijke groeten,
<naam organisator>
<email organisator>



Ook als is het een console applicatie. Zorg dat de gebruikers interface er netjes uitziet en gebruikersvriendelijk is. Gebruik dus Console.Clear() om tussendoor het scherm op te schonen. Wanneer de uitnodigingen geprint worden, staan alleen de uitnodigingen op het scherm.
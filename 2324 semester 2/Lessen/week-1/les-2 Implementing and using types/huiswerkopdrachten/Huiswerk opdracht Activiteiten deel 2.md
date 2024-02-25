## Opdracht: Activiteiten

| Complexiteit | Moment  | Scaffolding | Ondersteuning | Onderwerpen                   |
|--------------|---------|-------------|---------------|-------------------------------|
| Beginner     | Huiswerk | Ja          | Ja            | Object orientation, classes, methods, properties |

### Beschrijving
Om activiteiten te houden wil een organisator aan meerdere genodigden uitnodigingen sturen. In deze opdracht schrijf je een programma om gegevens in te voeren en om uitnodiginegen weer te geven.

### Functionele Eisen
- Een organisator kan eigen gegevens invoeren zoals een naam en email.
- Een organisator kan een activiteit aanmaken, waarbij een titel, datum en beschrijving opgegeven kan worden. 
- Een organisator kan meerdere genodigden met naam en email invoeren.
- De uitnodigingen worden op het scherm geprint per genodigde.
- De naam van de organisator en de genodigden zijn verplicht, dat geldt ook de voor de titel van de activiteit.

### Niet-functionele Eisen
- Pas object oriëntatie toe en implementeer klassen met properties, methods en constructors.
- De gebruikersinterface is gebruiksvriendelijk en een Console Application.
- Voorkom dubbele of overbodige code en pas de standaard naamgevingsconventie toe.


### Testprocedure
1. Start de applicatie en voer jezelf in als organisator waarbij je voor een activiteit zoals bijvoorbeeld een boswandeling de gegevens invoert en minimaal drie genodigden opgeeft.

### Testresultaat
De applicatie print de uitnodigingen op basis van de ingevoerde gegevens.

### Ondersteunende Informatie
In deze opdracht ga je aan de slag met het ontwikkelen van een eenvoudig Console Applicatie met behulp van primitieve gegevenstypen en pas je de basis van object oriëntatie toe door klassen te implementeren met properties, methods en constructors. 

Suggestie voor het sjabloon voor de uitnodiging:

Beste <naam genodigde>,

Op <datum activiteit> ben je uitgenodigd voor een <titel activiteit>.
Beschrijving:
<beschrijving activiteit>
Kom je ook?

Met vriendelijke groeten,
<naam organisator>
<email organisator>


Maak klassedefinities voor alle entiteiten zoals organisator, activiteit, genodigde en uitnodiging. Voorzie deze (waar mogelijk) van properties, methods en constructors. Implementeer de relaties tussen objecten en kun je bijvoorbeeld een activiteit een property organisator geven.
Je kunt gebruik maken van arrays of van generic collections.

De volgende code maakt een Generic List aan voor een klasse Car en voegt er een object car aan toe:

```csharp
List<Car> cars = new List<Car>();
Cars.Add(car);
```

Ook als is het een console applicatie. Zorg dat de gebruikers interface er netjes uitziet en gebruikersvriendelijk is. Gebruik dus csharp Console.Clear() om tussendoor het scherm op te schonen. Wanneer de uitnodigingen geprint worden, zijn de uitnodigingen het enige dat op het scherm getoond wordt. Wanneer invoer verplicht is, dan geeft de applicatie dat aan en blijft de applicatie om invoer vragen.

Pas de standaardnaamgevingsconventie van C# toe (https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names).

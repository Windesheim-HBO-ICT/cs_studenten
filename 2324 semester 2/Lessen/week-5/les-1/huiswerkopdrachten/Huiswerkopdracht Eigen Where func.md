# Eigen Where func



| **Complexiteit** | **Moment**   | **Scaffold** | **Ondersteuning** | **Onderwerpen**                       |
|------------------|--------------|--------------|------------------|---------------------------------------|
| Gemiddeld        | Werkcollege      | Ja          | Ja               | linq, generics, delegates, lambda expressies      |


## Beschrijving  
Om te begrijpen hoe iets werkt kun je het nabouwen. In deze opdracht leer je de werking van Linq door zelf methodes van Linq te programmeren. Een voorbeeld van de de Where() methode wordt gegeven. Andere methodes mogen nog gemaakt worden.

## Functionele Vereisten: 
- Bouw de generic ```List<T>``` na met de ```Where()``` (zie voorbeeldcode bij ondersteunende informatie)
- Bouw de ```FirstOrDefault()``` methode na.
	Dit is een methode zonder parameters die het eerste item uit de lijst teruggeeft.
	Dit is een overloaded methode met een ```Func<T, bool>``` parameter die het eerste item uit de lijst teruggeeft die voldoet aan de lambda-expressie.
	Beide methodes geven ```null``` terug, wanneer er niet een item uit de lijst teruggegeven kan worden.
- Bouw de ```First()``` methode na.
	Dit is een methode zonder parameters die het eerste item uit de lijst teruggeeft.
	Dit is een overloaded methode met een ```Func<T, bool>``` parameter die het eerste item uit de lijst teruggeeft die voldoet aan de lambda-expressie
	Beide methodes geven een foutmelding (```InvalidOperationException```) wanneer er niet een item teruggegeven kan worden.
- Bouw de ```Any()``` methode na.
	Dit is een methode zonder parameters die met een boolean als return waarde aangeeft of er items in de lijst zitten.
	Dit is een overloaded methode met een ```Func<T, bool>``` parameter die met een boolean als return waarde aangeeft of er een item in de lijst zit die voldoet aan de lambda-expressie.


## Niet-functionele Vereisten: 
- De code is opgenomen in een class library met de naam Custom.Generics.
- De code is leesbaar en voldoet aan standaard naamgevingsconventies.
- Dubbele code wordt voorkomen.

## Testprocedure: 
1. Voeg een test project toe aan de solution
2. Schijf unit-testen om de methodes te testen
3. Voer de testen uit

## Testresultaat:  
- De unit-testen slagen

## Ondersteunende Informatie

Met deze ondersteunende informatie wordt een voorbeeld en uitleg gegeven van enkele Linq methodes van een Generic '''List<T>'''. Expressies worden uitgelegd met de rol die delegates daarin spelen.

De volgende code filtert een lijst van gebouwen. Uit deze lijst wordt een nieuwe een lijst van gebouwen die kamers hebben teruggegeven. 

```csharp
var allBuildings = new List<Building>() { 
    new Building() { AmountOfRooms = 1 }, 
    new Building() { AmountOfRooms = 10 }, 
    new Building() { AmountOfRooms = 100 } 
};

//
List<Building> buildingsWithRooms = allBuildings.Where(g => g.AmountOfRooms > 0).ToList();
```

Daarvoor wordt de ```Where()``` gebruikt. De ```Where()``` is een method waarmee je een expressie als parameter kunt meegeven. De expressie is te herkennen aan de 'pijl' in de ```g => g``` notatie en wordt ook wel een 'lambda expressie' genoemd. Met de expressie wordt een conditie geformuleerd dat op ieder gebouw in de lijst uitgevoerd wordt. Dit is te vergelijken met de WHERE van SQL. Het type van de parameter is een soort van delegate. Als argument voor de delegate parameter kan een method meegegeven worden. In plaatst een method kan ook, zoals in dit voorbeeld gedaan is, een expressie opgegeven worden. De expressie kan gezien worden als de implementatie van de methode.


```csharp
var allBuildings = new List<Building>() { 
    new Building() { AmountOfRooms = 1 }, 
    new Building() { AmountOfRooms = 10 }, 
    new Building() { AmountOfRooms = 100 } 
};

//
List<Building> buildingsWithRooms = allBuildings.Where(g => g.AmountOfRooms > 0).ToList();

bool bigBuildingExists = allBuildings.Any(g => g.AmountOfRooms > 50);
if(bigBuildingExists)
{
    Console.WriteLine("Big building exists!");
}

Building firstBuildingWith3Rooms = allBuildings.FirstOrDefault(g => g.AmountOfRooms == 3);
if(firstBuildingWith3Rooms is not null)
{
    Console.WriteLine("A building with 3 rooms is found!");
}

try
{
    Building firstBuildingWith4Rooms = allBuildings.First(g => g.AmountOfRooms == 4);
}
catch (InvalidOperationException)
{
    Console.WriteLine("Building with 4 rooms was not found!");
}
```

De bovenstaande voorbeeldcode kan overgenomen worden in een nieuw Console Application project (eventueel) in dezelfde solution als de opdracht. In dit project kan dan eerst gebruik gemaakt worden van de standaard System.Collections.Generic List<T> bibliotheek van .NET. Dat zou gedaan kunnen worden om bijvoorbeeld eerst te analyseren wat je met Linq kunt doen. Dit project kan dan je voorbeeld project zijn om het type van de parameters en return type uit te lezen. Uiteindelijk zou je de standaard generic bibliotheek ook kunnen vervangen door je eigen geschreven Utils.Generic class library aan te spreken.

Hieronder volgt een voorbeeld en basis opzet van de code die overgenomen zou kunnen worden voor je eigen Utils.Generic class library.


```csharp
public class List<T>
    {
        private T[] data;

        public List(): this(new T[0]){}
        public List(T[] data)
        {
            this.data = data;
        }

        public int Length => data.Length;

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public void Add(T item)
        {
            AddItemToArray(ref data, item);
        }

        private void AddItemToArray(ref T[] array, T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length] = item;
        }

        public List<T> Where(Func<T, bool> expression) 
        {
            T[] result = new T[0];
            foreach (var item in data)
            {
                if (expression.Invoke(item))
                {
                    AddItemToArray(ref result, item);
                }
            }
            return new List<T>(result);
        }
    }
```

In de bovenstaande code zie je een implementatie van de ```Where()``` methode. 



In dit voorbeeld wordt als return type voor de ```Where()``` een ```List<T>``` gebruikt. Dat is gedaan om de eenvoud, uiteindelijk gaat de opdracht over het implementeren van een delegate om expressies uit te voeren. De daadwerkelijke Linq bibliotheek maakt gebruik van ```IEnumerable<T>```.





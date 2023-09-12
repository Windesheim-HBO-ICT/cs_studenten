## Opdracht: C# Gevorderd - Unit Testing met Async

| **Complexiteit** | **Moment** | **Scaffold** | **Ondersteuning** | **Onderwerpen**              |
|------------------|------------|--------------|------------------|------------------------------|
| Gevorderd        | College    | Nee          | Ja               | Unit Testing, Asynchrone Code, C# Fundamenten |

### Beschrijving
In deze opdracht ga je je kennis van Unit Testing en asynchrone code combineren. Unit Testing is een essentiële praktijk binnen softwareontwikkeling, en het testen van asynchrone code voegt een extra uitdaging toe. Je zult gevraagd worden om asynchrone methoden te testen en ervoor te zorgen dat ze correct werken.

### Functionele vereisten
- Implementeer een klasse `AsyncMathUtilities` met de volgende asynchrone methoden:
    - `Task<int> AddAsync(int a, int b)`: Geeft de som van de twee ingevoerde getallen terug.
    - `Task<int> SubtractAsync(int a, int b)`: Geeft het verschil tussen de twee ingevoerde getallen terug.
    - `Task<int> MultiplyAsync(int a, int b)`: Geeft het product van de twee ingevoerde getallen terug.
- Schrijf asynchrone unit testcases voor elk van deze methoden om ervoor te zorgen dat ze correct werken.

### Niet-functionele vereisten
- Zorg voor een goede scheiding van concerns tussen de implementatie van de asynchrone methoden en de asynchrone unit testcases.
- Gebruik duidelijke namen voor testcases die de functionaliteit van elke asynchrone methode beschrijven.
- Zorg voor volledige code dekking door verschillende testscenario's te behandelen.

### Testprocedure
1. Voer de asynchrone unit testcases uit voor elke methode in de `AsyncMathUtilities` klasse.
2. Controleer of alle asynchrone testcases slagen zonder fouten.

### Testresultaat
Alle asynchrone unit testcases zijn succesvol uitgevoerd zonder enige fouten.

### Ondersteunende informatie
Asynchrone code is van cruciaal belang voor het schalen van applicaties en het vermijden van blokkering van de hoofdthread. In C# kun je asynchrone methoden markeren met het `async`-sleutelwoord en de `Task`-klasse gebruiken om asynchrone taken uit te voeren.

Voor asynchrone unit testing kun je gebruik maken van de `Microsoft.VisualStudio.TestTools.UnitTesting` namespace en de `async`- en `await`-constructies om asynchrone testcases te schrijven.

Een voorbeeld van een asynchrone testcase voor de `AddAsync`-methode kan er als volgt uitzien:
```csharp
[TestMethod]
public async Task TestAddAsyncMethod()
{
    // Arrange
    AsyncMathUtilities asyncMath = new AsyncMathUtilities();

    // Act
    int result = await asyncMath.AddAsync(5, 7);

    // Assert
    Assert.AreEqual(12, result);
}
```

#### Naamgevingsconventies
Namenconventies bij unit testing zijn belangrijk voor het behouden van consistentie, leesbaarheid en duidelijkheid in je testcode. Een goed gedefinieerde naamgevingsconventie helpt andere ontwikkelaars om het doel en de context van elke testcase te begrijpen en maakt het gemakkelijker om problemen te identificeren wanneer tests mislukken. In C# en met populaire testframeworks zoals NUnit zijn er gemeenschappelijke naamgevingsconventies die je moet volgen om ervoor te zorgen dat je unit tests georganiseerd en effectief zijn.

Hier is een uitleg van de naamgevingsconventies voor unit testing in C#:

1. **Naamgevingsconventie voor testfixture:**

   Een testfixture groepeert gerelateerde testcases samen voor een specifieke klasse of component. Het is meestal vernoemd naar de te testen klasse, gevolgd door "Tests".

   Voorbeeld: Als je de `Calculator`-klasse test, kan je testfixture worden genoemd `CalculatorTests`.

2. **Naamgevingsconventie voor testcase:**

   Een testcase is een methode die een specifiek gedrag van een component test. Het zou moeten beginnen met "Test" en daarna het scenario beschrijven dat wordt getest op een duidelijke en beknopte manier. Gebruik underscores (_) om woorden in de testnaam te scheiden.

   Voorbeeld: Als je de `Add`-methode van de `Calculator`-klasse test, kan je testcase worden genoemd `TestAdd_TweePositieveGetallen_GeeftCorrecteSom`.

3. **Naamgevingsconventie voor testmethode:**

   De daadwerkelijke testmethoden binnen een testfixture moeten een vergelijkbaar patroon volgen als de namen van testcases, maar zonder het initiële "Test"-voorvoegsel. Gebruik opnieuw underscores (_) om woorden te scheiden.

   Voorbeeld: Voortbordurend op het vorige voorbeeld kan de testmethode worden genoemd `Add_TweePositieveGetallen_GeeftCorrecteSom`.

Door deze naamgevingsconventies te volgen, wordt je testcode zelfverklarender en gemakkelijker te navigeren. Wanneer een test mislukt, helpen de beschrijvende namen om precies te identificeren welk scenario is mislukt en welk aspect van het gedrag van de component aandacht nodig heeft.

Hier is hoe de naamgevingsconventies kunnen worden toegepast op het voorbeeld van de `Calculator`:

```csharp
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void TestAdd_TweePositieveGetallen_GeeftCorrecteSom()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [Test]
    public void TestSubtract_PositiefGetalVanPositiefGetal_GeeftCorrectVerschil()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(5, 2);
        Assert.AreEqual(3, result);
    }
}
```

Door deze naamgevingsconventies te volgen, zal iedereen die je testcode leest een duidelijk begrip hebben van wat er wordt getest en waarom, wat samenwerking en onderhoud soepeler maakt.
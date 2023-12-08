### Opdracht oplossing
```csharp
using System;
using System.Threading.Tasks;

class AsyncMathUtilities
{
    public async Task<int> AddAsync(int a, int b)
    {
        await Task.Delay(100); // Simuleer asynchrone bewerking
        return a + b;
    }

    public async Task<int> SubtractAsync(int a, int b)
    {
        await Task.Delay(100); // Simuleer asynchrone bewerking
        return a - b;
    }

    public async Task<int> MultiplyAsync(int a, int b)
    {
        await Task.Delay(100); // Simuleer asynchrone bewerking
        return a * b;
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        // Hier kunnen eventueel aanvullende asynchrone testcases worden toegevoegd
    }
}
```

Dit is een oplossingssjabloon die je kunt gebruiken als startpunt. Voel je vrij om extra testcases toe te voegen en te experimenteren met de code.
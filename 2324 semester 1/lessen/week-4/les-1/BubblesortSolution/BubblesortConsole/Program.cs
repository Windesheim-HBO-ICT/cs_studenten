
using BubblesortConsole;


int[] numbers = { 8,3,5,1,6 };
Console.WriteLine($"Unsorted: { string.Join(',', numbers) }");


numbers = Sorter.Bubblesort(numbers);
Console.WriteLine($"Sorted: { string.Join(',', numbers) }");


numbers = Sorter.Bubblesort(numbers, Sorter.GreaterThan);
Console.WriteLine($"Sorted with GreaterThan method assigned to the delegate: { string.Join(',', numbers) }");


numbers = Sorter.Bubblesort(numbers, Sorter.SmallerThan);
Console.WriteLine($"Sorted with SmallerThan method assigned to the delegate: { string.Join(',', numbers) }");


Console.ReadLine();

//Conclusie:

//Doordat de vergelijking in de bubblesort via een delegate uitgevoerd wordt, kan de bubblesort verschillende methodes aanroepen om te sorteren: oplopend én aflopend.

//De vergelijkingslogica wordt gedelegeerd naar een andere methode.
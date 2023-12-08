# Week 1 Les 1 Uitbreid opdrachten - UITWERKING

## Opdracht 1 Primitives

Exercise 1: Eligibility to Vote
```csharp
Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());

bool isEligibleToVote = age >= 18;
Console.WriteLine("Eligible to vote: " + isEligibleToVote);
```

Exercise 2: Sum of Two Integers
```csharp
Console.WriteLine("Enter the first integer:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second integer:");
int num2 = int.Parse(Console.ReadLine());

int sum = num1 + num2;
Console.WriteLine("Sum: " + sum);
```

Exercise 3: Average of Three Decimal Numbers
```csharp
Console.WriteLine("Enter the first number:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number:");
double num3 = double.Parse(Console.ReadLine());

double average = (num1 + num2 + num3) / 3;
Console.WriteLine("Average: " + average);
```

Exercise 4: Vowel or Consonant
```csharp
Console.WriteLine("Enter a letter:");
char letter = char.ToLower(Console.ReadKey().KeyChar);

bool isVowel = letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
Console.WriteLine(isVowel ? "Vowel" : "Consonant");
```

Exercise 5: Personalized Greeting Message
```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Hello, " + name + "! Welcome to C# programming.");
```

These answers provide the basic functionality for each exercise. However, you can enhance them further based on your requirements or add additional error handling and input validation.

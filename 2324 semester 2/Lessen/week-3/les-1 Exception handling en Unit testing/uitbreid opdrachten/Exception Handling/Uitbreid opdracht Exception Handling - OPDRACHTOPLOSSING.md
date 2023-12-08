Certainly, here are four examples of exception handling in C#, including one related to file operations:Certainly, here are four examples of exception handling in C#, including one related to file operations:

1. **Divide by Zero Exception:**
```csharp
try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
```

2. **File Not Found Exception:**
```csharp
try
{
    string filePath = "nonexistent.txt";
    string content = File.ReadAllText(filePath);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found: " + ex.FileName);
}
catch (IOException ex)
{
    Console.WriteLine("An I/O error occurred: " + ex.Message);
}
```

3. **Index Out of Range Exception:**
```csharp
try
{
    int[] numbers = { 1, 2, 3 };
    int value = numbers[10];
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range: " + ex.Message);
}
```

4. **Custom Exception:**
```csharp
class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

try
{
    int inputValue = -5;
    if (inputValue < 0)
    {
        throw new NegativeNumberException("Negative numbers are not allowed.");
    }
}
catch (NegativeNumberException ex)
{
    Console.WriteLine("Custom exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
```

In the second example, the code attempts to read the content of a non-existent file. This results in a `FileNotFoundException`. Additionally, the code includes a catch block for `IOException`, which covers a broader range of I/O-related exceptions that could occur during file operations. This illustrates how you can handle multiple types of exceptions and provide appropriate error messages or actions based on the specific exception that occurs.

1. **Divide by Zero Exception:**
```csharp
try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
```

2. **File Not Found Exception:**
```csharp
try
{
    string filePath = "nonexistent.txt";
    string content = File.ReadAllText(filePath);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found: " + ex.FileName);
}
catch (IOException ex)
{
    Console.WriteLine("An I/O error occurred: " + ex.Message);
}
```

3. **Index Out of Range Exception:**
```csharp
try
{
    int[] numbers = { 1, 2, 3 };
    int value = numbers[10];
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Index out of range: " + ex.Message);
}
```

4. **Custom Exception:**
```csharp
class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

try
{
    int inputValue = -5;
    if (inputValue < 0)
    {
        throw new NegativeNumberException("Negative numbers are not allowed.");
    }
}
catch (NegativeNumberException ex)
{
    Console.WriteLine("Custom exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
```

In the second example, the code attempts to read the content of a non-existent file. This results in a `FileNotFoundException`. Additionally, the code includes a catch block for `IOException`, which covers a broader range of I/O-related exceptions that could occur during file operations. This illustrates how you can handle multiple types of exceptions and provide appropriate error messages or actions based on the specific exception that occurs.
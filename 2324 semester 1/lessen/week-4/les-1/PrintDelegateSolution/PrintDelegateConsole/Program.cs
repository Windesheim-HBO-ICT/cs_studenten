using PrintDelegateConsole;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("\nStarting sample Print Values:");
new PrintValues();

Console.WriteLine("\nStarting sample Multicast Print Values:");
new MulticastPrintValues();

Console.ReadLine();
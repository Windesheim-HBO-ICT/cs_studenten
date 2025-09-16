


PersonStruct marie = new PersonStruct();
marie.Name = "Marie";
PersonStruct marietje = marie;
marietje.Name = "Marietje";

Console.WriteLine($"\nValue-Type (STRUCT) marie: {marie.Name}, marietje: {marietje.Name}\n");


PersonClass jan = new PersonClass();
jan.Name = "Jan";
PersonClass jantje = jan;
jantje.Name = "Jantje";

Console.WriteLine($"\nReference-Type (CLASS) jan: {jan.Name}, jantje: {jantje.Name}\n");


Console.ReadLine();
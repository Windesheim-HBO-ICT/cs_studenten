```csharp
using System;

class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks with a normal attack.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}\nHP: {HP}\nAttack Power: {AttackPower}");
    }

    public void Jump<T>(T device)
    {
        Console.WriteLine($"{Name} is jumping using a {typeof(T).Name}!");
    }
}

class Warrior : Character
{
    public Warrior(string name)
    {
        Name = name;
        HP = 100;
        AttackPower = 30;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} swings their mighty sword!");
    }
}

class Mage : Character
{
    public Mage(string name)
    {
        Name = name;
        HP = 80;
        AttackPower = 40;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} casts a powerful spell!");
    }
}

class Rogue : Character
{
    public Rogue(string name)
    {
        Name = name;
        HP = 70;
        AttackPower = 25;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} performs a quick and sneaky attack!");
    }
}

class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior("Aldric");
        Mage mage = new Mage("Elara");
        Rogue rogue = new Rogue("Sylas");

        Character[] characters = { warrior, mage, rogue };

        foreach (Character character in characters)
        {
            character.Attack();
            character.DisplayInfo();
            character.Jump<Character>("feather"); // Use an actual instance of the device type here
            Console.WriteLine();
        }
    }
}


```
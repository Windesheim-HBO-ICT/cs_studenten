using Appels_en_Peren.Modellen;

List<Appel> appels = new () { new Appel() { Kleur = Kleur.Groen }, new Appel() { Kleur = Kleur.Rood }, new Appel() { Kleur = Kleur.Geel }, new Appel() { Kleur = Kleur.Geel } };

Console.WriteLine("\nAppels ongesorteerd:");
foreach (Appel a in appels) 
{
    Console.WriteLine($"{ a.GetType().Name }: {a.Kleur }");
}

Console.WriteLine("\nAppels gesorteerd:");
appels.Sort();
foreach (Appel a in appels) 
{
    Console.WriteLine($"{ a.GetType().Name }: {a.Kleur }");
}



var appel = new Appel();
var peer = new Peer();
Console.WriteLine($"\nEen 'appel' is {(appel.Equals(peer) ? "wel" : "niet")} vergelijkbaar met een peer, ;)");



var peren = new List<Peer>() { new Peer { Gewicht = 200 }, new Peer { Gewicht = 100 }, new Peer { Gewicht = 500 }};

Console.WriteLine("\nPeren ongesorteerd:");
foreach (Peer p in peren)
{
    Console.WriteLine($"{p.GetType().Name}: {p.Gewicht}");
}

Console.WriteLine("\nPeren gesorteerd:");
peren.Sort(new FruitGewichtVergelijker());
foreach (Peer p in peren)
{
    Console.WriteLine($"{p.GetType().Name}: {p.Gewicht}");
}

Console.ReadLine();
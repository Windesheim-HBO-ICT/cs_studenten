using FastFood;

var menu = new List<MenuItem>()
{
    new MenuItem("Hamburger",  562,  9.4,   2.5, false, true),
    new MenuItem("Milkshake",  344,   54,  0.51, true,  false),
    new MenuItem("Friet",      330,  0.4,  0.53, true,  false),
    new MenuItem("Vegaburger", 421,    7,   2.2, true,  true),
    new MenuItem("Salade",     137,  7.4,  0.66, false, true),
    new MenuItem("Burger de Luxe",  562,  9.4,   2.5, false, true)
};


//Uitwerking Fastfood (zoek en sorteer)
List<MenuItem> minderDan1GramZout_MethodSyntax = menu.Where(m => m.Zout < 1).ToList();
List<MenuItem> minderDan1GramZout_QuerySyntax = (from items in menu where items.Zout < 1 select items).ToList();


IEnumerable<MenuItem> hamburgers_MethodSyntax = menu.Where(m => m.Omschrijving == "Hamburger");
IEnumerable<MenuItem> hamburgers_MethodSyntax_CaseInsensitive = menu.Where(m => m.Omschrijving.Equals("HaMBuRGeR", StringComparison.OrdinalIgnoreCase));

IEnumerable<MenuItem> hamburgers_QuerySyntax = from items in menu 
                                               where items.Omschrijving == "Hamburger"
                                               select items;


IEnumerable<string> omschrijvingen_MethodSyntax_1 = menu.OrderByDescending(m => m.Omschrijving).Select(m => m.Omschrijving.ToUpper());
IOrderedEnumerable<string> omschrijvingen_MethodSyntax_2 = menu.Select(m => m.Omschrijving.ToUpper()).OrderByDescending(m => m);
IEnumerable<string> omschrijving_QuerySyntax = from items in menu
                                               orderby items.Omschrijving descending
                                               select items.Omschrijving;


IOrderedEnumerable<MenuItem> aflopendOpKCalOplopendOpOmschrijving_1 = menu.OrderByDescending(m => m.KCal).ThenBy(m => m.Omschrijving);
foreach (var item in aflopendOpKCalOplopendOpOmschrijving_1)
{
    Console.WriteLine($"(1) Aflopend op KCal en oplopend op Omschrijving: {item.KCal} KCal, {item.Omschrijving}");
}

IOrderedEnumerable<MenuItem> aflopendOpKCalOplopendOpOmschrijving_2 = from m in menu
                                                                      orderby m.KCal descending, m.Omschrijving
                                                                      select m;
foreach (var item in aflopendOpKCalOplopendOpOmschrijving_2)
{
    Console.WriteLine($"(2) Aflopend op KCal en oplopend op Omschrijving: {item.KCal} KCal, {item.Omschrijving}");
}




//Uitwerking Fastfood (zoek en totalen)
double maxSuiker = menu.Max(m => m.Suikers);
double gemiddeldSuiker = menu.Average(m => m.Suikers);

IEnumerable<MenuItem> itemsMetMeesteZout = menu.Where(m => m.Zout == menu.Max(m => m.Zout));
foreach (var item in itemsMetMeesteZout)
{
    Console.WriteLine($"Items met meeste zout: {item.Omschrijving} heeft {item.Zout} zout.");
}

MenuItem? minstAantalCalorieën_1 = menu.FirstOrDefault(m => m.KCal == menu.Min(m => m.KCal));
MenuItem? minstAantalCalorieën_2 = menu.OrderBy(m => m.KCal).FirstOrDefault();

IEnumerable<MenuItem> burgers_1 = from burger in menu
                                    where burger.Omschrijving.ToLower().Contains("burger")
                                    select burger;
foreach (var item in burgers_1)
{
    Console.WriteLine($"(1) Burgers: {item.Omschrijving}");
}

IEnumerable<MenuItem> burgers_2 = menu.Where(b => b.Omschrijving.ToLower().Contains("burger"));
foreach (var item in burgers_2)
{
    Console.WriteLine($"(2) Burgers: {item.Omschrijving}");
}


//Opdracht Broodbeleg
var broodbelegKeuze = new List<string>() { "jam", "kaas", "boter", "ei", "rosbief", "pindakaas", "hagelslag", "hazelnootpasta", "ham" };

var broodbelegWoordlengte_1 = broodbelegKeuze
    .Select(b => new { Woord = b, Woordlengte = b.Length })
    .Where(b => b.Woordlengte <= 4)
    .OrderBy(b => b.Woordlengte).ThenBy(b => b.Woord);

foreach (var b in broodbelegWoordlengte_1)
{
    Console.WriteLine($"{b.Woord} heeft {b.Woordlengte} karakters");
}

var broodbelegWoordlengte_2 = from b in broodbelegKeuze
                              where b.Length <= 4
                              orderby b.Length, b 
                              select new { Woord = b, Woordlengte = b.Length };
foreach (var b in broodbelegWoordlengte_2)
{
    Console.WriteLine($"{b.Woord} heeft {b.Woordlengte} karakters");
}


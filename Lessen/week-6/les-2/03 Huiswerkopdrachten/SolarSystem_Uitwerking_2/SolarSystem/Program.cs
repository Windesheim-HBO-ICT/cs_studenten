using SolarSystem.Models;
using SolarSystem.ViewModels;
using System.Security.Cryptography.X509Certificates;

var mercury = new Planet("Mercury", 4879, new Orbit(57.9, 88.0), new Temperature(-173, 427), 0);
var venus = new Planet("Venus", 12.104, new Orbit(108.2, 224.7), new Temperature(462), 0);
var earth = new Planet("Earth", 12.756, new Orbit(149.6, 365.2), new Temperature(-88, 58), 1);
var mars = new Planet("Mars", 6805, new Orbit(227.9, 1.9*365.2), new Temperature(-63), 2);
var ceres = new DwarfPlanet("Ceres", 950, new Orbit(413.7, 4.6*365.2),new Temperature(-105), 0);
var jupiter = new Planet("Jupiter", 142.984, new Orbit(778.3, 11.9*365.2), new Temperature(-108), 67);
var saturn = new Planet("Saturn", 120536, new Orbit(1400000, 29.5 * 365.3), new Temperature(-139), 62);
var uranus = new Planet("Uranus", 51118, new Orbit(4500000, 84.0 * 365.2), new Temperature(-197), 27);
var neptune = new Planet("Neptune", 49528, new Orbit(4500000, 164.8*364.2), new Temperature(-201), 14);
var pluto = new DwarfPlanet("Pluto", 2306, new Orbit(5900000, 246.0 * 365.2), new Temperature(-229), 5);
var haumea = new DwarfPlanet("Haumea", 1518 + 1960 / 2, new Orbit(6400000, 283.3 * 365.2), new Temperature(-241), 2);
var makemake = new DwarfPlanet("Makemake", 1434, new Orbit(6900000, 309.9 * 365.2), new Temperature(-239), 0);
var eris = new DwarfPlanet("Eris", 2326, new Orbit(10100000, 560.9*365.2), new Temperature(-231), 1);

var sun = new Star("Sun", 1392.684, new Temperature(15000000), new Temperature(5500), new List<PlanetBase>([mercury, venus, earth, mars, ceres, jupiter, saturn, uranus, neptune, pluto, haumea, makemake, eris]));



Console.WriteLine("\nToon de namen van alle planeten van de zon oplopend gesorteerd op naam."); 

IEnumerable<string?> planetNames_m = sun.Planets.Select(p => p.Name).OrderBy(p => p);
IEnumerable<string?> planetNames_q = from p in sun.Planets
                                     orderby p.Name
                                     select p.Name;
foreach (string? planetName in planetNames_m) 
{
    Console.WriteLine($"\t{planetName}");
}



Console.WriteLine("\nToon de namen en temperaturen van de planeten van de zon waarvan de oppervlaktetemperatuur boven nul kan zijn.");

IEnumerable<string?> planetsWithTemperatureAboveZero_m = sun.Planets.Where(p => p.SurfaceTemperature.Maximum > 0).Select(p => p.Name).OrderBy(p => p);
IEnumerable<string?> planetsWithTemperatureAboveZero_q = from p in sun.Planets
                                                         where p.SurfaceTemperature.Maximum > 0
                                                         orderby p.Name
                                                         select p.Name;
foreach (string? planetName in planetsWithTemperatureAboveZero_m) 
{
    Console.WriteLine($"\t{planetName}");
}



Console.WriteLine("\nZoek de eerste planeet van de zon met de naam Jupiter, tel en toon het aantal manen van Jupiter als volgt: '<planeet> heeft <aantal> manen.'");

string? jupiterMoonsCount_m = sun.Planets.Where(p => p.Name == "Jupiter")
                                        .Select(p => $"{p.Name} heeft {p.Moons.Count} manen.")
                                        .FirstOrDefault();
string? jupiterMoonCount_q = (from p in sun.Planets
                            where p.Name == "Jupiter"
                            select $"{p.Name} heeft {p.Moons.Count} manen.").FirstOrDefault();
Console.WriteLine($"\t{jupiterMoonsCount_m}");



Console.WriteLine("\nZoek de planeten van de zon waar een ‘p’ en een ‘t’ in de naam zit");

IEnumerable<string?> planetsWithPAndTinName_m = sun.Planets.Where(p => p.Name is not null && (p.Name.Contains("p") || p.Name.Contains("t"))).Select(p => p.Name);
IEnumerable<string?> planetenMetPAndTInName_q = from p in sun.Planets
                                               where p.Name is not null && (p.Name.Contains("p") || p.Name.Contains("t"))
                                               select p.Name;
foreach (var planetName in planetsWithPAndTinName_m)
{
    Console.WriteLine($"\t{planetName}");
}



Console.WriteLine("\nToon de namen van alle planeten van de zon aflopend gesorteerd in een Array op de lengte van de naam.");
// omdat de naam nullable is wordt er een controle gedaan met een "ternary conditional operator"
string?[] planetNamesSortedByLength_m = sun.Planets.Select(p => p.Name).OrderByDescending(p => p is null ? 0 : p.Length).ToArray();
// correcte sortering is niet gevalideerd, TODO: test sorteren op nullable string in linq query syntax met "Null-conditional operator"
string?[] planetNamesSortedByLength_q = (from p in sun.Planets
                                            orderby p.Name?.Length descending
                                            select p.Name).ToArray();
foreach (string? planetName in planetNamesSortedByLength_m)
{
    Console.WriteLine($"\t{planetName} ({planetName?.Length})");
}


Console.WriteLine("\nToon de naam en diameter van alleen de planeten (geen dwergplaneten) aflopend gesorteerd op diameter");

IEnumerable<string> planetNamesAndDiameters_m = sun.Planets
                                                    .OfType<Planet>()
                                                    .OrderByDescending(p => p.Diameter)
                                                    .Select(p => $"{p.Name}, diameter: {p.Diameter}");
IEnumerable<string> planetNamesAndDiameters_q = from p in sun.Planets.OfType<Planet>()
                                                   orderby p.Diameter descending
                                                   select $"{p.Name} diameter: {p.Diameter})";
foreach (var planetNameAndDiameter in planetNamesAndDiameters_m)
{
    Console.WriteLine($"\t{planetNameAndDiameter}");
}


Console.WriteLine("\nToon de naam en het aantal manen van alle dwergplaneten aflopend gesorteerd op het grootste aantal manen.");

IEnumerable<string> dwarfPlanetNamesAndMoonCount_m = sun.Planets
                                                            .OfType<DwarfPlanet>()
                                                            .OrderByDescending(p => p.Moons.Count)
                                                            .Select(p => $"{p.Name}, moons: {p.Moons.Count}");
IEnumerable<string> dwarfPlanetNamesAndMoonCount_q = from p in sun.Planets.OfType<DwarfPlanet>()
                                                     orderby p.Moons.Count descending
                                                     select $"{p.Name}, moons: {p.Moons.Count}";
foreach (string planetNameAndMoonCount in dwarfPlanetNamesAndMoonCount_m)
{
    Console.WriteLine($"\t{planetNameAndMoonCount}");
}


Console.WriteLine("\nTel het totaalaantal manen van alle planeten van de zon");

int totalMoonCount_m = sun.Planets.Sum(p => p.Moons.Count);
int totalMoonCount_q = (from p in sun.Planets
                        select p.Moons.Count).Sum();
Console.WriteLine($"\tTotal moons count: {totalMoonCount_m}");


Console.WriteLine("\nToon de gemiddelde oppervlaktetemperatuur over alle planeten van de zon");

double? averageTemperature = sun.Planets.Average(p => p.SurfaceTemperature.Value);
Console.WriteLine($"\t{double.Round(averageTemperature.Value)}");

Console.WriteLine("\nTel en toon het aantal planeten en dwergplaneten.");
IEnumerable<ItemCountViewModel> planetsCountByClass_m = sun.Planets
                                                            .GroupBy(p => p.Class)
                                                            .Select(g => new ItemCountViewModel(g.Key, g.Count()));
IEnumerable<ItemCountViewModel> planetsCountByClass_q = from p in sun.Planets
                                                         group p by p.Class into grp
                                                         select new ItemCountViewModel(grp.Key, grp.Count());
foreach (var planetCountByClass in planetsCountByClass_m)
{
    Console.WriteLine($"\tEr zijn {planetCountByClass.Count} van het type {planetCountByClass.Item}");
}


Console.WriteLine("\nToon het type planeet en tel het aantal manen per type planeet en sorteer aflopend op aantal.");
IEnumerable<ItemCountViewModel> countPlanetsWithMoonCount_m = sun.Planets
                                                    .GroupBy(p => p.Class)
                                                    .Select(g => new ItemCountViewModel(g.Key, g.Sum(p => p.Moons.Count)))
                                                    .OrderByDescending(ccvm => ccvm.Count);
IEnumerable<ItemCountViewModel> countPlanetsWithMoonCount_q = from p in sun.Planets
                                                              group p by p.Class into grp
                                                              orderby grp.Count() descending
                                                              select new ItemCountViewModel (grp.Key, grp.Count());
foreach (var itemCount in countPlanetsWithMoonCount_m)
{
    Console.WriteLine($"\tPer type {itemCount.Item} zijn er {itemCount.Count} manen.");
}  



Console.WriteLine("\nTel het totaalaantal planeten, totaalaantal dwergplaneten en totaalaantal manen en toon dit aflopend op aantal.");
IEnumerable<ItemCountViewModel> countPlanetsAndMoons_m = sun.Planets
                                                    .GroupBy(p => p.Class)
                                                    .Select(g => new ItemCountViewModel(g.Key, g.Count()))
                                                    .Union([new ItemCountViewModel("Moon", sun.Planets.Sum(p => p.Moons.Count))])
                                                    .OrderByDescending(ccvm => ccvm.Count);
foreach (var itemCount in countPlanetsAndMoons_m)
{
    Console.WriteLine($"\tEr zijn {itemCount.Count} van het type {itemCount.Item}");
}
//Btw. Geen oplossing met LINQ query-syntax, ondersteuning voor union ontbreekt


Console.WriteLine("\nToon de twee planeten die het dichts bij elkaar staan (op basis van gemiddelde afstand tot de zon)");
DistanceBetweenPlanetsViewModel planetsClosestToEachOther = sun.Planets.Join(sun.Planets, 
    firstPlanets => true,
    secondPlanets => true, 
    (firstPlanets, secondPlanets) => new DistanceBetweenPlanetsViewModel(firstPlanets.Name, firstPlanets.Orbit.Distance, secondPlanets.Name, secondPlanets.Orbit.Distance)).Where(dbpvm => dbpvm.Difference > 0).OrderBy(dbpvm => dbpvm.Difference).First();



Console.WriteLine($"Planeet {planetsClosestToEachOther.FirstPlanet} en {planetsClosestToEachOther.SecondPlanet} staan het dichts op elkaar met een onderlinge afstand van {planetsClosestToEachOther.Difference} miljoen kilometer");

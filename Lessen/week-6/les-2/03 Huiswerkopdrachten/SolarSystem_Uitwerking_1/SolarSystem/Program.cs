using SolarSystem.Models;

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


//In dit project zijn de default namespaces uitgeschakeld (via de properties van het project).
using System;
using Utils.Generic;


List<Building> allBuildings = new List<Building>([
    new Building() { AmountOfRooms = 1 },
    new Building() { AmountOfRooms = 3 },
    new Building() { AmountOfRooms = 100 }]);

//Zie implementatie van de 'Where' methdod in 'Utils.Generic' project en codefile 'List'
var buildingsWithRooms = allBuildings.Where(g => g.AmountOfRooms > 0);

bool bigBuildingExists = allBuildings.Any(g => g.AmountOfRooms > 50);
if (bigBuildingExists)
{
    Console.WriteLine("Big building exists!");
}

Building? firstBuildingWith3Rooms = allBuildings.FirstOrDefault(g => g.AmountOfRooms == 3);
if (firstBuildingWith3Rooms is not null)
{
    Console.WriteLine("A building with 3 rooms is found!");
}

try
{
    Building firstBuildingWith4Rooms = allBuildings.First(g => g.AmountOfRooms == 4);
}
catch (InvalidOperationException)
{
    Console.WriteLine("Building with 4 rooms was not found!");
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{

    public abstract class PlanetBase: CelestialBody
    {
        public ICollection<Moon> Moons { get; set; }
    
        public PlanetBase(string name, double diameter, Orbit orbit, Temperature surfaceTemperature, uint amountOfMoons) : base(name, diameter, orbit, surfaceTemperature)
        {
            List<Moon> moons = new List<Moon>();
            for (int i = 0; i < amountOfMoons; i++)
            {
                moons.Add(new Moon());
            }
            Moons = moons;
        }
    }

    public class Planet : PlanetBase
    {
        public override string Class => "Planet";

        public Planet(string name, double diameter, Orbit orbit, Temperature surfaceTemperature, uint amountOfMoons) : base(name, diameter, orbit, surfaceTemperature, amountOfMoons) { }
    }
    public class DwarfPlanet : PlanetBase
    {
        public override string Class => "Dwarf Planet";

        public DwarfPlanet(string name, double diameter, Orbit orbit, Temperature surfaceTemperature, uint amountOfMoons) : base(name, diameter, orbit, surfaceTemperature, amountOfMoons) { }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class Star: CelestialBody
    {
        public Temperature CoreTemperature { get; set; }

        public override string Class => "Star";

        public double Age { get; set; }

        public IEnumerable<PlanetBase> Planets { get; private set; }

        public Star(string name, double diameter, Temperature coreTemperature, Temperature surfaceTemperature, ICollection<PlanetBase> planets): base(name, diameter, new Orbit(0,0), surfaceTemperature)
        {
            CoreTemperature = coreTemperature;
            Planets = planets;
        }
    }
}

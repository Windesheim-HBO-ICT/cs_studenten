using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public abstract class CelestialBase
    {
        public string? Name { get; set; }

        public double Diameter { get; set; }
        protected CelestialBase(string name, double diameter)
        {
            this.Name = name;
            this.Diameter = diameter;
        }
    }

    public abstract class CelestialBody : CelestialBase
    {
        public Temperature SurfaceTemperature { get; set; }

        public Orbit Orbit { get; set; }
        public abstract string Class { get; }

        protected CelestialBody(string name, double diameter, Orbit orbit, Temperature surfaceTemperature):base(name, diameter)
        {
            Orbit = orbit;
            SurfaceTemperature = surfaceTemperature;
        }

    }
}

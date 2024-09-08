using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Models
{
    public class Orbit
    {
        public double Distance { get; set; }
        public double Period { get; set; }

        public Orbit(double distance, double period)
        {
            Distance= distance;
            Period = period;
        }
    }
}

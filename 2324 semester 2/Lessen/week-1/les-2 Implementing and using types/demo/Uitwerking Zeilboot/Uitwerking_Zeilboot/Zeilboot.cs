using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_Zeilboot
{
    internal class Zeilboot
    {
        public string? Naam { get; set; }

        public int Lengte { get; set; }

        public int Zeiloppervlak { get; set; }

        public Zeilboot(string naam) 
        {
            Naam = naam;
        }

        public Zeilboot(int lengte)
        {
            Lengte = lengte;
        }

        //Belangrijk! De uitwerking is alleen goed wanneer met constructor chaining de dubbele code (initialisatie van lengte) voorkomen wordt
        public Zeilboot(int lengte, int zeiloppervlak): this(lengte)
        {
            Zeiloppervlak = zeiloppervlak;
        }
    }
}

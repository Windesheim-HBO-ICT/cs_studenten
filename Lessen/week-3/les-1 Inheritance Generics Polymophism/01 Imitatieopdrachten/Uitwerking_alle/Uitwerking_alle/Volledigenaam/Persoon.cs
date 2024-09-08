using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_alle.Volledigenaam
{

    namespace By_Overriding 
    {
        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Tussenvoegsel { get; set; }

            public virtual string VolledigeNaam => Voornaam + " " + (Tussenvoegsel + " ").TrimStart() + Achternaam;
        }

        public class Werknemer : Persoon { }; // de VolledigeNaam implementatie voor werknemer is als algemene implementatie voor alle personen in de Persoon klasse geïmplementeerd.

        public class Klant : Persoon
        {
            public override string VolledigeNaam => Achternaam + ", " + Voornaam + (" " + Tussenvoegsel).TrimEnd();
        }
    }


    namespace By_InterfaceImplementation
    {
        public interface INamable 
        {
            string VolledigeNaam { get; }
        }
        public class Persoon: INamable
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Tussenvoegsel { get; set; }

            public virtual string VolledigeNaam => Voornaam + " " + (Tussenvoegsel + " ").TrimStart() + Achternaam;
        }

        public class Werknemer : Persoon { }; // de VolledigeNaam implementatie voor werknemer is als algemene implementatie voor alle personen in de Persoon klasse geïmplementeerd.

        public class Klant: Persoon 
        {
            public override string VolledigeNaam => Achternaam + ", " + Voornaam + (" " + Tussenvoegsel).TrimEnd();
        }
    }
}

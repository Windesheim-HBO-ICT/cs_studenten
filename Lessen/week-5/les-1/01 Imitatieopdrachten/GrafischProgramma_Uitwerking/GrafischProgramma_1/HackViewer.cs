using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafischProgramma
{
    public class HackViewer
    {
        public HackViewer(Model model)
        {
            /*
            Het sleutelwoord event voorkomt dat de volgende code gecompileerd kan worden.
            Verwijder eerst het sleutelwoord 'event' in de klasse Model om de code te testen (private Observer? observer;)
            Schakel daarna de volgende regel weer in:
            */
            
            //model.observer = ShowView;
        }

        public void ShowView(Model m)
        {
            Console.WriteLine($"Hackscherm meldt: getal gewijzigd: {m.Getal}");
        }
    }
}

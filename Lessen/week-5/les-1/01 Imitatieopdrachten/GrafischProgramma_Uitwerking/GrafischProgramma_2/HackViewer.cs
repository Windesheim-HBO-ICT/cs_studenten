using GrafischProgramma_2;
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

        public void ShowView(object m, EventArgs e)
        {
            //De volgende code bevat een CAST, dit kan resulteren in een InvalidCastException, daarom geldt het advies om eerst een typecheck te doen. Hierbij dus de waarschuwing!
            Console.WriteLine($"Hackscherm meldt: getal gewijzigd: {((Model)m).Getal}");
        }
    }
}

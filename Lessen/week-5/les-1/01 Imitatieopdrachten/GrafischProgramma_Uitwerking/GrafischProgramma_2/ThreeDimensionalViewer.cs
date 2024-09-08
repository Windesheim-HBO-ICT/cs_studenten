using GrafischProgramma_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafischProgramma
{

    /// <summary>
    /// This class is not a real 3D-viewer!
    /// </summary>
    public class ThreeDimensionalViewer
    {
        public string Name { get; set; } = "Scherm";
        public ThreeDimensionalViewer(Model model)
        {
            model.AddObserver(ShowView);
        }

        public void ShowView(object m, EventArgs e)
        {
            Console.WriteLine($"{Name} meldt: getal gewijzigd: {m.Getal}");



            if (m is Model model) {
                Console.WriteLine($"{Name} meldt: getal gewijzigd: {model.Getal }");
            }
            if (e is ModelChangedEventArgs args)
            {
                Console.WriteLine($"{Name} meldt: getal gewijzigd van {args.OudGetal} naar {args.NieuwGetal}");
            }
        }
    }
}

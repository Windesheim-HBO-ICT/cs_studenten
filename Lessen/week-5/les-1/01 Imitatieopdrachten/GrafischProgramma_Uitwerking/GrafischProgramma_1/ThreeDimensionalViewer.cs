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

        public void ShowView(Model m)
        {
            Console.WriteLine($"{ Name } meldt: getal gewijzigd: { m.Getal }");
        }
    }
}

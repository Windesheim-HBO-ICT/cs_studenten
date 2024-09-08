using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.ViewModels
{
    public class DistanceBetweenPlanetsViewModel
    {
        public string FirstPlanet { get; private set; }
        public double FirstDistance { get; private set; }
        public string SecondPlanet { get; private set; }
        public double SecondDistance { get; private set; }
        public double Difference => double.Round(FirstDistance - SecondDistance);

        public DistanceBetweenPlanetsViewModel(string firstPlanet, double? firstDistance, string secondPlanet, double? secondDistance)
        {
            FirstPlanet = firstPlanet;
            FirstDistance = (firstDistance is null ? 0D : firstDistance).Value;
            SecondPlanet = secondPlanet;
            SecondDistance = (secondDistance is null ? 0D : secondDistance).Value; 
        }
    }
}

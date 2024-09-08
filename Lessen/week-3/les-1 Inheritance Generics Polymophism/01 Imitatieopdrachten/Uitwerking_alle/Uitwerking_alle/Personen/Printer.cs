using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_alle.Personen
{
    internal class Printer
    {
        public void Print(Person person) 
        {
            Console.WriteLine($"{person.Name} is a type of {person.GetType()}");
        }
    }
}

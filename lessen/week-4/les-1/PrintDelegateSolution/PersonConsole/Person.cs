using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonConsole
{
    public delegate void Gaan();

    public class Person
    {
        public Person()
        {
            Gaan ga = Lopen;

            ga();
        }

        public void Lopen() 
        {
            Console.WriteLine("Aan het lopen...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeldJeAan_Events
{

   public class NaamEventArgs: EventArgs
    {
        public string Naam { get; set; }

        public NaamEventArgs(string naam):base()
        {
             Naam = naam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafischProgramma_2
{
    public class ModelChangedEventArgs: EventArgs
    {
        public int OudGetal { get; set; }
        public int NieuwGetal { get; set; }
    }
}

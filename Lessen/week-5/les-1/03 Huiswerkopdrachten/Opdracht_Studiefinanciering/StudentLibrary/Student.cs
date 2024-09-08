using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public string Naam { get; set; }

        public Bankrekening Bankrekening { get; set; }
        public Bankrekening Spaarrekening { get; set; }

        public Student(string naam)
        {
            this.Naam = naam;
            this.Bankrekening = new Bankrekening();
            this.Spaarrekening = new Bankrekening();
        }

        public void ZetBedragOpRekening(decimal bedrag)
        {
            this.Bankrekening.Saldo += bedrag;
        }
        public void ZetBedragOpSpaarrekening(decimal bedrag)
        {
            this.Spaarrekening.Saldo += bedrag;
        }
    }
}

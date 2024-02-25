using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_alle.Generic
{
    public class Customer: Person
    {
        public override string Fullname => Surname + ", " + (SurnamePrefix + " ").TrimStart() + Firstname;
    }
}

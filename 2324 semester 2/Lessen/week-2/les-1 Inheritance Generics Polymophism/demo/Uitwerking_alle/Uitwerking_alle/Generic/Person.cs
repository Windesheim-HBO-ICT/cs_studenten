using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_alle.Generic
{
    public class Person : INamable
    {
        public string Firstname { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string SurnamePrefix { get; set; } = string.Empty;

        public virtual string Fullname => Firstname + " " + (SurnamePrefix + " ").TrimStart() + Surname;
    }
}

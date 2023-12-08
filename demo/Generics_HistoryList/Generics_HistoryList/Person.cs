using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HistoryList
{
    public abstract class Person : INameable
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public virtual string Fullname { get { return (FirstName + " " + (MiddleName + " ").TrimStart() + Surname).Trim(); } }
    }
}

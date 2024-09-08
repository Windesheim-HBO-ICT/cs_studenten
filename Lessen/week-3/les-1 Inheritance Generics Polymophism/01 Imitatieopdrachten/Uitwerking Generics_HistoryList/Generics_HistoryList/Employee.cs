using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HistoryList
{
    internal class Employee: Person
    {
        public decimal Salary { get; set; }

        public string JobTitle { get; set; }

        public override string Fullname 
        {
            get { return $"{Surname}, {FirstName} {MiddleName}"; }
        } 
    }
}

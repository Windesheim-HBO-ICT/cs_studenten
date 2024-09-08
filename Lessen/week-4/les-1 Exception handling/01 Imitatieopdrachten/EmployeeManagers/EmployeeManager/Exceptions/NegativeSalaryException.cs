using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Exceptions
{
    public class NegativeSalaryException : ArgumentOutOfRangeException
    {
        public const string NegativeSalaryMessage = "Poging om het salaris op {0} in te stellen. Een salaris kan nooit negatief zijn. Stel een positieve waarde in.";
        public NegativeSalaryException(int salary)
            : base(string.Format(NegativeSalaryMessage, salary)) { }
    }
}

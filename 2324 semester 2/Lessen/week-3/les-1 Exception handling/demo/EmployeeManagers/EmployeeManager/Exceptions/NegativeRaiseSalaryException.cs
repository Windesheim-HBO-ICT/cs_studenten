using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Exceptions
{
    public class NegativeRaiseSalaryException : ArgumentOutOfRangeException
    {
        public const string NegativeRaiseSalaryMessage = "Een salaris kan niet met 0 of een negatieve waarde van {0} verhoogd worden. Geef een positieve waarde op.";
        public NegativeRaiseSalaryException(int salaryRaise)
            : base(string.Format(NegativeRaiseSalaryMessage, salaryRaise)) { }
    }
}

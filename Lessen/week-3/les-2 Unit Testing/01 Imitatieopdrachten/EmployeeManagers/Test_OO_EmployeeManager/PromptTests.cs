using OO_EmployeeManager.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_OO_EmployeeManager
{
    public class PromptTests
    {
        [Fact]
        public void EmployeeList_ListOfEmployees()
        {
            string expected = "De volgende werknemers staan in het systeem:\n-\tAukje, salaris €25000)\n-\tJan, salaris €20000)\n-\tRenée, salaris €30000)\n";
            var prompt = new Prompt();
            string actual = prompt.EmployeeList;

            Assert.Equal(expected,actual);
        }
    }
}

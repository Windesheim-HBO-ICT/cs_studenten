using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_ActivityApp_deel_2.Models
{
    public class Invitee : Person
    {
        public Invitee(Person person)
        {
            Name = person.Name;
            EmailAddress = person.EmailAddress;
        }
    }
}

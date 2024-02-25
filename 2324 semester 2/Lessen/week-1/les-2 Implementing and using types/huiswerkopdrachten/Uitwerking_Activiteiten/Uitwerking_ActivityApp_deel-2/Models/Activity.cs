using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_ActivityApp_deel_2.Models
{
    public class Activity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }

        public Organizer Organizer { get; private set; }

        public Activity(Organizer organizer)
        {
            Title = string.Empty;
            invitees = new Invitee[0];
            Organizer = organizer;
        }

        private Invitee[] invitees;
        public Invitee[] Invitees => invitees;

        public Invitee Invite(Person person)
        {
            Invitee invitee = new Invitee(person);
            Array.Resize(ref invitees, Invitees.Length + 1);
            invitees[Invitees.Length - 1] = invitee;
            return invitee;
        }


        //De lijst van uitnodigingen wordt gegenereerd door een LINQ query, zie daarvoor het college over LINQ.
        public IEnumerable<Invitation> Invitations => invitees.Select(invitee => new Invitation(this, invitee));
    }
}

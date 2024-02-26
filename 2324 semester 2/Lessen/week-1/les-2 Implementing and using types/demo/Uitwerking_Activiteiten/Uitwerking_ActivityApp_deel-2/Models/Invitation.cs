using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_ActivityApp_deel_2.Models
{
    public class Invitation
    {
        public Activity Activity { get; set; }

        public Invitee Invitee { get; set; }

        public string EmailText =>
            $"\n-----------------------------------------------------------------\n" +
            $"Beste {Invitee.Name},\n" +
            $"Op {(Activity.Date.HasValue ? Activity.Date.Value.ToShortDateString() : "n.t.b.")} ben je uitgenodigd voor een activiteit {Activity.Title}.\nBeschrijving:\n{Activity.Description}\n" +
            $"Kom je ook?" +
            $"\n\n" +
            $"Met vriendelijke groeten,\n{Activity.Organizer.Name}\n" +
            $"{Activity.Organizer.EmailAddress}" +
            $"\n-----------------------------------------------------------------\n";

        public Invitation(Activity activity, Invitee invitee)
        {
            Activity = activity;
            Invitee = invitee;
        }
    }
}

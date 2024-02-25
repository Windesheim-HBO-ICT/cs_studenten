using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_ActivityApp_deel_2.Models
{
    public class Organizer : Person
    {

        private Activity[] activities;
        public Activity[] Activities => activities;

        public Organizer()
        {
            activities = new Activity[0];
        }

        public void Create(Activity newActivity)
        {
            Array.Resize(ref activities, activities.Length + 1);
            activities[activities.Length - 1] = newActivity;
        }


    }
}

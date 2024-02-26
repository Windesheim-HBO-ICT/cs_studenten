using Uitwerking_ActivityApp_deel_2.Models;
using Uitwerking_ActivityApp_deel_2.UI;


var ui = new UserInteraction();

var organizer = new Organizer();
organizer.Name = ui.GetInput("de naam van de organizer", true);
organizer.EmailAddress = ui.GetInput("de email van de organizer");

var activity = new Activity(organizer);
activity.Title = ui.GetInput("de titel van de activiteit", true);
activity.Date = ui.GetDateTimeInput("de datum van de activiteit");
activity.Description = ui.GetInput("de beschrijving van de activiteit");

Console.WriteLine("U kunt nu personen uitnodigen.");
bool addMoreInvitees;
do
{
    var person = new Person();
    person.Name = ui.GetInput("de naam van de persoon", true);
    person.EmailAddress = ui.GetInput("de email van de persoon");
    activity.Invite(person);
    Console.WriteLine("Wilt u meer personen uitnodigen?");
    addMoreInvitees = ui.GetInput("ja of nee").ToLower().Contains("ja");
} while (addMoreInvitees);


foreach (var invitation in activity.Invitations)
{
    Console.WriteLine(invitation.EmailText);
}
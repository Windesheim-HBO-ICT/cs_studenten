

string[] invitees = new string[0];
const string invitationMail = "Beste {0},\nOp {1} ben je uitgenodigd voor een {2}.\nBeschrijving:\n{3}\nKom je ook?\n\nMet vriendelijke groeten,\n{4}\n{5}";


Console.Write("Geef uw naam als organisator op: ");
string organizerName  = Console.ReadLine();
Console.Clear();

Console.Write("Geef uw emailadres op: ");
string organizerEmailAddress  = Console.ReadLine();
Console.Clear();

Console.Write("Geef de titel van de activiteit op: ");
string activityTitle = Console.ReadLine();
Console.Clear();

Console.Write("Geef de datum van de activiteit op: ");
DateTime activityDate = DateTime.Parse(Console.ReadLine());
Console.Clear();

Console.Write("Geef een beschrijving van de activiteit op: ");
string activityDescription = Console.ReadLine();
Console.Clear();

bool inviteMore;
do
{
    Array.Resize(ref invitees, invitees.Length + 1);
    Console.WriteLine("Geef de naam van de genodigde op.");
    invitees[invitees.Length-1] =  Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Wilt u meer personen uitnodigen?");
    Console.Write("Geef 'ja' of 'nee' op: ");
    inviteMore = Console.ReadLine().Equals("ja");
    Console.Clear();
} while (inviteMore);


foreach (string invitee in invitees)
{
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine(invitationMail, invitee, activityDate, activityTitle, activityDescription, organizerName, organizerEmailAddress);
    Console.WriteLine("-----------------------------------------------------------------");
}
using System;
using System.Collections.Generic;

public class Activity
{
    public string Name { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
}

public class ConsoleApplication
{
    private Activity activity;
    private string organizer;
    private List<string> invitees;

    public ConsoleApplication()
    {
        invitees = new List<string>();
    }

    public void PlanActivity()
    {
        Console.WriteLine("Enter the name of the activity: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the date of the activity: ");
        string date = Console.ReadLine();
        Console.WriteLine("Enter the time of the activity: ");
        string time = Console.ReadLine();
        activity = new Activity { Name = name, Date = date, Time = time };
    }

    public void InvitePeople()
    {
        Console.WriteLine("Enter the number of invitees: ");
        int numInvitees = int.Parse(Console.ReadLine());
        for (int i = 0; i < numInvitees; i++)
        {
            Console.WriteLine("Enter the name of invitee {0}: ", i + 1);
            string invitee = Console.ReadLine();
            invitees.Add(invitee);
        }
    }

    public void GenerateScenarios()
    {
        Random random = new Random();
        foreach (string invitee in invitees)
        {
            string response = random.Next(2) == 0 ? "accept" : "decline";
            Console.WriteLine("{0} has {1} the activity.", invitee, response);
        }
    }

    public void DisplayOutput()
    {
        Console.WriteLine("Organizer: {0}", organizer);
        Console.WriteLine("Invitees: {0}", string.Join(", ", invitees));
        Console.WriteLine("Activity: {0} on {1} at {2}", activity.Name, activity.Date, activity.Time);
    }

    public void Run()
    {
        Console.WriteLine("Enter the name of the organizer: ");
        organizer = Console.ReadLine();

        PlanActivity();
        InvitePeople();

        DisplayOutput();
        GenerateScenarios();

        // Additional code for confirming participation
        Console.WriteLine("Enter the number of confirmations: ");
        int numConfirmations = int.Parse(Console.ReadLine());
        for (int i = 0; i < numConfirmations; i++)
        {
            Console.WriteLine("Enter the name of the participant confirming: ");
            string confirmee = Console.ReadLine();
            Console.WriteLine("{0} has confirmed their participation.", confirmee);
        }
    }

    public static void Main(string[] args)
    {
        ConsoleApplication app = new ConsoleApplication();
        app.Run();
    }
}

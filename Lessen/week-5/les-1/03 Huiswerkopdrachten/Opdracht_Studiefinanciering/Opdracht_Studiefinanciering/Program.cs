using OverheidLibrary;
using StudentLibrary;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var janJansen = new Student("Jan Jansen");
var lisaLisasen = new Student("Lisa Lisasen");
var teunTeunsen = new Student("Teun Teunsen");

var studenten = new List<Student> { janJansen, lisaLisasen, teunTeunsen };

Studiefinanciering studiefinanciering = new Studiefinanciering(1000000);

studiefinanciering.UitbetalingEvent += new UitbetalingDelegate(janJansen.ZetBedragOpRekening);
studiefinanciering.UitbetalingEvent += new UitbetalingDelegate(lisaLisasen.ZetBedragOpRekening);
studiefinanciering.UitbetalingEvent += new UitbetalingDelegate(teunTeunsen.ZetBedragOpSpaarrekening);

#region Opdracht

// Schrijf alle code binnen deze region 'Opdracht'

// 1. Maak een nieuwe student aan (jezelf ;) en voeg deze toe aan de lijst van studenten
// 2. Abonneer op het uitbetalings event van de 'Studiefinanciering'. Voer het programma uit en controleer of de studiefinanciereing evenredig verdeeld wordt.
// 3. Hack de studiefinanciering waardoor de nieuwe student meer of zelfs het hele landelijke studiefinancieringsbudget ontvangt! (beperking: alle code dien je te schrijven binnen de region Opdracht)



#endregion

studiefinanciering.VerrichtBetalingen();

foreach (var student in studenten)
{
    Console.WriteLine($"Student {student.Naam} heeft {student.Bankrekening.SaldoInfo}, en {student.Spaarrekening.SaldoInfo} op de spaarrekening.");
}

Console.WriteLine("\nPress <ENTER> to exit..");
Console.ReadLine();
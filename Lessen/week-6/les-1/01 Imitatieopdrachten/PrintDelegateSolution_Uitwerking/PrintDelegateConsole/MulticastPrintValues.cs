using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDelegateConsole
{
    public class MulticastPrintValues
    {
        public delegate void Print(int value);

        public MulticastPrintValues()
        {
            //De onderstaande code is een uitbreiding van de opgave 'Oefening multicast delegate' in de PowerPoint

            Print print = PrintNumber;
            print += PrintMoney;

            //Uitvoeren van de delegate variabele.
            //De methodes worden aangeroepen die aan de variabele zijn toegekend
            print(30);


            //Volledig uitgeschreven manier om een methode aan een delegate variabele toe te kennen:
            //Door de constructor van de delegate te gebruiken, zoals object initialisatie.
            print += new Print(PrintNumber);
            print(3000);


            //Null check op delegate:
            Print? printNull = null;
            if (printNull is not null)
                printNull(11);

            if (printNull != null) 
                printNull(11);

            //Null check op delegate en als niet null dan aanroepen (kijk ook naar de andere properties van de delgate):
            printNull?.Invoke(11);

        }

        public void PrintNumber(int number) 
        {
            Console.WriteLine("Number: {0,-12:N0}", number);
        }
        public void PrintMoney(int money) 
        {
            Console.WriteLine("Money: {0:C}", money);        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDelegateConsole
{
    public class PrintValues
    {
        public delegate void Print(int value);

        public PrintValues()
        {
            //Delegate variabele declareren en initialiseren door er een methode aan toe te kennen
            Print print = PrintNumber;

            //Uitvoeren van de delegate variabele.
            //De methode worden aangeroepen die aan de variabele is toegekend
            print(20);

            print = PrintMoney;
            print(2000);
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

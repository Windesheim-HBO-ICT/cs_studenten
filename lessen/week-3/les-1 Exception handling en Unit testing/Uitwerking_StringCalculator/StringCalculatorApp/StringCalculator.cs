using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorApp
{
    public class StringCalculator
    {
        public int Add(string input) 
        {
            string[] inputAsArray = input.Split(',');
            int result = 0;
            for (int i = 0; i < inputAsArray.Length; i++)
            {
                int number;
                if (int.TryParse(inputAsArray[i], out number))
                {
                    result += number;
                }
                else 
                {
                    throw new FormatException($"Input {inputAsArray[i]} given to {nameof(Add)} cannot be calculated.");
                }
            }
            return result;
        }
    }
}

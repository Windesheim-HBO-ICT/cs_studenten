using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_ActivityApp_deel_2.UI
{
    public class UserInteraction
    {
        public const string GetInputMessage = "Geef {0} op: ";
        public const string RequiredMessage = "(invoer verplicht)\n";
        public string GetInput(string description, bool required = false)
        {
            description = string.Format(GetInputMessage, description);

            if (required)
            {
                description = RequiredMessage + description;
            }
            string? input = string.Empty;
            do
            {
                Console.Write(description);
                input = Console.ReadLine();
                Console.Clear();
            } while (string.IsNullOrWhiteSpace(input) && required);
            return input ?? string.Empty;
        }

        public DateTime? GetDateTimeInput(string description, bool required = false)
        {
            string? input;
            DateTime result;
            do
            {
                input = GetInput(description, required);
                if (DateTime.TryParse(input, out result))
                {
                    return result;
                }

            } while (required);

            return null;
        }
    }
}

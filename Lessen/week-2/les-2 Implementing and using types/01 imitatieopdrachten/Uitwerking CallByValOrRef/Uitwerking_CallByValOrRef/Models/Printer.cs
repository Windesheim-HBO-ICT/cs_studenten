using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_CallByValOrRef.Models
{
    internal class Printer
    {
        public void Print(Paper paper)
        {
            paper.TimesPrinted++;
        }

        public void Print(Book book)
        {
            book.TimesPrinted++;
        }


        public void PrintRef(ref Paper paper)
        {
            paper.TimesPrinted++;
        }

        public void PrintRef(ref Book book)
        {
            book.TimesPrinted++;
        }
    }
}

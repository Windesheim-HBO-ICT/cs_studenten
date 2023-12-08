using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BubblesortConsole
{
    public static class Sorter
    {
        //Bubblesort zonder delegate:
        public static int[] Bubblesort(int[] items) 
        {
            if (items is null)
            {
                return null;
            }

            int i;int j;int temp;

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (items[j - 1] > items[j])
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;   
        }


        //Uitwerking Opdracht Bubblesort met delegate:

        public delegate bool ComparisonDelegate(int first, int second);
        public static bool GreaterThan(int first, int second) 
        {
            return first > second;
        }
        public static bool SmallerThan(int first, int second) 
        {
            return first < second;
        }

        public static int[] Bubblesort(int[] items, ComparisonDelegate comparison) 
        {
            if (items is null)
            {
                return null;
            }

            int i;int j;int temp;

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (comparison(items[j - 1] , items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;   
        }

    }
}

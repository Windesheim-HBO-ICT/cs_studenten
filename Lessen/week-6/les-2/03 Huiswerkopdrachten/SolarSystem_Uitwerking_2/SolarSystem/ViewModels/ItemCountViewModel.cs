using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.ViewModels
{
    public class ItemCountViewModel
    {
        public string Item { get; private set; } 
        public int Count { get; private set; } 

        public ItemCountViewModel(string item, int count)
        {
            Item = item;
            Count = count;
        }

    }
}

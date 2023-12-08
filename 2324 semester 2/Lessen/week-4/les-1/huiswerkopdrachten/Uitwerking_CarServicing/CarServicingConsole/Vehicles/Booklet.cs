using System;
using System.Collections.Generic;

namespace CarServicingConsole.Vehicles
{
    public class Booklet
    {
        private string type;
        private ICollection<string> entries;
        public Booklet(string type)
        {
            this.type = type;
            this.entries = new List<string>();
        }

        public void AddEntry(string description)
        {
            this.entries.Add($"\t{DateTime.Now.ToShortDateString()} : {description}\n");
        }
        public string Content
        {
            get
            {
                return $"------\n{type} {nameof(Booklet).ToLower()}\n{string.Concat(this.entries)}\n------";
            }
        }
    }
}

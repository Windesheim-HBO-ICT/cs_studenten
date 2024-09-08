using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking_alle.Generic
{
    public class HistoryList<T> where T : INamable
    {
        private List<T> items = new List<T>();
        private List<string> history = new List<string>();

        public void Add(T item)
        {
            items.Add(item);
            WriteHistory(nameof(Add), item);
        }
        public void Remove(T item)
        {
            Remove<T>(item);
        }

        //De volgende code is herschreven met 'Remove<U>(U item) where U : T' door met Generic Type Contraints beperkingen op het type van de parameter af te dwingen. Hierdoor is een runtime type-check op de parameter niet meer nodig. Beide oplossingen hebben hetzelfde resultaat, maar de generic type contraint is een compiler instructie en voorkomt dus de runtime check.
        //De code is commentaar omdat het de dezelfde signature heeft met de andere oplossing.

        //public void Remove<U>(U item)
        //{
        //    if (item is T item_T)
        //    {
        //        if (items.Remove(item_T))
        //        {
        //            WriteHistory(nameof(Remove), item_T);
        //        }
        //    }
        //}

        public void Remove<U>(U item) where U : T
        {
            if (items.Remove(item))
            {
                WriteHistory(nameof(Remove), item);
            }
        }

        public void RemoveAll<U>() where U : T
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                items.Remove(items[i]);
                WriteHistory(nameof(Remove), items[i]);
            }
        }

        public IEnumerable<U> ReadAll<U>() where U : T
        { 
            return items.OfType<U>();
        }

        protected void WriteHistory(string action, T item)
        {
            history.Add($"{action}: {item.Fullname}");
        }

        public string History { get { return string.Join("\n", history.ToArray()); } }

    }
}

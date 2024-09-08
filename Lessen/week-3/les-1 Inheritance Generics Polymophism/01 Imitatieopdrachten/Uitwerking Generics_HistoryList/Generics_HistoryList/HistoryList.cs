using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Generics_HistoryList
{
    public class HistoryList<T> where T : INameable
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
            items.Remove(item);
            WriteHistory(nameof(Remove), item);
        }
        public void Remove<U>(T item)
        {
            if (item is U)
            {
                items.Remove(item);
                WriteHistory(nameof(Remove), item);
            }
        }

        public List<U> ReadItems<U>()
        {
            var resultList = new List<U>(); 
            foreach (var item in items)
            {
                if (item is U UItem)
                {
                    resultList.Add(UItem);
                }
            }
            return resultList;
        }

        protected void WriteHistory(string action, T item)
        {
            history.Add($"{action}: {item.Fullname}");
        }

        public string History
        {
            get { return string.Join("\n", history.ToArray()); }
        }

    }
}
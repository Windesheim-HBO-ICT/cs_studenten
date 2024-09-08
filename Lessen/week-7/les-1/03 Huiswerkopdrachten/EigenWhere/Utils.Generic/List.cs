
namespace Utils.Generic
{
    public class List<T>
    {
        private T[] data;

        public List() : this(new T[0]) { }
        public List(T[] data)
        {
            this.data = data;
        }

        public int Length => data.Length;

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public void Add(T item)
        {
            AddItemToArray(ref data, item);
        }

        private void AddItemToArray(ref T[] array, T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length-1] = item;
        }

        public List<T> Where(Func<T, bool> expression)
        {
            T[] result = new T[0];
            foreach (var item in data)
            {
                if (expression.Invoke(item))
                {
                    AddItemToArray(ref result, item);
                }
            }
            return new List<T>(result);
        }
    }

}

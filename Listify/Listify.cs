using System.Collections;

namespace Listify
{
    public class Listify: IList<int>
    {
        private readonly IEnumerable<int> _list;

        public Listify(int startRange, int endRange)
        {
            if (startRange > endRange)
            {
                throw new ArgumentOutOfRangeException(nameof(startRange), "Start range must be less than end range");
            }
            
            _list = Enumerable.Range(startRange, endRange);
        }

        public int this[int index]
        {
            get
            {
                if (index > _list.Count() - 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index out of range");
                }
                return _list.ElementAt(index);
            }
            set => throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _list.Count();
        public bool IsReadOnly => true;

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}

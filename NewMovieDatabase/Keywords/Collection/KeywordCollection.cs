using System;
using System.Collections;
using System.Collections.Generic;

namespace NewMovieDatabase.Keywords
{
    public class KeywordCollection : ICollection<Keyword>
    {
        List<Keyword> _innerCollection;

        public int Count { get => Count; }

        int ICollection<Keyword>.Count => _innerCollection.Count;

        bool ICollection<Keyword>.IsReadOnly => false;

        public Keyword this[int index]
        {
            get { return _innerCollection[index]; }
            set { _innerCollection[index] = value; }
        }

        void ICollection<Keyword>.Add(Keyword item)
        {
            if (_innerCollection.Contains(item))
                throw new KeywordAlreadyExistException(item);
            else
                _innerCollection.Add(item);
        }

        void ICollection<Keyword>.Clear()
        {
            _innerCollection.Clear();
        }

        bool ICollection<Keyword>.Contains(Keyword item)
        {
            return _innerCollection.Contains(item);
        }

        void ICollection<Keyword>.CopyTo(Keyword[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < _innerCollection.Count; i++)
            {
                array[i + arrayIndex] = _innerCollection[i];
            }
        }

        IEnumerator<Keyword> IEnumerable<Keyword>.GetEnumerator() => GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<Keyword> GetEnumerator() => new KeywordEnumerator(this);

        bool ICollection<Keyword>.Remove(Keyword item)
        {
            return _innerCollection.Remove(item);
        }
    }
}

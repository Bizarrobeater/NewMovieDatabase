using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NewMovieDatabase.Keywords
{
    /// <summary>
    /// Represents a collection of keywords, that can be accessed by index.
    /// Provides methods for searching, adding, removing and clearing the collection.
    /// </summary>
    public class KeywordCollection : ICollection<Keyword>
    {
        private List<Keyword> _innerCollection;

        /// <summary>
        /// Initialises an empty collection.
        /// </summary>
        public KeywordCollection()
        {
            _innerCollection = new List<Keyword>();
        }

        /// <summary>
        /// Initialises a collection that contains elements copied from the provided collection.
        /// </summary>
        /// <param name="keywords">Collection whose elements are copied to the new collection.</param>
        public KeywordCollection(IEnumerable<Keyword> keywords)
        {
            _innerCollection = keywords.ToList();
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        public int Count { get => Count; }

        /// <inheritdoc/>
        int ICollection<Keyword>.Count  { get => _innerCollection.Count;}

        /// <inheritdoc/>
        bool ICollection<Keyword>.IsReadOnly => false;

        public Keyword this[int index]
        {
            get { return _innerCollection[index]; }
            set { _innerCollection[index] = value; }
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        bool ICollection<Keyword>.Contains(Keyword item)
        {
            return _innerCollection.Contains(item);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        IEnumerator<Keyword> IEnumerable<Keyword>.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <inheritdoc/>
        public IEnumerator<Keyword> GetEnumerator() => new KeywordEnumerator(this);

        /// <inheritdoc/>
        bool ICollection<Keyword>.Remove(Keyword item)
        {
            return _innerCollection.Remove(item);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace NewMovieDatabase.TableClasses
{
    public class ColumnCollection : ICollection<Column>
    {
        protected List<Column> _innerCollection;

        public ColumnCollection()
        {
            _innerCollection = new List<Column>();
        }

        public int Count => _innerCollection.Count;

        // Makes the collection accesible with indices
        public Column this[int index]
        {
            get { return _innerCollection[index]; }
            set { _innerCollection[index] = value; }
        }

        public virtual void Add(Column item) => _innerCollection.Add(item);

        public virtual void Add(Column column, Table table)
        {
            column.AddTable(table);
            _innerCollection.Add(column);
        }

        public void Clear() => _innerCollection.Clear();

        public bool Contains(Column item)
        {
            foreach (Column column in _innerCollection)
            {
                if (column.Equals(item))
                    return true;
            }
            return false;
        }

        void ICollection<Column>.CopyTo(Column[] array, int arrayIndex)
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

        public bool Remove(Column item)
        {
            Column curColumn;

            for (int i = 0; i < _innerCollection.Count; i++)
            {
                curColumn = _innerCollection[i];

                if (curColumn.Equals(item) || curColumn.Equals(item.FullName))
                {
                    _innerCollection.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => new ColumnEnumerator(this);

        public IEnumerator<Column> GetEnumerator() => new ColumnEnumerator(this);

        bool ICollection<Column>.IsReadOnly => false;
    }
}

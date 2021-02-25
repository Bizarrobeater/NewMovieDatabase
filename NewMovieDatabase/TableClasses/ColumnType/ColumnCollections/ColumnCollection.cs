using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NewMovieDatabase.TableClasses
{
    /// <summary>
    /// Collection of columns.
    /// </summary>
    public class ColumnCollection : ICollection<Column>
    {
        protected List<Column> _innerCollection;

        public ColumnCollection()
        {
            _innerCollection = new List<Column>();
        }

        public ColumnCollection(IEnumerable<Column> columns)
        {
            _innerCollection = columns.ToList();
        }

        /// <inheritdoc/>
        public int Count => _innerCollection.Count;

        /// <inheritdoc/>
        public Column this[int index]
        {
            get { return _innerCollection[index]; }
            set { _innerCollection[index] = value; }
        }

        /// <inheritdoc/>
        public virtual void Add(Column item) => _innerCollection.Add(item);

        /// <summary>
        /// Adds a column to the collection and adds the table to the column.
        /// </summary>
        /// <param name="column">Column to add.</param>
        /// <param name="table">Table the column should be registrered to.</param>
        public virtual void Add(Column column, Table table)
        {
            column.AddTable(table);
            _innerCollection.Add(column);
        }

        /// <inheritdoc/>
        public void Clear() => _innerCollection.Clear();

        /// <inheritdoc/>
        public bool Contains(Column item)
        {
            foreach (Column column in _innerCollection)
            {
                if (column.Equals(item))
                    return true;
            }
            return false;
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => new ColumnEnumerator(this);

        /// <inheritdoc/>
        public IEnumerator<Column> GetEnumerator() => new ColumnEnumerator(this);

        /// <inheritdoc/>
        bool ICollection<Column>.IsReadOnly => false;
    }
}

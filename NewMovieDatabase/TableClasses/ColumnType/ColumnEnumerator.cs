using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses
{
    public class ColumnEnumerator : IEnumerator<Column>
    {
        private ColumnCollection _collection;
        private int _curIndex;
        private Column _curColumn;

        public ColumnEnumerator(ColumnCollection collection)
        {
            _collection = collection;
            _curIndex = -1;
            _curColumn = default(Column);
        }

        public bool MoveNext()
        {
            if (++_curIndex >= _collection.Count)
                return false;
            else
                _curColumn = _collection[_curIndex];
            return true;
        }

        public Column Current => _curColumn;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public void Reset() => _curIndex = -1;
    }
}

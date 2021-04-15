using System.Collections;
using System.Collections.Generic;

namespace NewMovieDatabase.Keywords
{
    class KeywordEnumerator : IEnumerator<Keyword>
    {
        KeywordCollection _collection;
        private int _curIndex;
        private Keyword _curKeyword;

        public Keyword Current => _curKeyword;
        object IEnumerator.Current => Current;


        public KeywordEnumerator(KeywordCollection collection)
        {
            _collection = collection;
            _curIndex = -1;
            _curKeyword = default(Keyword);
        }

        public bool MoveNext()
        {
            if (++_curIndex >= _collection.Count)
                return false;
            else
                _curKeyword = _collection[_curIndex];
            return true;
        }

        public void Reset() => _curIndex = -1;

        public void Dispose() { }
    }
}

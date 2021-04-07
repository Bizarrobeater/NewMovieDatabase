using System;

namespace NewMovieDatabase.SearchParameters
{
    public class SearchBetweenParameter<T> : SearchParameter<T> where T: IComparable<T>
    {
        protected T _secondSearchParameter;
        public SearchBetweenParameter(T firstParameter, T secondParameter)
            : base (firstParameter)
        {
            _secondSearchParameter = secondParameter;
            SortParameters();
        }

        private void SortParameters()
        {
            if (_searchParameter.CompareTo(_secondSearchParameter) >= 0)
            {
                T temp = _searchParameter;
                _searchParameter = _secondSearchParameter;
                _secondSearchParameter = temp;
            }
        }

        public override string ReturnAsSQLParameter
        {
            get 
            {
                return $"{_searchParameter} AND {_secondSearchParameter}";
            }
        }
    }
}

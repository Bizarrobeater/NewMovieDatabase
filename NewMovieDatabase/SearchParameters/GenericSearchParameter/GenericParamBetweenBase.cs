using System;

namespace NewMovieDatabase.SearchParameters
{
    public abstract class GenericParamBetweenBase<T> : GenericParam<T> where T: IComparable<T>
    {
        internal T _secondSearchParameter { get; private set; }
        internal bool _equal { get; private set; }
        protected GenericParamBetweenBase(T firstParameter, T secondParameter) : base(firstParameter)
        {
            _secondSearchParameter = secondParameter;
            SortParameters();
            _equal = firstParameter.Equals(secondParameter);
        }

        internal virtual void SortParameters()
        {
            if (_searchParameter.CompareTo(_secondSearchParameter) >= 0)
            {
                T temp = _searchParameter;
                _searchParameter = _secondSearchParameter;
                _secondSearchParameter = temp;
            }

        }
    }
}

using System;

namespace NewMovieDatabase.SearchParameters
{
    class GenericParamBetween<T> : GenericParamBetweenBase<T> where T: IComparable<T>
    {
        public GenericParamBetween(T firstParameter, T secondParameter) : base(firstParameter, secondParameter)
        {
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                if (_equal)
                    return $"= {_searchParameter}";
                else
                    return $"BETWEEN {_searchParameter} AND {_secondSearchParameter}";
            }
        }
    }
}

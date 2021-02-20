using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamNotBetween<T> : GenericParamBetweenBase<T> where T : IComparable<T>
    {
        public GenericParamNotBetween(T firstParameter, T secondParameter) : base(firstParameter, secondParameter)
        {
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                if (_equal)
                    return $"!= {_searchParameter}";
                else
                    return $"NOT BETWEEN {_searchParameter} AND {_secondSearchParameter}";
            }
        }
    }
}

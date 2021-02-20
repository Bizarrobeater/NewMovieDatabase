using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamSmallerThan<T> : GenericParam<T> where T: IComparable<T>
    {
        public GenericParamSmallerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "<";
        }
    }
}

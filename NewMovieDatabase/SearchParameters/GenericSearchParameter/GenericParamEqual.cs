using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamEqual<T> : GenericParam<T> where T: IComparable<T>
    {
        public GenericParamEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

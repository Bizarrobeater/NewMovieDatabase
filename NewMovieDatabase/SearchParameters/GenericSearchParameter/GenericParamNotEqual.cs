using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamNotEqual<T> : GenericParam<T> where T: IComparable<T>
    {
        public GenericParamNotEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "!=";
        }
    }
}

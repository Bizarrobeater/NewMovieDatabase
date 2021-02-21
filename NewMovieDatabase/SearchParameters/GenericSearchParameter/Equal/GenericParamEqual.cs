using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamEqual<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

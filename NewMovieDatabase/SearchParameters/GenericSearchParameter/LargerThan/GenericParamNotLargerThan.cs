using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamNotLargerThan<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamNotLargerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "!>";
        }
    }
}

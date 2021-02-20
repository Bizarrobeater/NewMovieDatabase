using System;

namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamLargerThan<T> : GenericParam<T> where T: IComparable<T>
    {
        public GenericParamLargerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = ">";
        }
    }
}

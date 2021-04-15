using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class GenericParamSmallerThan<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamSmallerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "<=";
        }
    }
}

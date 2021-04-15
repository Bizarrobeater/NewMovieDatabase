using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class GenericParamNotSmallerThan<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamNotSmallerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "!<";
        }
    }
}

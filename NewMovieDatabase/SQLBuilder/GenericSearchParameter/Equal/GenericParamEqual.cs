using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class GenericParamEqual<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

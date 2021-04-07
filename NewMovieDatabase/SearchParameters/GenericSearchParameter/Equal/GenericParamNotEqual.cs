using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class GenericParamNotEqual<T> : GenericParamAbstract<T> where T: IComparable<T>
    {
        public GenericParamNotEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "!=";
        }
    }
}

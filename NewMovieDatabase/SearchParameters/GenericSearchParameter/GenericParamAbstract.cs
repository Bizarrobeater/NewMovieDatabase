using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public abstract class GenericParamAbstract<T> : SearchParameter<T> where T: IComparable<T>
    {
        protected GenericParamAbstract(T searchParameter) : base(searchParameter)
        {
        }

        public override string ReturnAsSQLParameter => $"{_modifier} {_searchParameter}";
    }
}

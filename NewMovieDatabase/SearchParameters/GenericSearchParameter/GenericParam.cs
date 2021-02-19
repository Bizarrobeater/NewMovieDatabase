using System;

namespace NewMovieDatabase.SearchParameters
{
    public abstract class GenericParam<T> : SearchParameter<T> where T: IComparable<T>
    {
        protected GenericParam(T searchParameter) : base(searchParameter)
        {
        }

        public override string ReturnAsSQLParameter => $"{_modifier} {_searchParameter}";
    }
}

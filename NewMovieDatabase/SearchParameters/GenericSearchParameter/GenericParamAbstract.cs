using System;

namespace NewMovieDatabase.SearchParameters
{
    public abstract class GenericParamAbstract<T> : SearchParameter<T> where T: IComparable<T>
    {
        protected GenericParamAbstract(T searchParameter) : base(searchParameter)
        {
        }

        public override string ReturnAsSQLParameter => $"{_modifier} {_searchParameter}";
    }
}

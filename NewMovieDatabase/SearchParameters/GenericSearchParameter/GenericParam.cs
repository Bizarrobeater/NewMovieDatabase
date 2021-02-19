namespace NewMovieDatabase.SearchParameters
{
    public abstract class GenericParam<T> : SearchParameter<T>
    {
        protected GenericParam(T searchParameter) : base(searchParameter)
        {
        }

        public override string ReturnAsSQLParameter => $"{_modifier} {_searchParameter}";
    }
}

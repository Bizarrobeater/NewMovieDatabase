namespace NewMovieDatabase.SearchParameters
{
    class GenericParamNotSmallerThan<T> : GenericParam<T>
    {
        public GenericParamNotSmallerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "!<";
        }
    }
}

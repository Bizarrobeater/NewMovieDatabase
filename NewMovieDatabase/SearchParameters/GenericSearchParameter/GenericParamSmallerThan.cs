namespace NewMovieDatabase.SearchParameters
{
    class GenericParamSmallerThan<T> : GenericParam<T>
    {
        public GenericParamSmallerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "<";
        }
    }
}

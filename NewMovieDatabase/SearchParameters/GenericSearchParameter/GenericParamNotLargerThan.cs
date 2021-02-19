namespace NewMovieDatabase.SearchParameters
{
    class GenericParamNotLargerThan<T> : GenericParam<T>
    {
        public GenericParamNotLargerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = "!>";
        }
    }
}

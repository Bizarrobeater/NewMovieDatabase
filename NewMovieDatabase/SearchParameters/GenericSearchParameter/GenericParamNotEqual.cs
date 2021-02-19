namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamNotEqual<T> : GenericParam<T>
    {
        public GenericParamNotEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "!=";
        }
    }
}

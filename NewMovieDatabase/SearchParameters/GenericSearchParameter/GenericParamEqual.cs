namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamEqual<T> : GenericParam<T>
    {
        protected GenericParamEqual(T searchParameter) : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

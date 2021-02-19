namespace NewMovieDatabase.SearchParameters
{
    public class GenericParamLargerThan<T> : GenericParam<T>
    {
        public GenericParamLargerThan(T searchParameter) : base(searchParameter)
        {
            _modifier = ">=";
        }
    }
}

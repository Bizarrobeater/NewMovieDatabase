namespace NewMovieDatabase.SearchParameters
{
    public class LargerThanDecorator : ParamDecorator
    {
        public LargerThanDecorator(ISearchParameter searchParameter)
            : base(searchParameter)
        {
            _modifier = ">=";
        }
    }
}

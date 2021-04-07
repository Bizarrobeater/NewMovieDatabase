namespace NewMovieDatabase.SearchParameters
{
    public class BetweenDecorator : ParamDecorator
    {
        public BetweenDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "BETWEEN";
        }
    }
}

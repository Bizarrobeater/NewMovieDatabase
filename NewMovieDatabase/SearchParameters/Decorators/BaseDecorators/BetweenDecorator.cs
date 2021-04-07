namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "BETWEEN" keyword for the SQL string
    /// </summary>
    public class BetweenDecorator : ParamDecorator
    {

        /// <inheritdoc/>
        public BetweenDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "BETWEEN";
        }
    }
}

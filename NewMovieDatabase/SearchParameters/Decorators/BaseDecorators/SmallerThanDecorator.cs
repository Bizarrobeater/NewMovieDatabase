namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "smaller than or equal to" operator for the SQL string
    /// </summary>
    public class SmallerThanDecorator : ParamDecorator
    {
        /// <inheritdoc/>
        public SmallerThanDecorator(ISearchParameter searchParameter)
            : base(searchParameter)
        {
            _modifier = "<=";
        }
    }
}

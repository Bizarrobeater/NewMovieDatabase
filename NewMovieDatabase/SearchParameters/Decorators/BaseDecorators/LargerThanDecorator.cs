namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "larger than or equal to" operator for the SQL string
    /// </summary>
    public class LargerThanDecorator : ParamDecorator
    {
        /// <inheritdoc/>
        public LargerThanDecorator(ISearchParameter searchParameter)
            : base(searchParameter)
        {
            _modifier = ">=";
        }
    }
}

namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "smaller than or equal to" operator for the SQL string
    /// </summary>
    public class SmallerThanDecorator : BaseSearchDecorator
    {
        /// <inheritdoc/>
        public SmallerThanDecorator(ISQLCommandBuilder commandBuilder)
            : base(commandBuilder)
        {
            _modifier = "<=";
        }
    }
}

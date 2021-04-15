namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "larger than or equal to" operator for the SQL string
    /// </summary>
    public class LargerThanDecorator : SQLCommandDecorator
    {
        /// <inheritdoc/>
        public LargerThanDecorator(ISQLCommandBuilder searchParameter)
            : base(searchParameter)
        {
            _modifier = ">=";
        }
    }
}

namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "smaller than or equal to" operator for the SQL string
    /// </summary>
    public class SmallerThanDecorator : SQLCommandDecorator
    {
        /// <inheritdoc/>
        public SmallerThanDecorator(ISQLCommandBuilder commandBuilder)
            : base(commandBuilder)
        {
            _modifier = "<=";
        }
    }
}

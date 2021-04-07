namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// </summary>
    public class LikeDecorator : SQLCommandDecorator
    {
        /// <inheritdoc/>
        public LikeDecorator(ISQLCommandBuilder commandBuilder) : base(commandBuilder)
        {
            _modifier = "LIKE";
        }
    }
}

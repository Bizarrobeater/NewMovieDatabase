namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// The Search parameter is furthermore an exact search.
    /// </summary>
    public class ExactLikeDecorator : SQLCommandDecorator
    {
        /// <inheritdoc/>
        public ExactLikeDecorator(ISQLCommandBuilder searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }
    }
}

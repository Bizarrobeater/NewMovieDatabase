namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "BETWEEN" keyword for the SQL string
    /// </summary>
    public class BetweenDecorator : SQLCommandDecorator
    {

        /// <inheritdoc/>
        public BetweenDecorator(ISQLCommandBuilder searchParameter) : base(searchParameter)
        {
            _modifier = "BETWEEN";
        }
    }
}

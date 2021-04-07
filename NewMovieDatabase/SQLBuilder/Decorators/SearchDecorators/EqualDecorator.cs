namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "equal" operator for the SQL string
    /// </summary>
    public class EqualDecorator : SQLCommandDecorator
    {
        /// <inheritdoc/>
        public EqualDecorator(ISQLCommandBuilder searchParameter) 
            : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

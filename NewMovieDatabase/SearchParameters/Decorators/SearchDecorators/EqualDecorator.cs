namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "equal" operator for the SQL string
    /// </summary>
    public class EqualDecorator : BaseSearchDecorator
    {
        /// <inheritdoc/>
        public EqualDecorator(ISQLCommandBuilder searchParameter) 
            : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

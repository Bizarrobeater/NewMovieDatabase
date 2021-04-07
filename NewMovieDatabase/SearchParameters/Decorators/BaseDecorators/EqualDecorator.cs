namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "equal" operator for the SQL string
    /// </summary>
    public class EqualDecorator : ParamDecorator
    {
        /// <inheritdoc/>
        public EqualDecorator(ISearchParameter searchParameter) 
            : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// The Search parameter is furthermore an exact search.
    /// </summary>
    public class ExactLikeDecorator : ParamDecorator
    {
        /// <inheritdoc/>
        public ExactLikeDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }

        public override string AsSQLString
        {
            get
            {
                return $"{_modifier} '{_searchParameter.AsSQLString}'";
            }
        }
    }
}

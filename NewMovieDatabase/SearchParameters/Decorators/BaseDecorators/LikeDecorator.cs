namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// </summary>
    public class LikeDecorator : ParamDecorator
    {
        /// <inheritdoc/>
        public LikeDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }

        public override string AsSQLString
        {
            get
            {
                return $"{_modifier} '%{_searchParameter.AsSQLString}%'";
            }
        }
    }
}

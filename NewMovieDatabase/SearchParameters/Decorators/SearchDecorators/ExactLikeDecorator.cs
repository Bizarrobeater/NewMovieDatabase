namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// The Search parameter is furthermore an exact search.
    /// </summary>
    public class ExactLikeDecorator : BaseSearchDecorator
    {
        /// <inheritdoc/>
        public ExactLikeDecorator(ISQLCommandBuilder searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }

        //public override string ToSQLString
        //{
        //    get
        //    {
        //        return $"{_modifier} '{CommandBuilder.ToSQLString}'";
        //    }
        //}
    }
}

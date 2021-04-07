namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Decorator for ISearchParameters giving the "LIKE" operator for the SQL string.
    /// </summary>
    public class LikeDecorator : BaseSearchDecorator
    {
        /// <inheritdoc/>
        public LikeDecorator(ISQLCommandBuilder commandBuilder) : base(commandBuilder)
        {
            _modifier = "LIKE";
        }

        //public override string ToSQLString
        //{
        //    get
        //    {
        //        return $"{_modifier} {CommandBuilder.ToSQLString}";
        //    }
        //}
    }
}

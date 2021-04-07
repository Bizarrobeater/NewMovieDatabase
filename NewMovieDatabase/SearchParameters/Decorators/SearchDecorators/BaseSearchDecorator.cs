namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseSearchDecorator : SQLCommandDecorator
    {
        public BaseSearchDecorator(ISQLCommandBuilder commandBuilder) :
            base(commandBuilder)
        {
        }

        //public override string AsSQLString => $"{_modifier} {_searchParameter.AsSQLString}";
    }
}

namespace NewMovieDatabase.SearchParameters
{
    public class WildCardWrapDecorator : BaseWrapper
    {
        public WildCardWrapDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder;
            _wrapChar = '%';
        }
    }
}

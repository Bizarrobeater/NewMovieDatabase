namespace NewMovieDatabase.SearchParameters
{
    public class TextWrapDecorator : BaseWrapper
    {
        public TextWrapDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder;
            _wrapChar = '\'';
        }
    }
}

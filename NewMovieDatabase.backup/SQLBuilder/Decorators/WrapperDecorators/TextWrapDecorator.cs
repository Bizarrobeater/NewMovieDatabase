namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Class used to wrap <see cref="ISQLCommandBuilder"/> in "'".
    /// </summary>
    public class TextWrapDecorator : BaseWrapper
    {
        public TextWrapDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder;
            _startWrap = "\'";
            _endWrap = _startWrap;
        }
    }
}

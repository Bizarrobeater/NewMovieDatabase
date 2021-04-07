namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Class used for wrapping <see cref="ISQLCommandBuilder"/> in % <
    /// </summary>
    public class WildCardWrapDecorator : BaseWrapper
    {
        public WildCardWrapDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilder = commandBuilder;
            _wrapChar = '%';
        }
    }
}

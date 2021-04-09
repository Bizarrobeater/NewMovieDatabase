namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Abstract class representing an <see cref="ISQLCommandBuilder"/>, that wraps it's content in a specific char.
    /// </summary>
    public abstract class BaseWrapper : ISQLCommandBuilder
    {
        protected ISQLCommandBuilder _commandBuilder;
        protected string _startWrap;
        protected string _endWrap;

        /// <inheritdoc/>
        public virtual string ToSQLString 
        {
            get
            {
                return $"{_startWrap}{_commandBuilder.ToSQLString}{_endWrap}";
            } 
        }
    }
}

namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Abstract class representing an <see cref="ISQLCommandBuilder"/>, that wraps it's content in a specific char.
    /// </summary>
    public abstract class BaseWrapper : ISQLCommandBuilder
    {
        protected ISQLCommandBuilder _commandBuilder;
        protected char _wrapChar;

        /// <inheritdoc/>
        public virtual string ToSQLString 
        {
            get
            {
                return $"{_wrapChar}{_commandBuilder.ToSQLString}{_wrapChar}";
            } 
        }
    }
}

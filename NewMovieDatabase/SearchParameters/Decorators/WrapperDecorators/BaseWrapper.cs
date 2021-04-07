namespace NewMovieDatabase.SearchParameters
{
    public abstract class BaseWrapper : ISQLCommandBuilder
    {
        protected ISQLCommandBuilder _commandBuilder;
        protected char _wrapChar;

        public virtual string ToSQLString 
        {
            get
            {
                return $"{_wrapChar}{_commandBuilder.ToSQLString}{_wrapChar}";
            } 
        }
    }
}

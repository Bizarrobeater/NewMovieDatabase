using System.Collections.Generic;
using System.Text;

namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Abstract decorator class for <see cref="ISQLCommandBuilder"/>. Used to create SQL commands.
    /// </summary>
    public abstract class SQLCommandDecorator : ISQLCommandBuilder
    {
        protected List<ISQLCommandBuilder> _commandBuilders;
        protected string _modifier;

        protected ISQLCommandBuilder CommandBuilder
        {
            get
            {
                return _commandBuilders[0];
            }
        }

        public SQLCommandDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilders = new List<ISQLCommandBuilder>() { commandBuilder };
        }
        
        /// <summary>
        /// Returns as an SQL search parameter usable in a WHERE
        /// </summary>
        public virtual string ToSQLString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{_modifier} {CommandAsSQL()}");
                return sb.ToString();
            }
        }

        private string CommandAsSQL()
        {
            StringBuilder sb = new StringBuilder();
            foreach (ISQLCommandBuilder commandBuilder in _commandBuilders)
            {
                sb.Append($"{commandBuilder.ToSQLString} ");
            }
            sb.Length--;
            return sb.ToString();
        }
    }
}

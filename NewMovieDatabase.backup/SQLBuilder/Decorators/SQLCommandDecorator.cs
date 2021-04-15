using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Abstract decorator class for <see cref="ISQLCommandBuilder"/>. Used to create SQL commands.
    /// </summary>
    public abstract class SQLCommandDecorator : ISQLCommandBuilder
    {
        protected List<ISQLCommandBuilder> _commandBuilders;
        protected string _modifier;

        /// <summary>
        /// Internal field for fetching the first object in the <see cref="_commandBuilders"/> list.
        /// </summary>
        protected ISQLCommandBuilder CommandBuilder
        {
            get
            {
                return _commandBuilders[0];
            }
        }

        /// <summary>
        /// Initialises <see cref="SQLCommandDecorator"/> with a single commandBuilder object.
        /// </summary>
        public SQLCommandDecorator(ISQLCommandBuilder commandBuilder)
        {
            _commandBuilders = new List<ISQLCommandBuilder>() { commandBuilder };
        }

        /// <summary>
        /// Initialises <see cref="SQLCommandDecorator"/> with multiple commandbuilder objects.
        /// </summary>
        /// <param name="commandBuilders">An <see cref="IEnumerable{ISQLCommandBuilder}"/> object.</param>
        public SQLCommandDecorator(IEnumerable<ISQLCommandBuilder> commandBuilders)
        {
            _commandBuilders = commandBuilders.ToList();
        }
        
        //TODO check for empty list.
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

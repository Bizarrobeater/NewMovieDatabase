namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Class is a specific version of <see cref="SearchParameterDecorator{string}"/> where characters are escaped before returned.
    /// </summary>
    public class TextSearchParameterDecorator : SearchParameterDecorator<string>
    {
        public TextSearchParameterDecorator(string parameter) : base(parameter)
        {
            _baseSearchParameter = EscapeTextParameter();
        }

        /// <inheritdoc/>
        public override string ToSQLString { get => _baseSearchParameter.ToString(); }

        /// <summary>
        /// Escapes certain characters in a string search as to block injection.
        /// </summary>
        /// <returns>Escaped search parameter string.</returns>
        private string EscapeTextParameter()
        {
            return _baseSearchParameter.Replace("\"", "").Replace("'", "''").Trim();
        }
    }
}

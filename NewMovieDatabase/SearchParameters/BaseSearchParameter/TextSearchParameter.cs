namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class TextSearchParameter : SearchParameter<string>
    {
        public TextSearchParameter(string parameter) : base(parameter)
        {
            _searchParameter = EscapeTextParameter();
        }

        public override string ReturnAsSQLParameter { get => _searchParameter.ToString(); }

        private string EscapeTextParameter()
        {
            return _searchParameter.Replace("\"", "").Replace("'", "''").Trim();
        }
    }
}

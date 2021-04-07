namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public abstract class TextParam : SearchParameter<string>
    {
        public TextParam(string parameter) : base(parameter)
        {
            _searchParameter = EscapeTextParameter();
        }

        public override string ReturnAsSQLParameter => $"{_modifier}LIKE '%{_searchParameter}%'";

        private string EscapeTextParameter()
        {
            return _searchParameter.Replace("\"", "").Replace("'", "''").Trim();
        }
    }
}

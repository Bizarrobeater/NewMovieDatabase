namespace NewMovieDatabase
{
    public abstract class TextParam : SearchParameter
    {
        public TextParam(string parameter) : base(parameter)
        {
            _searchParameter = EscapeTextParameter();
        }

        public override string ReturnAsSQLParameter()
        {
            return $"{_modifier}LIKE '%{_searchParameter}%'";
        }

        private string EscapeTextParameter()
        {
            return _searchParameter.Replace("\"", "").Replace("'", "''").Trim();
        }
    }
}

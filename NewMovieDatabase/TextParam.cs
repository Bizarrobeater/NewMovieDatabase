namespace NewMovieDatabase
{
    abstract class TextParam : SearchParameter
    {
        public TextParam(string parameter) : base(parameter)
        {
            EscapeTextParameter();
        }

        public override string ReturnAsSQLParameter()
        {
            return $"{_modifier} LIKE '%{_searchParameter}%'";
        }

        private void EscapeTextParameter()
        {
            _searchParameter.Replace("\"", "").Replace("'", "''").TrimEnd();
        }
    }
}

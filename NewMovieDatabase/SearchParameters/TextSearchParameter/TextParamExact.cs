namespace NewMovieDatabase.SearchParameters
{
    public class TextParamExact : TextParam
    {
        public TextParamExact(string parameter)
            : base(parameter)
        {
        }

        public override string ReturnAsSQLParameter => $"LIKE '{_searchParameter}'";
    }
}

namespace NewMovieDatabase.SearchParameters
{
    public class TextParamExclude : TextParam
    {
        public TextParamExclude(string parameter)
            : base(parameter)
        {
            _modifier = "NOT ";
        }
    }
}

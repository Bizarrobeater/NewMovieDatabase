namespace NewMovieDatabase.SearchParameters
{
    public class ExactLikeDecorator : ParamDecorator
    {
        public ExactLikeDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                return $"{_modifier} '{_searchParameter.ReturnAsSQLParameter}'";
            }
        }
    }
}

namespace NewMovieDatabase.SearchParameters
{
    public class LikeDecorator : ParamDecorator
    {
        public LikeDecorator(ISearchParameter searchParameter) : base(searchParameter)
        {
            _modifier = "LIKE";
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                return $"{_modifier} '%{_searchParameter.ReturnAsSQLParameter}%'";
            }
        }
    }
}

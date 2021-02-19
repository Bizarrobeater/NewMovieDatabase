namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamBetween : NumberParamBetweenBase
    {
        public NumberParamBetween(int firstParam, int secondParam) : base(firstParam, secondParam)
        {
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                if (_equal)
                    return $"= {_searchParameter}";
                else
                    return $"BETWEEN {_searchParameter} AND {_secondSearchParameter}";
            }
        }
    }
}

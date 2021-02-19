namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamNotBetween : NumberParamBetweenBase
    {
        public NumberParamNotBetween(int firstParam, int secondParam) : base(firstParam, secondParam)
        {
        }

        public override string ReturnAsSQLParameter
        {
            get
            {
                if (_equal)
                    return $"!= {_searchParameter}";
                else
                    return $"NOT BETWEEN {_searchParameter} AND {_secondSearchParameter}";
            }
        }
    }
}

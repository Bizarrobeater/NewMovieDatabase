namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamLargerThan : NumberParam
    {
        public NumberParamLargerThan(int parameter) : base(parameter)
        {
            _modifier = ">=";
        }
    }
}

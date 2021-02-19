namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamSmallerThan : NumberParam
    {
        public NumberParamSmallerThan(int parameter) : base(parameter)
        {
            _modifier = "<=";
        }
    }
}

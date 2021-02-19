namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamNotSmallerThan : NumberParam
    {
        public NumberParamNotSmallerThan(int parameter) : base(parameter)
        {
            _modifier = "!<";
        }
    }
}

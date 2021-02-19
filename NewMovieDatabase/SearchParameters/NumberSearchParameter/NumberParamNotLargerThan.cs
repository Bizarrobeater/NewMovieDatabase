namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamNotLargerThan : NumberParam
    {
        public NumberParamNotLargerThan(int parameter) : base(parameter)
        {
            _modifier = "!>";
        }
    }
}

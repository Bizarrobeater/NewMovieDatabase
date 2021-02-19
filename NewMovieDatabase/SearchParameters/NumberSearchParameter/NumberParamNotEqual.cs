namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamNotEqual : NumberParam
    {
        public NumberParamNotEqual(int parameter) : base(parameter)
        {
            _modifier = "!=";
        }
    }
}

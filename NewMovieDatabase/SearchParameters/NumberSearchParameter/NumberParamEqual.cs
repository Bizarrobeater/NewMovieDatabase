namespace NewMovieDatabase.SearchParameters
{
    public class NumberParamEqual : NumberParam
    {
        public NumberParamEqual(int parameter) : base(parameter)
        {
            _modifier = "=";
        }
    }
}

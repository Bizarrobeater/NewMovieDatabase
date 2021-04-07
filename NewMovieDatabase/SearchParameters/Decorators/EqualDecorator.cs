namespace NewMovieDatabase.SearchParameters
{
    public class EqualDecorator : ParamDecorator
    {
        public EqualDecorator(ISearchParameter searchParameter) 
            : base(searchParameter)
        {
            _modifier = "=";
        }
    }
}

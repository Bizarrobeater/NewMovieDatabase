namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Concrete decorator class for "smaller than" search modifiers
    /// </summary>
    public class SmallerThanDecorator : ParamDecorator
    {
        public SmallerThanDecorator(ISearchParameter searchParameter)
            : base(searchParameter)
        {
            _modifier = "<=";
        }
    }
}

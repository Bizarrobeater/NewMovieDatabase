namespace NewMovieDatabase.SearchParameters
{
    public abstract class NumberParam : SearchParameter<int>
    {
        public NumberParam(int parameter)
            : base(parameter)
        {

        }
        public override string ReturnAsSQLParameter => $"{_modifier} {_searchParameter}";
    }
}

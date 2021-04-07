namespace NewMovieDatabase.SearchParameters
{
    public abstract class ParamDecorator : ISearchParameter
    {
        protected ISearchParameter _searchParameter;
        protected string _modifier;

        public ISearchParameter GetSearchParameter => _searchParameter;

        /// <summary>
        /// Search parameter decorator
        /// </summary>
        /// <param name="searchParameter">A base search parameter, not another decorator</param>
        public ParamDecorator(ISearchParameter searchParameter)
        {
            _searchParameter = searchParameter;
        }

        /// <summary>
        /// Returns as an SQL search parameter usable in a WHERE
        /// </summary>
        public virtual string ReturnAsSQLParameter => $"{_modifier} {_searchParameter.ReturnAsSQLParameter}";
    }
}

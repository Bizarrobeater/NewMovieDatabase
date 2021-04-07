namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Abstract decorator class for ISearchParameters. Used to bind to the base SQL search parameter.
    /// </summary>
    public abstract class ParamDecorator : ISearchParameter
    {
        protected ISearchParameter _searchParameter;
        protected string _modifier;

        public ISearchParameter GetSearchParameter => _searchParameter;

        /// <summary>
        /// Initialises a new instance of the <see cref="ParamDecorator"/> class part of the <see cref="ISearchParameter"/> interface.
        /// </summary>
        /// <param name="searchParameter">Base parameter or another decorator that this can bind to.</param>
        public ParamDecorator(ISearchParameter searchParameter)
        {
            _searchParameter = searchParameter;
        }

        /// <summary>
        /// Returns as an SQL search parameter usable in a WHERE
        /// </summary>
        public virtual string AsSQLString => $"{_modifier} {_searchParameter.AsSQLString}";
    }
}

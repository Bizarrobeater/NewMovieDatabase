using System;

namespace NewMovieDatabase.SearchParameters
{

    /// <summary>
    /// A base Search Parameter class, implementing the <see cref="ISearchParameter"/> interface.
    /// Class is used for return the base search parameter that will be searched for in the database.
    /// </summary>
    /// <typeparam name="T">Any type of <see cref="IComparable{T}"/></typeparam>
    public class SearchParameter<T> : ISearchParameter where T: IComparable<T>
    {
        protected ISearchParameter _searchParameter = null;
        protected T _baseSearchParameter { get; set; }
        
        public SearchParameter(T searchParameter)
        {
            _baseSearchParameter = searchParameter;
        }

        public SearchParameter(T lowSearchParameter, T highSearchParameter)
        {
            _baseSearchParameter = lowSearchParameter;
            _searchParameter = new SearchParameter<T>(highSearchParameter);
        }

        /// <inheritdoc/>
        public virtual string AsSQLString 
        {
            get
            {
                if (_searchParameter != null)
                {
                    return BetweenSQLString();
                }
                else
                    return _baseSearchParameter.ToString();
            }
        }

        private string BetweenSQLString()
        {
            return $"{_baseSearchParameter} AND {_searchParameter.AsSQLString}";
        }
    }
}

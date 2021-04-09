using System;

namespace NewMovieDatabase.SQLBuilder
{

    /// <summary>
    /// A base Search Parameter class, implementing the <see cref="ISQLCommandBuilder"/> interface.
    /// Class is used for return the base search parameter that will be searched for in the database.
    /// </summary>
    /// <typeparam name="T">Any type of <see cref="IComparable{T}"/></typeparam>
    public class SearchParameterDecorator<T> : ISQLCommandBuilder where T: IComparable<T>
    {
        protected ISQLCommandBuilder _searchParameter = null;
        protected T _baseSearchParameter { get; set; }
        
        /// <summary>
        /// Initialises a <see cref="SearchParameterDecorator{T}"/> with a single parameter.
        /// </summary>
        /// <param name="searchParameter">Generic search parameter</param>
        public SearchParameterDecorator(T searchParameter)
        {
            _baseSearchParameter = searchParameter;
        }


        /// <summary>
        /// Initialises a <see cref="SearchParameterDecorator{T}"/> with 2 search parameters. Used only for the BETWEEN keyword in a command.
        /// </summary>
        /// <param name="lowSearchParameter">Search parameter of type T, lower or equal to highSearchParameter</param>
        /// <param name="highSearchParameter">Search parameter of type T, higher or equal to lowSearchParameter</param>
        public SearchParameterDecorator(T lowSearchParameter, T highSearchParameter)
        {
            _baseSearchParameter = lowSearchParameter;
            _searchParameter = new SearchParameterDecorator<T>(highSearchParameter);
        }

        /// <inheritdoc/>
        public virtual string ToSQLString 
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

        /// <summary>
        /// Creates a string between 2 given search parameters.
        /// </summary>
        private string BetweenSQLString()
        {
            return $"{_baseSearchParameter} AND {_searchParameter.ToSQLString}";
        }
    }
}

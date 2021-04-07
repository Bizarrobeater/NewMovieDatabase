using System;

namespace NewMovieDatabase.SearchParameters
{
    // TODO: Comment
    public class SearchParameter<T> : ISearchParameter where T: IComparable<T>
    {
        protected T _searchParameter { get; set; }
        public SearchParameter(T searchParameter)
        {
            _searchParameter = searchParameter;
        }

        public virtual string ReturnAsSQLParameter => _searchParameter.ToString();
    }
}

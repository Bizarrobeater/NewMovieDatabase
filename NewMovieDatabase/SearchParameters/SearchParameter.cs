using System;

namespace NewMovieDatabase.SearchParameters
{
    public abstract class SearchParameter<T> : ISearchParameter where T: IComparable<T>
    {
        protected T _searchParameter { get; set; }
        protected string _modifier { get; set; }
        public SearchParameter(T searchParameter)
        {
            _searchParameter = searchParameter;
            _modifier = "";
        }

        public abstract string ReturnAsSQLParameter { get; }
    }
}

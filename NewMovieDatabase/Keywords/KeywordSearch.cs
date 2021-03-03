using System.Collections.Generic;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDatabase.Keywords
{
    abstract class KeywordSearch
    {
        private string _searchString;
        List<ISearchParameter> _searchParameters;

        public KeywordSearch(string searchString)
        {
            _searchString = searchString;
        }
    }
}
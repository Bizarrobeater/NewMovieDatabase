using System.Collections.Generic;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDatabase.Keywords
{
    public class KeywordSearch
    {
        private string _searchString;
        private Keyword _keyword = null;
        private List<ISearchParameter> _searchParameters;

        public KeywordSearch(string searchString)
        {
            _searchString = searchString;
        }

        public KeywordSearch(Keyword keyword, string searchString)
        {
            _keyword = keyword;
            _searchString = searchString;
        }
    }
}
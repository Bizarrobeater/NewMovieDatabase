using System.Collections.Generic;

namespace NewMovieDatabase
{
    abstract class KeywordSearch
    {
        string _keyword { get; set; }
        List<ISearchParameters> _searchParameters;

        public KeywordSearch(string searchString)
        {
            
        }
    }
}
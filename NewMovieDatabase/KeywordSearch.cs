﻿using System.Collections.Generic;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDatabase
{
    abstract class KeywordSearch
    {
        string _keyword { get; set; }
        List<ISearchParameter> _searchParameters;

        public KeywordSearch(string searchString)
        {
            
        }
    }
}
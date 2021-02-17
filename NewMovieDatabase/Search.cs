using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    class Search
    {
        private string _searchString;
        private bool _randomSearch;


        public Search(string searchString, bool random = false)
        {
            _searchString = searchString;
            _randomSearch = random;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    abstract class SearchParameter : ISearchParameters
    {
        protected string _searchParameter { get; set; }
        protected string _modifier { get; set; }
        public SearchParameter(string searchParameter)
        {
            _searchParameter = searchParameter;
        }

        public abstract string ReturnAsSQLParameter();

    }
}

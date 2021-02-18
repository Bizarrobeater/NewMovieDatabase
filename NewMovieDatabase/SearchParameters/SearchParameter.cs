using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    public abstract class SearchParameter : ISearchParameter
    {
        protected string _searchParameter { get; set; }
        protected string _modifier { get; set; }
        public SearchParameter(string searchParameter)
        {
            _searchParameter = searchParameter;
            _modifier = "";
        }

        public abstract string ReturnAsSQLParameter();

    }
}

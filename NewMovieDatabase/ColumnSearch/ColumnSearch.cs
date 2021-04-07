using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewMovieDatabase.TableClasses;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDatabase.ColumnSearch
{
    public class ColumnSearch : IColumnSearch
    {
        Column _column;
        List<ISearchParameter> _searchParameters;

        public ColumnSearch(Column column, string searchParams)
        {
            _column = column;
        }


        public string ReturnColumnSearch()
        {
            throw new NotImplementedException();
        }
    }
}

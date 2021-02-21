using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMovieDatabase.TableClasses;

namespace NewMovieDatabase
{
    public class Keyword
    {
        string _keyword;
        ColumnCollection _associatedColumns;

        public Keyword(string keyword, ColumnCollection columns)
        {
            _keyword = keyword;
            _associatedColumns = columns;
        }
    }
}

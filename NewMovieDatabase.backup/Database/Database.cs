using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMovieDatabase.TableClasses;
using NewMovieDatabase.Keywords;

namespace NewMovieDatabase.Database
{
    /// <summary>
    /// Represents the metadata for a database.
    /// </summary>
    public class Database
    {
        private Table _mainTable;
        private List<Table> _tables;
        private KeywordCollection _keywords;


        public Table MainTable { get => _mainTable; }


    }
}

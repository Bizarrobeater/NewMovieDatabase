using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses
{
    public abstract class TableTypeAbstract
    {
        string _tableName;
        List<string> _associatedKeyword;
        Dictionary<string, ColumnDataType> _columnNames;

    }
}

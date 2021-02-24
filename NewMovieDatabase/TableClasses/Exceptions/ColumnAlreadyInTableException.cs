using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses 
{ 
    class ColumnAlreadyInTableException : Exception
    {

        public ColumnAlreadyInTableException(Column column, Table table) 
            : base($"{column.ColumnName} has already been added to table ({table.TableName}).")
            {

        }
    }
}

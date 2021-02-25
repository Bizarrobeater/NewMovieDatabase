using System;

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

using System;

namespace NewMovieDatabase.TableClasses
{
    class ColumnAlreadyExistsException : Exception
    {
        public ColumnAlreadyExistsException(Column newColumn, Column CurrColumn) 
            : base($"A column with the name {newColumn} already exist in {CurrColumn.Table}")
        {
        }
    }
}

using System;

namespace NewMovieDatabase.TableClasses
{
    class ColumnAlreadyExistsException : Exception
    {
        // TODO: Comment
        public ColumnAlreadyExistsException(Column newColumn, Table currTable) 
            : base($"A column with the name {newColumn} already exist in {currTable.TableName}")
        {
        }
    }
}

namespace NewMovieDatabase.TableClasses
{
    class ColumnForeignKey : Column
    {
        Column _refColumn;

        public ColumnForeignKey(string columnName, ColumnDataType dataType, Column referenceColumn) : base(columnName, dataType)
        {
            _refColumn = referenceColumn;
        }
    }
}

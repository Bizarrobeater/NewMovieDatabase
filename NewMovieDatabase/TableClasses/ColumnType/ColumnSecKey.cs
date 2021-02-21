namespace NewMovieDatabase.TableClasses
{
    class ColumnSecKey : Column
    {
        Column _refColumn;


        public ColumnSecKey(string columnName, ColumnDataType dataType, Column referenceColumn) : base(columnName, dataType)
        {
            _refColumn = referenceColumn;
        }
    }
}

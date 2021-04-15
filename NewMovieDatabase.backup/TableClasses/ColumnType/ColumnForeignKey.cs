namespace NewMovieDatabase.TableClasses
{
    /// <inheritdoc/>
    /// <remarks>
    /// Specific representation for foreign key columns.
    /// </remarks>
    class ColumnForeignKey : Column
    {
        Column _refColumn;
        // TODO: Comment
        public ColumnForeignKey(string columnName, ColumnDataType dataType, Column referenceColumn) : base(columnName, dataType)
        {
            _refColumn = referenceColumn;
        }
    }
}

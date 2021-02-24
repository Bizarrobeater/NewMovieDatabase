namespace NewMovieDatabase.TableClasses
{

    // Specific Column collection that can only have 1 primary key and no dublets of column names
    class TableColumnCollection : ColumnCollection
    {
        Column _primKeyColumn;

        public bool HasPrimaryKey => _primKeyColumn != null;
        public Column PrimaryKeyColumn { get => _primKeyColumn; }

        public override void Add(Column newColumn, Table table)
        {
            bool isPrimaryKey = newColumn.DataType == ColumnDataType.PrimaryKey;          

            // if a new column is a primary key, checks all existing columns for same, throws exception if a primary key already exists
            if (isPrimaryKey && HasPrimaryKey)
                throw new PrimaryKeyExistsException(newColumn);

            foreach (Column column in _innerCollection)
            {
                // throws an exception if the column name exists
                if (column.Equals(newColumn.FullName))
                throw new ColumnAlreadyExistsException(newColumn, column);
            }
            
            // Adds the table to the column (and throws error if the column is already associated with a table)
            newColumn.AddTable(table);

            if (newColumn.DataType == ColumnDataType.PrimaryKey)
                _primKeyColumn = newColumn;

            base.Add(newColumn);
        }
    }
}

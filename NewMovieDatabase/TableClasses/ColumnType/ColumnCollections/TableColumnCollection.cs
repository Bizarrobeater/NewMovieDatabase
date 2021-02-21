namespace NewMovieDatabase.TableClasses
{

    // Specific Column collection that can only have 1 primary key and no dublets of column names
    class TableColumnCollection : ColumnCollection
    {
        Column _primKeyColumn;

        public bool HasPrimaryKey => _primKeyColumn != null;
        public Column PrimaryKeyColumn { get => _primKeyColumn; }

        public override void Add(Column item)
        {
            bool isPrimaryKey = item.DataType == ColumnDataType.PrimaryKey;
            
            // if a new column is a primary key, checks all existing columns for same, throws exception if a primary key already exists
            if (isPrimaryKey && HasPrimaryKey)
                throw new PrimaryKeyExistsException(item);

            foreach (Column column in _innerCollection)
            {
                    // throws an exception if the column name exists
                    if (column.Equals(item.FullName))
                    throw new ColumnAlreadyExistsException(item, column);
            }

            if (item.DataType == ColumnDataType.PrimaryKey)
                _primKeyColumn = item;

            base.Add(item);
        }
    }
}

namespace NewMovieDatabase.TableClasses
{
    /// <summary>
    /// Represents a specific type of column collection that can only contain 1 primary key and two columns with the same name.
    /// </summary>
    public class TableColumnCollection : ColumnCollection
    {
        /// <summary>
        /// The primary key column in the collection
        /// </summary>
        Column _primKeyColumn;

        /// <summary>
        /// True if the primary column exists
        /// </summary>
        public bool HasPrimaryKey => _primKeyColumn != null;
        
        /// <summary>
        /// The primary column as read-only
        /// </summary>
        public Column PrimaryKeyColumn { get => _primKeyColumn; }

        /// <summary>
        /// Adds a new column to the collection, will compare with column metadata and throw exception if it cannot be done.
        /// Also adds the table to the column.
        /// </summary>
        /// <param name="newColumn">Column to add.</param>
        /// <param name="table">Table the column is added to.</param>
        /// <exception cref="PrimaryKeyExistsException">
        /// Thrown if the new column is a primary key, and the collection already has one.
        /// </exception>
        /// <exception cref="ColumnAlreadyExistsException">
        /// Thrown if the name of the new column is already in use.
        /// </exception>
        /// <exception cref="ColumnAlreadyInTableException">
        /// Thrown if the column already as an associated table.
        /// </exception>
        public override void Add(Column newColumn, Table table)
        {
            bool isPrimaryKey = newColumn.DataType == ColumnDataType.PrimaryKey;          

            // if a new column is a primary key, checks all existing columns for same, throws exception if a primary key already exists
            if (isPrimaryKey && HasPrimaryKey)
                throw new PrimaryKeyExistsException(newColumn);

            // Throws exception if the column name already exists.
            if (Contains(newColumn.ColumnName))
                throw new ColumnAlreadyExistsException(newColumn, table);
            
            // Adds the table to the column (and throws error if the column is already associated with a table)
            newColumn.AddTable(table);

            if (newColumn.DataType == ColumnDataType.PrimaryKey)
                _primKeyColumn = newColumn;

            base.Add(newColumn);
        }
    }
}

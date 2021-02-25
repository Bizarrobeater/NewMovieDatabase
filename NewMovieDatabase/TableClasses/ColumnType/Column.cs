using System;
using NewMovieDatabase.VerifyNames;

namespace NewMovieDatabase.TableClasses
{
    /// <summary>
    /// Represents the metadata of a column in a database
    /// </summary>
    public class Column : IEquatable<Column>, IEquatable<string>, IEquatable<ColumnDataType>
    {
        /// <summary>
        /// The column name. Used for comparisons and IDs
        /// </summary>
        private string _columnName;
        
        /// <summary>
        /// The column data type. Used for comparisons and 
        /// </summary>
        private ColumnDataType _dataType;

        /// <summary>
        /// The table the column is in.
        /// </summary>
        private Table _table;

        // TODO finish descriptions of variables
        

        public Table Table { get => _table; }
        public string ColumnName { get => _columnName; }
        public  string FullName { get => $"{_table.TableName}-{_columnName}"; }
        public ColumnDataType DataType { get => _dataType; }

        /// <summary>
        /// Instantiate a new column with the name <paramref name="columnName"/> and datatype <paramref name="dataType"/>.
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="dataType"></param>
        public Column(string columnName, ColumnDataType dataType)
        {
            _columnName = columnName;
            _dataType = dataType;
        }


        // TODO: this should be moved to a factory, not at the column.
        private bool VerifyColumnName(string columnName, IDataBaseNameRules rules, out string message)
        {
            return rules.VerifyColumnName(columnName, out message);
        }

        public override string ToString() => ColumnName;

        /// <summary>
        /// Adds a table to the column
        /// </summary>
        /// <param name="table">Table to add</param>
        /// <exception cref="ColumnAlreadyInTableException">
        /// Thrown when the column already has a table registrered.
        /// </exception>
        public void AddTable(Table table)
        {   
            if (_table == null)
                _table = table;
            else
                throw new ColumnAlreadyInTableException(this, _table); 
        }

        /// <summary>
        /// Removes the registrered table.
        /// </summary>
        public void RemoveTable() => _table = null;

        /// <summary>
        /// Compares 2 columns based on name and datatype.
        /// </summary>
        /// <param name="other">Column to compare.</param>
        /// <returns>
        /// True if the columns are the same, false if they are not.
        /// </returns>
        public bool Equals(Column other) => Equals(other.FullName) && Equals(other.DataType);


        /// <summary>
        /// Compares the name of columns
        /// </summary>
        /// <param name="ColumnFullName">Full name ({column name}-{table name}) of a column</param>
        /// <returns>
        /// True if the names are the same, false if they are not.
        /// </returns>
        // Compares a string to full name, cannot take account for datatype
        public bool Equals(string ColumnFullName) => FullName == ColumnFullName;


        /// <summary>
        /// Compares a datatype to the datatype of this column
        /// </summary>
        /// <param name="other">Datatype</param>
        /// <returns>
        /// True if the given datatype and this columns datatype is the same, false if not.
        /// </returns>
        public bool Equals(ColumnDataType other) => DataType == other;
    }
}

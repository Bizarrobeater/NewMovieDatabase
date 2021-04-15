using System.Collections.Generic;

namespace NewMovieDatabase.TableClasses
{
    // TODO: Comment

    /// <summary>
    /// Represents the metadata for a table in a database
    /// </summary>
    public class Table //TODO make equatable
    {
        string _tableName;
        TableType _type;
        TableColumnCollection _columns;

        public string TableName { get => _tableName; }

        public int ColumnCount { get => _columns.Count; }

        public bool HasPrimaryKey { get => _columns.HasPrimaryKey; }

        public Table(string tableName)
        {
            _type = TableType.Dimension;
            _tableName = tableName;
            _columns = new TableColumnCollection();
            CreatePrimaryKeyColumn();
        }

        public Table(string tableName, TableType tableType)
            : this(tableName)
        {
            _type = tableType;
        }


        /// <summary>
        /// Tries to add a column to the table.
        /// </summary>
        /// <param name="newColumn">The column to add</param>
        /// <returns></returns>
        public bool AddColumn(Column newColumn, out string message)
        {
            string exceptionTopMessage = "Failure to add column - reason:\n\t";
            message = "";

            try
            {
                _columns.Add(newColumn, this);
                return true;
            }
            catch (PrimaryKeyExistsException pkeEx)
            {
                message = $"{exceptionTopMessage}{pkeEx.Message}";
            }
            catch (ColumnAlreadyExistsException caeEx)
            {
                message = $"{exceptionTopMessage}{caeEx.Message}";
            }
            catch (ColumnAlreadyInTableException catEx)
            {
                message = $"{ exceptionTopMessage}{catEx.Message}";
            }
            return false;
        }

        public bool RemoveColumn(Column column)
        {
            bool result = _columns.Remove(column);
            column.RemoveTable();
            return result;
        }

        // Makes it possible to add several columns at the same time
        public List<string> AddColumns(IEnumerable<Column> columns)
        {
            List<string> messages = new List<string>();
            string message;

            foreach (Column column in columns)
            {
                if (!AddColumn(column, out message))
                {
                    messages.Add(message);
                }
                    
            }
            return messages;
        }

        #region STANDARD_OVERRIDES

        /// <inheritdoc/>
        public override string ToString()
        {
            return _tableName;
        }

        #endregion STANDARD_OVERRIDES

        #region INITIALISATION_METHODS

        private void CreatePrimaryKeyColumn()
        {
            Column primKey = new Column("Id", ColumnDataType.PrimaryKey);
            AddColumn(primKey, out _);
        }

        #endregion INITIALISATION_METHODS
    }
}

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
        TableColumnCollection _columns;

        public string TableName { get => _tableName; }

        public int ColumnCount { get => _columns.Count; }
        public bool HasPrimaryKey { get => _columns.HasPrimaryKey; }

        public Table(string tableName)
        {
            _tableName = tableName;
            _columns = new TableColumnCollection();
        }

        public override string ToString()
        {
            return _tableName;
        }

        // Tries to add a new column to the tables collection
        public string AddColumn(Column newColumn)
        {
            string message;
            string exceptionTopMessage = "Failure to add column - reason:\n\t";

            try
            {
                _columns.Add(newColumn, this);
                message = $"{newColumn.ColumnName} was successfully added to {TableName}";
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
            return message;
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

            foreach (Column column in columns)
            {
                messages.Add(AddColumn(column));
            }
            return messages;
        }
    }
}

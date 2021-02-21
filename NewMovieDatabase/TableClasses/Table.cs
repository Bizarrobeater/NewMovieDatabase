using System.Collections.Generic;

namespace NewMovieDatabase.TableClasses
{
    public class Table
    {
        string _tableName;
        TableColumnCollection _columns;

        public string TableName { get => _tableName; }

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
        public bool AddColumn(Column newColumn, out string message)
        {
            bool result = false;
            message = "";

            try
            {
                _columns.Add(newColumn);
                result = true;
                newColumn.AddTable(this);
            }
            catch (PrimaryKeyExistsException pkeEx)
            {
                message = pkeEx.Message;
            }
            catch (ColumnAlreadyExistsException caeEx)
            {
                message = caeEx.Message;
            }
            return result;
        }

        // Makes it possible to add several columns at the same time
        public void AddColumns(IEnumerable<Column> columns, out List<string> messages)
        {
            messages = new List<string>();
            string newMessage;

            foreach (Column column in columns)
            {
                // Add message about succes or failure of the add
                if (AddColumn(column, out newMessage))
                    messages.Add($"{column.ColumnName} was added to the table");
                else
                    messages.Add(newMessage);
            }
        }
    }
}

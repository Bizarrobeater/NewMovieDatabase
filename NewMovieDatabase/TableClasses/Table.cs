using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses
{
    public class Table
    {
        string _tableName;
        ColumnCollection _columns;

        public string TableName { get => _tableName; }

        public Table(string tableName)
        {
            _tableName = tableName;
            _columns = new ColumnCollection();
        }

        public override string ToString()
        {
            return _tableName;
        }

        public bool AddColumn(Column newColumn, out string message)
        {
            bool result = false;
            bool isPrimaryKey = newColumn.DataType == ColumnDataType.PrimaryKey;
            message = "";

            // A column can always be added if non exist already
            if (_columns.Count == 0)
            {
                _columns.Add(newColumn);
                result = true;
                return result;
            }

            try
            {
                foreach (Column column in _columns)
                {
                    // if a new column is a primary key, checks all existing columns for same, throws exception if a primary key already exists
                    if (isPrimaryKey && column.DataType == ColumnDataType.PrimaryKey)
                        throw new PrimaryKeyExistsException(newColumn, column);
                    else
                    // throws an exception if the columnName exists
                        if (column.Equals(newColumn.FullName))
                            throw new ColumnAlreadyExistsException(newColumn, column); 
                }
                _columns.Add(newColumn);
                result = true;
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
    }
}

using System;

namespace NewMovieDatabase.TableClasses
{
    public class Column : IEquatable<Column>, IEquatable<string>, IEquatable<ColumnDataType>
    {
        Table _table;
        string _columnName;
        ColumnDataType _dataType;

        public Table Table { get => _table; }
        public string ColumnName { get => _columnName; }
        public  string FullName { get => $"{_table.TableName}-{_columnName}"; }
        public ColumnDataType DataType { get => _dataType; }


        public Column(string columnName, ColumnDataType dataType)
        {
            _columnName = columnName;
            _dataType = dataType;
        }

        public override string ToString()
        {
            return ColumnName;
        }

        public void AddTable(Table table) => _table = table; // TODO Check for existing tables

        // Compares one column to another based on column, tablename and datatype
        public bool Equals(Column other)
        {
            return Equals(other.FullName) && Equals(other.DataType);
        }

        // Compares a string to full name, cannot take account for datatype
        public bool Equals(string ColumnFullName)
        {
            return FullName == ColumnFullName;
        }

        public bool Equals(ColumnDataType other)
        {
            return DataType == other;
        }
    }
}

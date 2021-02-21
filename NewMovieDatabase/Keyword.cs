using NewMovieDatabase.TableClasses;

namespace NewMovieDatabase
{
    public class Keyword
    {
        string _keyword;
        ColumnCollection _associatedColumns;

        public Keyword(string keyword, ColumnCollection columns)
        {
            _keyword = keyword;
            _associatedColumns = columns;
        }

        public Keyword(string keyword)
        {
            _keyword = keyword;
            _associatedColumns = new ColumnCollection();
        }

        public void AddColumn(Column column) => _associatedColumns.Add(column);

        public void RemoveColumn(Column column) => _associatedColumns.Remove(column);
    }
}

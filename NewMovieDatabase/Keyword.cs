using System.Collections.Generic;
using NewMovieDatabase.TableClasses;


namespace NewMovieDatabase
{
    /// <summary>
    /// Represent the metadata regarding usable keywords.
    /// </summary>
    public class Keyword
    {
        string _keyword;
        ColumnCollection _associatedColumns;

        /// <summary>
        /// Initialises a new instance of a keyword and an empty collection of columns.
        /// </summary>
        /// <param name="keyword"></param>
        public Keyword(string keyword)
        {
            _keyword = keyword;
            _associatedColumns = new ColumnCollection();
        }

        /// <summary>
        /// Initialises a new instance of a keyword with associated columns.
        /// </summary>
        /// <param name="keyword">The keyword as a string</param>
        /// <param name="columns">The columns associated by the keyword.</param>
        public Keyword(string keyword, IEnumerable<Column> columns)
        {
            _keyword = keyword;
            _associatedColumns = new ColumnCollection(columns);
        }

        /// <summary>
        /// Adds an associated column from the keywords collection.
        /// </summary>
        /// <param name="column">Column to add.</param>
        public void AddColumn(Column column) => _associatedColumns.Add(column);


        /// <summary>
        /// Removes an associated column from the keywords colleciton.
        /// </summary>
        /// <param name="column">Column to remove.</param>
        public void RemoveColumn(Column column) => _associatedColumns.Remove(column);
    }
}

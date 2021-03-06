﻿using System;
using System.Collections.Generic;
using NewMovieDatabase.TableClasses;


namespace NewMovieDatabase.Keywords
{
    /// <summary>
    /// Represent the metadata regarding usable keywords.
    /// </summary>
    public class Keyword : IEquatable<Keyword>, IEquatable<string>
    {
        string _keyword;
        ColumnCollection _associatedColumns;
        public string Name { get => _keyword; }

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


        /// <summary>
        /// Change the keyword string
        /// </summary>
        /// <param name="newKeyword"></param>
        public void ChangeKeywordName(string newKeyword)
        {
            _keyword = newKeyword;
        }


        public bool validateKeywordName(string name)
        {
            throw new NotImplementedException();
        }


        /// <inheritdoc/>
        public bool Equals(string other)
        {
            return _keyword == other;
        }
        
        /// <inheritdoc/>
        public bool Equals(Keyword other)
        {
            return Equals(other.Name);
        }
    }
}

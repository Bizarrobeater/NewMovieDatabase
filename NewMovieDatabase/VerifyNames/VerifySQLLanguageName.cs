using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NewMovieDatabase.VerifyNames
{
    /// <summary>
    /// Represents an abstract verification procedure of column and table names for a given SQL language
    /// </summary>
    public abstract class VerifySQLLanguageName : IDataBaseNameRules
    {
        // TODO: Comment

        internal string _keywordFilename;
        internal Lazy<List<string>> _keywordList;

        // string used to get the location of the reserved keyword list based on the location of the program
        static private string _currentDir = AppDomain.CurrentDomain.BaseDirectory;
        static private string _baseDirectory = Directory.GetParent(_currentDir).Parent.Parent.Parent.Parent.FullName;
        static private string _reservedKeywordListPath = Path.Combine(
                  _baseDirectory, "NewMovieDatabase", "VerifyNames", "ReservedKeywordLists");

        /// <summary>
        /// Initialises a new instance and creates a lazy implementation of the reserved keyword list.
        /// </summary>
        public VerifySQLLanguageName()
        {
            _keywordList = new Lazy<List<string>>(GetKeywordList);
        }

        /// <summary>
        /// Simple verification that checks common rules for table/column names.
        /// </summary>
        /// <param name="name">Name to check.</param>
        /// <returns>
        /// True/False based on the simple verification
        /// </returns>
        internal bool SimpleVerify(string name)
        {
            // Regex explanation:
            // ^[a-zA-Z]                - Must start with at least one letter that can be a capital letter
            // [a-zA-Z\d_]{0,29}$       - Must end with between 0 and 29 letters, numbers or underscores.
            // result is must start with a letter and must not be longer than 30 characters
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z\d_]{0,29}$");
            return regex.IsMatch(name);
        }

        /// <summary>
        /// Gets a list of string that represents reserved keywords in a given SQL language
        /// </summary>
        /// <returns>
        /// List of strings
        /// </returns>
        private List<string> GetKeywordList()
        {
            return File.ReadLines(Path.Combine(_reservedKeywordListPath, _keywordFilename)).ToList();
        }

        /// <inheritdoc/>
        public abstract bool VerifyColumnName(string name, out string message);
        
        /// <inheritdoc/>
        public abstract bool VerifyTableName(string name, out string message);
    }
}

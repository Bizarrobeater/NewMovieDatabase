using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NewMovieDatabase.VerifyNames
{
    public abstract class VerifySQLLanguageName : IDataBaseNameRules
    {
        internal string keywordFilename;
        internal Lazy<List<string>> keywordList;


        public VerifySQLLanguageName()
        {
            keywordList = new Lazy<List<string>>(GetKeywordList);
        }

        // Verifies the name with simple rules
        // i.e. starts with letter and only contains letters, numbers and underscore
        internal bool SimpleVerify(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+[a-zA-Z\d_]*");
            return regex.IsMatch(name);
        }

        private List<string> GetKeywordList()
        {
            return System.IO.File.ReadLines(keywordFilename).ToList();
        }

        public abstract bool VerifyColumnName(string name, out string message);
        public abstract bool VerifyTableName(string name, out string message);
    }
}

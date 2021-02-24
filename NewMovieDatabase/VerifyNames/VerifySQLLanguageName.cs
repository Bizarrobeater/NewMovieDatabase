using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NewMovieDatabase.VerifyNames
{
    public abstract class VerifySQLLanguageName : IDataBaseNameRules
    {
        internal string keywordFilename;
        internal Lazy<List<string>> keywordList;
        static private string partFileName = "\\NewMovieDatabase\\VerifyNames\\ReservedKeywordLists\\";
        static private string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        static private string baseDirectory = Directory.GetParent(currentDir).Parent.Parent.Parent.Parent.FullName;


        public VerifySQLLanguageName()
        {
            keywordList = new Lazy<List<string>>(GetKeywordList);
        }

        // Verifies the name with simple rules
        // i.e. starts with letter and only contains letters, numbers and underscore
        internal bool SimpleVerify(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+[a-zA-Z\d_]*$");
            return regex.IsMatch(name);
        }

        private List<string> GetKeywordList()
        {
            return File.ReadLines(baseDirectory + partFileName + keywordFilename).ToList();
        }

        public abstract bool VerifyColumnName(string name, out string message);
        public abstract bool VerifyTableName(string name, out string message);
    }
}

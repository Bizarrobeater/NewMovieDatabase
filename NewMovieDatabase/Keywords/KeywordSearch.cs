using System.Collections.Generic;
using NewMovieDatabase.SQLBuilder;

namespace NewMovieDatabase.Keywords
{
    public class KeywordSearch
    {
        private string _searchString;
        private Keyword _keyword = null;
        private List<ISQLCommandBuilder> _searchParameters;

        private static List<string> _regexGroupList = new List<string>
        {
            $"-\".+\"",                         // group will find any number of characters between 2 quotation marks, with a potential first dash
        };

        public Keyword SetKeyword { set => _keyword = value; }

        public KeywordSearch(string searchString)
        {
            _searchString = searchString;
        }

        public KeywordSearch(Keyword keyword, string searchString)
        {
            _keyword = keyword;
            _searchString = searchString;
        }

        public void ExtractSearchParameters() 
        {
            _searchParameters = new List<ISQLCommandBuilder>();


        }
    }
}
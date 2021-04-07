using System.Collections.Generic;
using System.Text.RegularExpressions;
using NewMovieDatabase.Keywords;

namespace NewMovieDatabase
{
    class Search
    {
        private KeywordCollection keywords;
        private string _fullSearchString;
        private List<string> _splitSearchString;
        //private List<KeywordSearch> keywordSearches { get; set; }

        private bool _randomSearch { get; }

        public Search(string searchString, bool random = false)
        {
            _fullSearchString = searchString;
            _randomSearch = random;
            _splitSearchString = SplitSearchString(searchString);
        }

        // Splits the entire search string into parts consisting of a @keyword + the search parameters
        private List<string> SplitSearchString(string searchString)
        {
            // Regex explanation:
            // (@[^@^ ]+)? - looks for a word that starts with @ but does not contain more @'s or space, these are "@keywords"
            // ([^@]+)+?) - looks for text that does not contain @, these are the search parameters
            // the keywords are optional
            // Ex.: "@keyword param" - is a match
            // Ex.: "param" - is a match
            // Ex.: "@keyword" - is not a match
            // Ex.: "@keyword1 param1 @keyword2" - "@keyword1 param1" is the only match
            // Ex.: "@keyword1 param1 @keyword2 param2" - "@keyword1 param1" is a match, "@keyword2 param2" is also a match
            // Ex.: "param @keyword1 param1" - "param" is a match, "@keyword1 param1" is also a match
            Regex splitRe = new Regex(@"((@[^@^ ]+)?([^@]+)+?)");

            List<string> splitSearchString = new List<string>();

            MatchCollection matches = splitRe.Matches(searchString);
            
            // If no @keywords has been used return the entire string with and @all added
            if (matches.Count == 0)
                return new List<string> { {searchString} };

            foreach(Match match in matches)
            {
                splitSearchString.Add(match.ToString());
            }

            return splitSearchString;
        }
    }
}

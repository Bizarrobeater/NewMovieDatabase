using System;
using System.Text.RegularExpressions;

namespace NewMovieDatabase.Keywords
{
    public class KeywordNameValidation
    {
        Lazy<KeywordCollection> _keywords;
        public const int MAXLENGTH = 15;

        public KeywordNameValidation()
        {
        //    _keywords = new Lazy<KeywordCollection>(GetKeywords);
        }

        private KeywordCollection GetKeywords()
        {
            throw new NotImplementedException();
        }

        public bool VerifyKeywordName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{1," + MAXLENGTH + @"}$");

            if (!regex.IsMatch(name))
                return false;
            else return true;
            
        }

    }
}

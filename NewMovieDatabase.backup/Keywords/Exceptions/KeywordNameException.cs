using System;
using System.Runtime.Serialization;

namespace NewMovieDatabase.Keywords
{
    public class KeywordNameException : Exception
    { 

        public KeywordNameException() : base($"A Keyword must consist of only letter, and be between 1 and {KeywordNameValidation.MAXLENGTH} characters long.")
        {
        }

        public KeywordNameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
using System;

namespace NewMovieDatabase.Keywords
{
    internal class KeywordAlreadyExistException : Exception
    {
        public KeywordAlreadyExistException(Keyword item) : base($"Keyword {item.Name} already exists, please choose another.")
        {
        }

        public KeywordAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
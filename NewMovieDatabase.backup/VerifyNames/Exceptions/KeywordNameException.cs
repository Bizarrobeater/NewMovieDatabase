using System;

namespace NewMovieDatabase.VerifyNames
{
    public class KeywordNameException : Exception
    {
        // TODO: Comment
        public KeywordNameException(string name)
            : base($"{name} is a reserved keyword in the database language, and cannot be used")
        {

        }
    }
}

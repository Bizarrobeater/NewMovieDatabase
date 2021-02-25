using System;

namespace NewMovieDatabase.VerifyNames
{
    class KeywordNameException : Exception
    {

        public KeywordNameException(string name)
            : base($"{name} is a reserved keyword in the database language, and cannot be used")
        {

        }
    }
}

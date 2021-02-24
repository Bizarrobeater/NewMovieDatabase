using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

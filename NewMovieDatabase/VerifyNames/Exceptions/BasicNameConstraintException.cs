using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.VerifyNames
{
    class BasicNameConstraintException : Exception
    {

        public BasicNameConstraintException(string name)
            : base($"{name} does not satisfy naming conventions.\nIt must start with a letter, and contain only letters(a-z), numbers or underscore.")
        {
        }
    }
}

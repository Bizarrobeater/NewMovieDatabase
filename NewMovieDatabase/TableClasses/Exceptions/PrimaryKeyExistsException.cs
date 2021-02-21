using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses
{
    class PrimaryKeyExistsException : Exception
    {
        public PrimaryKeyExistsException()
        {
        }

        public PrimaryKeyExistsException(Column TryAddColumn) : base($"{TryAddColumn} is a primary key and a primary key already exists in the table.")
        {
        }

        public PrimaryKeyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PrimaryKeyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

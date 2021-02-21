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

        public PrimaryKeyExistsException(Column TryAddColumn, Column CurrPrimKeyColumn) : base($"{TryAddColumn} is a primary key and {CurrPrimKeyColumn} is already a primary key in {CurrPrimKeyColumn.Table}")
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    public interface IDataBaseNameRules 
    {
        bool VerifyColumnName(string columnName, out string message);
        bool VerifyTableName(string name, out string message);
    }
}

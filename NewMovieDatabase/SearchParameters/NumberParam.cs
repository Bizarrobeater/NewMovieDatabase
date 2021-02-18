using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    public abstract class NumberParam : SearchParameter
    {
        public NumberParam(string parameter)
            : base(parameter)
        {

        }
        public override string ReturnAsSQLParameter()
        {
            throw new NotImplementedException();
        }
    }
}

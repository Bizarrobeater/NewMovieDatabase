using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    public class TextParamExact : TextParam
    {
        public TextParamExact(string parameter)
            : base(parameter)
        {
        }

        public override string ReturnAsSQLParameter()
        {
            return $"LIKE '{_searchParameter}'";
        }
    }
}

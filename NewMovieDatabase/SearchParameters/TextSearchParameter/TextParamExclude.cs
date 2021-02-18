using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    public class TextParamExclude : TextParam
    {
        public TextParamExclude(string parameter)
            : base(parameter)
        {
            _modifier = "NOT ";
        }
    }
}

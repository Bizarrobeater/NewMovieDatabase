﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    class TextParamInclude : TextParam
    {
        public TextParamInclude(string parameter) : base(parameter)
        {
            _modifier = "";
        }
    }
}

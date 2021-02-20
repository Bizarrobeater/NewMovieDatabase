using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.SearchParameters 
{ 
    public class DateSearchParam : GenericParam<DateAsParam>
    {
        public DateSearchParam(DateAsParam searchParameter) : base(searchParameter)
        {
        }
    }
}

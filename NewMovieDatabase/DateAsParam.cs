using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase
{
    // Class used for converting date string into usable SQL parameters
    public class DateAsParam : IComparable<DateAsParam>, IComparable<YearAsParam>
    {
        DateTime _date;

        protected DateTime Date => _date;

        public DateAsParam(string date)
        {
            _date = DateTime.Parse(date);
        }

        public DateAsParam(DateTime date)
        {
            _date = date;
        }

        public static implicit operator DateTime(DateAsParam date) => date.Date;

        public override string ToString()
        {
            return $"'{_date.Date.ToString("yyyy-MM-dd")}'";
        }

        public int CompareTo(DateAsParam other)
        {
            return _date.CompareTo(other.Date);
        }

        public int CompareTo(YearAsParam other)
        {
            int startCompare = CompareTo(other.YearStart);
            int endCompare = CompareTo(other.YearEnd);

            return startCompare == endCompare ? startCompare : 0;
        }
    }
}

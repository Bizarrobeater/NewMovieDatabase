using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.SearchParameters
{
    // Class used for converting years into usuable SQL parameters

    // TODO: Comment
    public class YearAsParam : IComparable<YearAsParam>, IComparable<DateAsParam>
    {
        DateAsParam _yearStart;
        DateAsParam _yearEnd;
        int _year;

        protected int Year { get => _year; }
        public DateAsParam YearStart { get => _yearStart; }
        public DateAsParam YearEnd { get => _yearEnd; }
        public YearAsParam(int year)
        {
            _year = year;
            _yearStart = new DateAsParam($"{year}-01-01");
            _yearEnd = new DateAsParam($"{year}-12-31");
        }

        public int CompareTo(DateAsParam other)
        {
            int startCompare = YearStart.CompareTo(other);
            int endCompare = YearEnd.CompareTo(other);

            return startCompare == endCompare ? startCompare : 0;
        }

        public int CompareTo(YearAsParam other)
        {
            return _year.CompareTo(other.Year);
        }

        public static explicit operator DateAsParam[](YearAsParam year) 
        {
            return new DateAsParam[]{
                year.YearStart,
                year.YearEnd,
            };
        }
    }
}

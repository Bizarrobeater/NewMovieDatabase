using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.SQLBuilder
{
    // Class used for converting years into usuable SQL parameters
    /// <summary>
    /// Class representing a year from the start date to the end date.
    /// </summary>
    public class YearAsParam : IComparable<YearAsParam>, IComparable<DateAsParam>
    {
        DateAsParam _yearStart;
        DateAsParam _yearEnd;
        int _year;

        protected int Year { get => _year; }

        /// <summary>
        /// Gets the start date of the year, as an SQL parameter.
        /// </summary>
        public DateAsParam YearStart { get => _yearStart; }

        /// <summary>
        /// Gets the end date of the year, as an SQL parameter.
        /// </summary>
        public DateAsParam YearEnd { get => _yearEnd; }
        
        /// <summary>
        /// Initialises <see cref="YearAsParam"/> based on an int representing a year.
        /// </summary>
        /// <param name="year"></param>
        public YearAsParam(int year)
        {
            _year = year;
            _yearStart = new DateAsParam($"{year}-01-01");
            _yearEnd = new DateAsParam($"{year}-12-31");
        }

        /// <inheritdoc/>
        public int CompareTo(DateAsParam other)
        {
            int startCompare = YearStart.CompareTo(other);
            int endCompare = YearEnd.CompareTo(other);

            return startCompare == endCompare ? startCompare : 0;
        }

        /// <inheritdoc/>
        public int CompareTo(YearAsParam other)
        {
            return _year.CompareTo(other.Year);
        }
    }
}

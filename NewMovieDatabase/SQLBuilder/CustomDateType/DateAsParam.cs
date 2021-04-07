using System;

namespace NewMovieDatabase.SQLBuilder
{

    /// <summary>
    /// Class representing dates, and is easily converted into SQL date types.
    /// </summary>
    public class DateAsParam : IComparable<DateAsParam>, IComparable<YearAsParam>, IComparable<DateTime>
    {
        DateTime _date;

        string _dateFormatted { get => _date.Date.ToString("yyyy-MM-dd"); }
        protected DateTime Date => _date;

        // TODO: ensure only proper formatted dates gets into contructor.
        /// <summary>
        /// Initialises <see cref="DateAsParam"/> based on a datestring.
        /// Will fail if the date is not formatted properly.
        /// </summary>
        /// <param name="date">Date as string</param>
        public DateAsParam(string date)
        {
            _date = DateTime.Parse(date);
        }

        /// <summary>
        /// Initialises <see cref="DateAsParam"/> based on a <see cref="DateTime"/> parameter.
        /// </summary>
        /// <param name="date">Datetime parameter</param>
        public DateAsParam(DateTime date)
        {
            _date = date;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"'{_dateFormatted}'";
        }

        /// <inheritdoc/>
        public int CompareTo(DateAsParam other)
        {
            return Date.CompareTo(other.Date);
        }

        /// <inheritdoc/>
        public int CompareTo(YearAsParam other)
        {
            int startCompare = CompareTo(other.YearStart);
            int endCompare = CompareTo(other.YearEnd);

            return startCompare == endCompare ? startCompare : 0;
        }

        /// <inheritdoc/>
        public int CompareTo(DateTime other)
        {
            return Date.CompareTo(other);
        }
    }
}

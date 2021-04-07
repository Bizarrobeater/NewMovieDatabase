using System;

namespace NewMovieDatabase.SearchParameters
{
    // Class used for converting date string into usable SQL parameters

    // TODO: Comment
    public class DateAsParam : IComparable<DateAsParam>, IComparable<YearAsParam>, IComparable<DateTime>
    {
        DateTime _date;

        string _dateFormatted { get => _date.Date.ToString("yyyy-MM-dd"); }
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
            return $"'{_dateFormatted}'";
        }

        public int CompareTo(DateAsParam other)
        {
            return Date.CompareTo(other.Date);
        }

        public int CompareTo(YearAsParam other)
        {
            int startCompare = CompareTo(other.YearStart);
            int endCompare = CompareTo(other.YearEnd);

            return startCompare == endCompare ? startCompare : 0;
        }

        public int CompareTo(DateTime other)
        {
            return Date.CompareTo(other);
        }
    }
}

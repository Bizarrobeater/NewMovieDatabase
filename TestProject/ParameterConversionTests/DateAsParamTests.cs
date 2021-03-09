using NUnit.Framework;
using NewMovieDatabase;
using System;

namespace TestProject
{
    [TestFixture]
    public class DateAsParamTests
    {
        DateAsParam dateAsParam;
        DateTime actualDate;
        string convertedDate;
        string expected;

        public void InitialiseConversionTest(string stringDate)
        {
            dateAsParam = new DateAsParam(stringDate);
            actualDate = DateTime.Parse(stringDate);
            convertedDate = actualDate.ToString("yyyy-MM-dd");
            expected = $"'{convertedDate}'";
        }
        

        [TestCase("01-01-2020")]
        [TestCase("2020-01-01")]
        [TestCase("01/01/20")]
        [TestCase("31-01-2020")]
        public void TestDateStringConversion(string stringDate)
        {
            InitialiseConversionTest(stringDate);

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestCase("31-01-2020")]
        public void TestDateConversion(string stringDate)
        {
            InitialiseConversionTest(stringDate);

            dateAsParam = new DateAsParam(actualDate);

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestCase("01-01-2020", "2020-12-31")]
        [TestCase("12-12-2012", "13-12-2012")]
        [TestCase("05-01-2022", "01-01-2030")]
        public void TestDateAsParamCompare(string lowDateString, string highDateString)
        {
            DateAsParam lowDateAsParam = new DateAsParam(lowDateString);
            DateAsParam highDateAsParam = new DateAsParam(highDateString);

            DateTime lowDateTime = DateTime.Parse(lowDateString);
            DateTime highDateTime = DateTime.Parse(highDateString);

            Assert.AreEqual(lowDateTime.CompareTo(highDateTime), lowDateAsParam.CompareTo(highDateAsParam));
            Assert.AreEqual(highDateTime.CompareTo(lowDateTime), highDateAsParam.CompareTo(lowDateAsParam));
        }

        [Test]
        public void TestImplicitConversionDateAsParam()
        {
            DateAsParam dateAsParam = new DateAsParam("2020-01-01");

            DateTime before = DateTime.Parse("2019-01-01");
            DateTime after = DateTime.Parse("2021-01-01");
            DateTime same = DateTime.Parse("2020-01-01");

            Assert.AreEqual(-1, before.CompareTo(dateAsParam));
            Assert.AreEqual(1, after.CompareTo(dateAsParam));
            Assert.AreEqual(0, same.CompareTo(dateAsParam));

            Assert.AreEqual(1, dateAsParam.CompareTo(before));
            Assert.AreEqual(-1, dateAsParam.CompareTo(after));
            Assert.AreEqual(0, dateAsParam.CompareTo(same));
        }
    }
}

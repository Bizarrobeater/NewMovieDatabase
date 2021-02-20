using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase;
using System;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class DateAsParamTests
    {
        [TestMethod]
        public void TestDateStringConversion1()
        {
            string testDate = "01-01-2020";
            DateAsParam dateAsParam = new DateAsParam(testDate);

            DateTime actualDate = DateTime.Parse(testDate);
            string convertedDate = actualDate.ToString("yyyy-MM-dd");
            string expected = $"'{convertedDate}'";

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestMethod]
        public void TestDateStringConversion2()
        {
            string testDate = "2020-01-01";
            DateAsParam dateAsParam = new DateAsParam(testDate);

            DateTime actualDate = DateTime.Parse(testDate);
            string convertedDate = actualDate.ToString("yyyy-MM-dd");
            string expected = $"'{convertedDate}'";

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestMethod]
        public void TestDateStringConversion3()
        {
            string testDate = "01/01/20";
            DateAsParam dateAsParam = new DateAsParam(testDate);

            DateTime actualDate = DateTime.Parse(testDate);
            string convertedDate = actualDate.ToString("yyyy-MM-dd");
            string expected = $"'{convertedDate}'";

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestMethod]
        public void TestDateStringConversion4()
        {
            string testDate = "31-01-2020";
            DateAsParam dateAsParam = new DateAsParam(testDate);

            DateTime actualDate = DateTime.Parse(testDate);
            string convertedDate = actualDate.ToString("yyyy-MM-dd");
            string expected = $"'{convertedDate}'";

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestMethod]
        public void TestDateConversion()
        {
            string testDate = "31-01-2020";
            DateTime actualDate = DateTime.Parse(testDate);

            DateAsParam dateAsParam = new DateAsParam(actualDate);
            
            string convertedDate = actualDate.ToString("yyyy-MM-dd");
            string expected = $"'{convertedDate}'";

            Assert.AreEqual(expected, dateAsParam.ToString());
        }

        [TestMethod]
        public void TestDateAsParamCompare()
        {
            string lowStringDate = "01-01-2020";
            string highStringDate = "2020-12-31";

            DateAsParam lowDateAsParam = new DateAsParam(lowStringDate);
            DateAsParam highDateAsParam = new DateAsParam(highStringDate);

            DateTime lowDate = DateTime.Parse(lowStringDate);
            DateTime highDate = DateTime.Parse(highStringDate);

            Assert.AreEqual(lowDate.CompareTo(highDate), lowDateAsParam.CompareTo(highDateAsParam));
            Assert.AreEqual(highDate.CompareTo(lowDate), highDateAsParam.CompareTo(lowDateAsParam));
        }

        [TestMethod]
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

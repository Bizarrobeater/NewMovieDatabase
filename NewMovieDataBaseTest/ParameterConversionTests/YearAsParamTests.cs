using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase;
using System;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class YearAsParamTests
    {
        [TestMethod]
        public void TestClassCreation()
        {
            int testYear = 2015;
            YearAsParam yearAsParam = new YearAsParam(testYear);

            DateTime startDate = DateTime.Parse($"{testYear}-01-01");
            DateTime endDate = DateTime.Parse($"{testYear}-12-31");

            string expectedStart = $"'{startDate.ToString("yyyy-MM-dd")}'";
            string expectedEnd = $"'{endDate.ToString("yyyy-MM-dd")}'";

            Assert.AreEqual(expectedStart, yearAsParam.YearStart.ToString());
            Assert.AreEqual(expectedEnd, yearAsParam.YearEnd.ToString());
        }

        [TestMethod]
        public void TestCompareToSameType()
        {
            int lowYear = 2015;
            int highYear = 2020;
            YearAsParam low = new YearAsParam(lowYear);
            YearAsParam high = new YearAsParam(highYear);

            Assert.AreEqual(lowYear.CompareTo(highYear), low.CompareTo(high));
            Assert.AreEqual(highYear.CompareTo(lowYear), high.CompareTo(low));
            Assert.AreEqual(lowYear.CompareTo(lowYear), low.CompareTo(low));
        }

        [TestMethod]
        public void TestCompareToDifferentTypeg()
        {
            int testYear = 2020;
            YearAsParam yearAsParam = new YearAsParam(testYear);
            
            DateAsParam lowCompareDate = new DateAsParam("2010-01-01");
            DateAsParam highCompareDate = new DateAsParam("2021-01-01");
            DateAsParam sameYearCompareDate = new DateAsParam("2020-01-01");

            Assert.AreEqual(1, yearAsParam.CompareTo(lowCompareDate));          // lowCompareDate is before than the startDate of the testYear
            Assert.AreEqual(-1, yearAsParam.CompareTo(highCompareDate));        // lowCompareDate is after the endDate of the testYear
            Assert.AreEqual(0, yearAsParam.CompareTo(sameYearCompareDate));     // sameYearCompare date is in the same year
        }

    }
}

//using NUnit.Framework;
//using NewMovieDatabase;
//using System;
//using NewMovieDatabase.SearchParameters;

//namespace TestProject
//{
//    [TestFixture]
//    public class YearAsParamTests
//    {
//        [TestCase(2015)]
//        [TestCase(1999)]
//        [TestCase(2021)]
//        public void TestClassCreation(int testYear)
//        {
//            YearAsParam yearAsParam = new YearAsParam(testYear);

//            DateTime startDate = DateTime.Parse($"{testYear}-01-01");
//            DateTime endDate = DateTime.Parse($"{testYear}-12-31");

//            string expectedStart = $"'{startDate.ToString("yyyy-MM-dd")}'";
//            string expectedEnd = $"'{endDate.ToString("yyyy-MM-dd")}'";

//            Assert.AreEqual(expectedStart, yearAsParam.YearStart.ToString());
//            Assert.AreEqual(expectedEnd, yearAsParam.YearEnd.ToString());
//        }

//        [TestCase(2015, 2020)]
//        [TestCase(2012, 2018)]
//        [TestCase(1999, 2000)]
//        [TestCase(1980, 2020)]
//        public void TestCompareToSameType(int lowYear, int highYear)
//        {

//            YearAsParam low = new YearAsParam(lowYear);
//            YearAsParam high = new YearAsParam(highYear);

//            Assert.AreEqual(lowYear.CompareTo(highYear), low.CompareTo(high));
//            Assert.AreEqual(highYear.CompareTo(lowYear), high.CompareTo(low));
//            Assert.AreEqual(lowYear.CompareTo(lowYear), low.CompareTo(low));
//        }

//        [Test]
//        public void TestCompareToDifferentType()
//        {
//            int testYear = 2020;
//            YearAsParam yearAsParam = new YearAsParam(testYear);
            
//            DateAsParam lowCompareDate = new DateAsParam("2010-01-01");
//            DateAsParam highCompareDate = new DateAsParam("2021-01-01");
//            DateAsParam sameYearCompareDate = new DateAsParam("2020-01-01");

//            Assert.AreEqual(1, yearAsParam.CompareTo(lowCompareDate));          // lowCompareDate is before than the startDate of the testYear
//            Assert.AreEqual(-1, yearAsParam.CompareTo(highCompareDate));        // lowCompareDate is after the endDate of the testYear
//            Assert.AreEqual(0, yearAsParam.CompareTo(sameYearCompareDate));     // sameYearCompare date is in the same year
//        }

//    }
//}

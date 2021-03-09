using NUnit.Framework;
using NewMovieDatabase;
using NewMovieDatabase.SearchParameters;
using System;

namespace TestProject
{
    [TestFixture]
    public class GenericParamTest
    {
        ISearchParameter searchParameter;
        string expected;

        int lowInt = 1234;
        int highInt = 5000;

        // Testing int for generics
        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamEqualInt(int testInt)
        {            
            expected = $"= {testInt}";
            searchParameter = new GenericParamEqual<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamNotEqualInt(int testInt)
        {            
            expected = $"!= {testInt}";
            searchParameter = new GenericParamNotEqual<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamLargerThanInt(int testInt)
        {            
            expected = $">= {testInt}";
            ISearchParameter searchParameter = new GenericParamLargerThan<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamNotLargerThanInt(int testInt)
        {            
            expected = $"!> {testInt}";
            searchParameter = new GenericParamNotLargerThan<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamSmallerThanInt(int testInt)
        {            
            expected = $"<= {testInt}";
            searchParameter = new GenericParamSmallerThan<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamNotSmallerThanInt(int testInt)
        {            
            expected = $"!< {testInt}";
            searchParameter = new GenericParamNotSmallerThan<int>(testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234, 5000)]
        [TestCase(6000, 7000)]
        public void TestGenericParamBetweenInt(int lowInt, int highInt)
        {
            expected = $"BETWEEN {lowInt} AND {highInt}";
            searchParameter = new GenericParamBetween<int>(lowInt, highInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234, 5000)]
        [TestCase(6000, 7000)]
        public void TestGenericParamNotBetweenInt(int lowInt, int highInt)
        {
            string expected = $"NOT BETWEEN {lowInt} AND {highInt}";
            ISearchParameter searchParameter = new GenericParamNotBetween<int>(lowInt, highInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234, 5000)]
        [TestCase(6000, 7000)]
        public void TestGenericParamBetweenHighFirstInt(int lowInt, int highInt)
        {
            expected = $"BETWEEN {lowInt} AND {highInt}";
            searchParameter = new GenericParamBetween<int>(highInt, lowInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamBetweenSameNumberInt(int testInt)
        {
            expected = $"= {testInt}";
            searchParameter = new GenericParamBetween<int>(testInt, testInt);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }


        // Testing double for generics
        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamEqualDouble(double testDouble)
        {
            expected = $"= {testDouble}";
            searchParameter = new GenericParamEqual<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamNotEqualDouble(double testDouble)
        {
            expected = $"!= {testDouble}";

            searchParameter = new GenericParamNotEqual<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamLargerThanDouble(double testDouble)
        {
            expected = $">= {testDouble}";
            searchParameter = new GenericParamLargerThan<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamNotLargerThanDouble(double testDouble)
        {
            expected = $"!> {testDouble}";
            searchParameter = new GenericParamNotLargerThan<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamSmallerThanDouble(double testDouble)
        {
            expected = $"<= {testDouble}";
            searchParameter = new GenericParamSmallerThan<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamNotSmallerThanDouble(double testDouble)
        {
            expected = $"!< {testDouble}";
            searchParameter = new GenericParamNotSmallerThan<double>(testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5, 7.6)]
        [TestCase(7.6, 96.5)]
        public void TestGenericParamBetweenDouble(double lowDouble, double highDouble)
        {
            expected = $"BETWEEN {lowDouble} AND {highDouble}";
            searchParameter = new GenericParamBetween<double>(lowDouble, highDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5, 7.6)]
        [TestCase(7.6, 96.5)]
        public void TestGenericParamNotBetweenDouble(double lowDouble, double highDouble)
        {
            expected = $"NOT BETWEEN {lowDouble} AND {highDouble}";
            searchParameter = new GenericParamNotBetween<double>(lowDouble, highDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5, 7.6)]
        [TestCase(7.6, 96.5)]
        public void TestGenericParamBetweenHighFirstDouble(double lowDouble, double highDouble)
        {
            expected = $"BETWEEN {lowDouble} AND {highDouble}";
            searchParameter = new GenericParamBetween<double>(highDouble, lowDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamBetweenSameNumberDouble(double testDouble)
        {
            expected = $"= {testDouble}";
            searchParameter = new GenericParamBetween<double>(testDouble, testDouble);

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }


        // Testing for Dates

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamEqualDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamEqual<DateAsParam>(dateAsParam);

            expected = $"= '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamNotEqualDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamNotEqual<DateAsParam>(dateAsParam);

            expected = $"!= '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamLargerThanDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamLargerThan<DateAsParam>(dateAsParam);

            expected = $">= '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamNotLargerThanDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamNotLargerThan<DateAsParam>(dateAsParam);

            expected = $"!> '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamSmallerThanDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamSmallerThan<DateAsParam>(dateAsParam);

            expected = $"<= '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamNotSmallerThanDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamNotSmallerThan<DateAsParam>(dateAsParam);

            expected = $"!< '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01", "2020-12-31")]
        [TestCase("2019-01-01", "2019-01-02")]
        public void TestGenericParamBetweenDate(string lowDate, string highDate)
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            searchParameter = new GenericParamBetween<DateAsParam>(low, high);

            expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01", "2020-12-31")]
        [TestCase("2019-01-01", "2019-01-02")]
        public void TestGenericParamNotBetweenDate(string lowDate, string highDate)
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            searchParameter = new GenericParamNotBetween<DateAsParam>(low, high);

            expected = $"NOT BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01", "2020-12-31")]
        [TestCase("2019-01-01", "2019-01-02")]
        public void TestGenericParamBetweenHighFirstDate(string lowDate, string highDate)
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);

            searchParameter = new GenericParamBetween<DateAsParam>(high, low);

            expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamBetweenSameNumberDate(string testDate)
        {
            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new GenericParamEqual<DateAsParam>(dateAsParam);

            expected = $"= '{testDate}'";

            Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        }
    }
}

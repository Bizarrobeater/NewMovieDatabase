using NUnit.Framework;
using NewMovieDatabase.SearchParameters;
using System;

namespace TestProject
{
    [TestFixture]
    public class GenericDecoratorTests
    {
        ISearchParameter searchParameter;
        string expected;

        #region INT_TESTS
        // Testing int for generics
        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamEqualInt(int testInt)
        {
            expected = $"= {testInt}";
            searchParameter = new SearchParameter<int>(testInt);
            searchParameter = new EqualDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamLargerThanInt(int testInt)
        {
            expected = $">= {testInt}";
            searchParameter = new SearchParameter<int>(testInt);
            searchParameter = new LargerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamSmallerThanInt(int testInt)
        {
            expected = $"<= {testInt}";
            searchParameter = new SearchParameter<int>(testInt);
            searchParameter = new SmallerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase(1234, 5000)]
        [TestCase(6000, 7000)]
        public void TestGenericParamBetweenInt(int lowInt, int highInt)
        {
            expected = $"BETWEEN {lowInt} AND {highInt}";
            searchParameter = new SearchParameter<int>(lowInt, highInt);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        //[TestCase(1234, 5000)]
        //[TestCase(6000, 7000)]
        //public void TestGenericParamBetweenHighFirstInt(int lowInt, int highInt)
        //{
        //    expected = $"BETWEEN {lowInt} AND {highInt}";
        //    searchParameter = new SearchBetweenParameter<int>(highInt, lowInt);
        //    searchParameter = new BetweenDecorator(searchParameter);

        //    Assert.AreEqual(expected, searchParameter.AsSQLString);
        //}

        [TestCase(1234)]
        [TestCase(5000)]
        public void TestGenericParamBetweenSameNumberInt(int testInt)
        {
            expected = $"BETWEEN {testInt} AND {testInt}";
            searchParameter = new SearchParameter<int>(testInt, testInt);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }
        #endregion INT_TESTS

        #region DOUBLE_TESTS
        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamEqualDouble(double testDouble)
        {
            expected = $"= {testDouble}";
            searchParameter = new SearchParameter<double>(testDouble);
            searchParameter = new EqualDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamLargerThanDouble(double testDouble)
        {
            expected = $">= {testDouble}";
            searchParameter = new SearchParameter<double>(testDouble);
            searchParameter = new LargerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamSmallerThanDouble(double testDouble)
        {
            expected = $"<= {testDouble}";
            searchParameter = new SearchParameter<double>(testDouble);
            searchParameter = new SmallerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase(5.5, 7.6)]
        [TestCase(7.6, 96.5)]
        public void TestGenericParamBetweenDouble(double lowDouble, double highDouble)
        {
            expected = $"BETWEEN {lowDouble} AND {highDouble}";
            searchParameter = new SearchParameter<double>(lowDouble, highDouble);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        //[TestCase(5.5, 7.6)]
        //[TestCase(7.6, 96.5)]
        //public void TestGenericParamBetweenHighFirstDouble(double lowDouble, double highDouble)
        //{
        //    expected = $"BETWEEN {lowDouble} AND {highDouble}";
        //    searchParameter = new SearchBetweenParameter<double>(highDouble, lowDouble);
        //    searchParameter = new BetweenDecorator(searchParameter);

        //    Assert.AreEqual(expected, searchParameter.AsSQLString);
        //}

        [TestCase(5.5)]
        [TestCase(7.6)]
        public void TestGenericParamBetweenSameNumberDouble(double testDouble)
        {
            expected = $"BETWEEN {testDouble} AND {testDouble}";
            searchParameter = new SearchParameter<double>(testDouble, testDouble);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        #endregion DOUBLE_TESTS

        #region DATE_TESTS

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamEqualDate(string testDate)
        {
            expected = $"= '{testDate}'";

            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new SearchParameter<DateAsParam>(dateAsParam);
            searchParameter = new EqualDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamLargerThanDate(string testDate)
        {
            expected = $">= '{testDate}'";

            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new SearchParameter<DateAsParam>(dateAsParam);
            searchParameter = new LargerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }


        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamSmallerThanDate(string testDate)
        {
            expected = $"<= '{testDate}'";

            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new SearchParameter<DateAsParam>(dateAsParam);
            searchParameter = new SmallerThanDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        [TestCase("2020-01-01", "2020-12-31")]
        [TestCase("2019-01-01", "2019-01-02")]
        public void TestGenericParamBetweenDate(string lowDate, string highDate)
        {
            expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);

            searchParameter = new SearchParameter<DateAsParam>(low, high);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        //[TestCase("2020-01-01", "2020-12-31")]
        //[TestCase("2019-01-01", "2019-01-02")]
        //public void TestGenericParamBetweenHighFirstDate(string lowDate, string highDate)
        //{
        //    expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

        //    DateAsParam low = new DateAsParam(lowDate);
        //    DateAsParam high = new DateAsParam(highDate);

        //    searchParameter = new SearchParameter<DateAsParam>(high, low);
        //    searchParameter = new BetweenDecorator(searchParameter);

        //    Assert.AreEqual(expected, searchParameter.AsSQLString);
        //}

        [TestCase("2020-01-01")]
        [TestCase("2020-12-31")]
        public void TestGenericParamBetweenSameNumberDate(string testDate)
        {
            expected = $"BETWEEN '{testDate}' AND '{testDate}'";

            DateAsParam dateAsParam = new DateAsParam(testDate);
            searchParameter = new SearchParameter<DateAsParam>(dateAsParam, dateAsParam);
            searchParameter = new BetweenDecorator(searchParameter);

            Assert.AreEqual(expected, searchParameter.AsSQLString);
        }

        #region YEAR_TESTS

        //[TestCase(2020)]
        //[TestCase(2012)]
        //public void TestGenericParamBetweenDate(int testYear)
        //{
        //    expected = $"BETWEEN '{testYear}-01-01' AND '{testYear}-12-31'";

        //    YearAsParam year = new YearAsParam(testYear);

        //    searchParameter = new SearchBetweenParameter<DateAsParam>();
        //    searchParameter = new BetweenDecorator(searchParameter);



        //    Assert.AreEqual(expected, searchParameter.ReturnAsSQLParameter);
        //}

        #endregion YEAR_TESTS

        #endregion DATE_TESTS
    }
}

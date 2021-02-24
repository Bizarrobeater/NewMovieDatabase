using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase;
using NewMovieDatabase.SearchParameters;


namespace NewMovieDataBaseTest
{
    [TestClass]
    public class GenericParamTest
    {
        int lowInt = 1234;
        int highInt = 5000;

        // Testing int for generics
        [TestMethod]
        public void TestGenericParamEqualInt()
        {            
            string expected = $"= {lowInt}";
            ISearchParameter searchparam = new GenericParamEqual<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualInt()
        {            
            string expected = $"!= {lowInt}";

            ISearchParameter searchparam = new GenericParamNotEqual<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanInt()
        {            
            string expected = $">= {lowInt}";
            ISearchParameter searchparam = new GenericParamLargerThan<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanInt()
        {            
            string expected = $"!> {lowInt}";
            ISearchParameter searchparam = new GenericParamNotLargerThan<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanInt()
        {            
            string expected = $"<= {lowInt}";
            ISearchParameter searchparam = new GenericParamSmallerThan<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanInt()
        {            
            string expected = $"!< {lowInt}";
            ISearchParameter searchparam = new GenericParamNotSmallerThan<int>(lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenInt()
        {
            string expected = $"BETWEEN {lowInt} AND {highInt}";
            ISearchParameter searchparam = new GenericParamBetween<int>(lowInt, highInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenInt()
        {
            string expected = $"NOT BETWEEN {lowInt} AND {highInt}";
            ISearchParameter searchparam = new GenericParamNotBetween<int>(lowInt, highInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstInt()
        {
            string expected = $"BETWEEN {lowInt} AND {highInt}";
            ISearchParameter searchparam = new GenericParamBetween<int>(highInt, lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberInt()
        {
            string expected = $"= {lowInt}";
            ISearchParameter searchparam = new GenericParamBetween<int>(lowInt, lowInt);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }


        // Testing double for generics
        double lowDouble = 5.5;
        double highDouble = 7.6;

        [TestMethod]
        public void TestGenericParamEqualDouble()
        {
            string expected = $"= {lowDouble}";
            ISearchParameter searchparam = new GenericParamEqual<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualDouble()
        {
            string expected = $"!= {lowDouble}";

            ISearchParameter searchparam = new GenericParamNotEqual<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanDouble()
        {
            string expected = $">= {lowDouble}";
            ISearchParameter searchparam = new GenericParamLargerThan<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanDouble()
        {
            string expected = $"!> {lowDouble}";
            ISearchParameter searchparam = new GenericParamNotLargerThan<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanDouble()
        {
            string expected = $"<= {lowDouble}";
            ISearchParameter searchparam = new GenericParamSmallerThan<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanDouble()
        {
            string expected = $"!< {lowDouble}";
            ISearchParameter searchparam = new GenericParamNotSmallerThan<double>(lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenDouble()
        {
            string expected = $"BETWEEN {lowDouble} AND {highDouble}";
            ISearchParameter searchparam = new GenericParamBetween<double>(lowDouble, highDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenDouble()
        {
            string expected = $"NOT BETWEEN {lowDouble} AND {highDouble}";
            ISearchParameter searchparam = new GenericParamNotBetween<double>(lowDouble, highDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstDouble()
        {
            string expected = $"BETWEEN {lowDouble} AND {highDouble}";
            ISearchParameter searchparam = new GenericParamBetween<double>(highDouble, lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberDouble()
        {
            string expected = $"= {lowDouble}";
            ISearchParameter searchparam = new GenericParamBetween<double>(lowDouble, lowDouble);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }


        string lowDate = "2010-01-01";
        string highDate = "2020-12-31";
        // Testing for Dates

        [TestMethod]
        public void TestGenericParamEqualDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamEqual<DateAsParam>(dateAsParam);

            string expected = $"= '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamNotEqual<DateAsParam>(dateAsParam);

            string expected = $"!= '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamLargerThan<DateAsParam>(dateAsParam);

            string expected = $">= '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamNotLargerThan<DateAsParam>(dateAsParam);

            string expected = $"!> '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamSmallerThan<DateAsParam>(dateAsParam);

            string expected = $"<= '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamNotSmallerThan<DateAsParam>(dateAsParam);

            string expected = $"!< '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenDate()
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            ISearchParameter searchparam = new GenericParamBetween<DateAsParam>(low, high);

            string expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenDate()
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            ISearchParameter searchparam = new GenericParamNotBetween<DateAsParam>(low, high);

            string expected = $"NOT BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstDate()
        {
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);

            ISearchParameter searchparam = new GenericParamBetween<DateAsParam>(high, low);

            string expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberDate()
        {
            DateAsParam dateAsParam = new DateAsParam(lowDate);
            ISearchParameter searchparam = new GenericParamEqual<DateAsParam>(dateAsParam);

            string expected = $"= '{lowDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }
    }
}

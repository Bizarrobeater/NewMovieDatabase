using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase;
using NewMovieDatabase.SearchParameters;


namespace NewMovieDataBaseTest
{
    [TestClass]
    public class GenericParamTest
    {
        // Testing int for generics
        [TestMethod]
        public void TestGenericParamEqualInt()
        {
            int testnumber = 1234;
            string expected = $"= {testnumber}";
            ISearchParameter searchparam = new GenericParamEqual<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualInt()
        {
            int testnumber = 1234;
            string expected = $"!= {testnumber}";

            ISearchParameter searchparam = new GenericParamNotEqual<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanInt()
        {
            int testnumber = 1234;
            string expected = $">= {testnumber}";
            ISearchParameter searchparam = new GenericParamLargerThan<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanInt()
        {
            int testnumber = 1234;
            string expected = $"!> {testnumber}";
            ISearchParameter searchparam = new GenericParamNotLargerThan<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanInt()
        {
            int testnumber = 1234;
            string expected = $"<= {testnumber}";
            ISearchParameter searchparam = new GenericParamSmallerThan<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanInt()
        {
            int testnumber = 1234;
            string expected = $"!< {testnumber}";
            ISearchParameter searchparam = new GenericParamNotSmallerThan<int>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenInt()
        {
            int low = 1234;
            int high = 5000;
            string expected = $"BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamBetween<int>(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenInt()
        {
            int low = 1234;
            int high = 5000;
            string expected = $"NOT BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamNotBetween<int>(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstInt()
        {
            int low = 1234;
            int high = 5000;
            string expected = $"BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamBetween<int>(high, low);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberInt()
        {
            int testnumber = 1234;
            string expected = $"= {testnumber}";
            ISearchParameter searchparam = new GenericParamBetween<int>(testnumber, testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }


        // Testing double for generics
       
        [TestMethod]
        public void TestGenericParamEqualDouble()
        {
            double testnumber = 5.5;
            string expected = $"= {testnumber}";
            ISearchParameter searchparam = new GenericParamEqual<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualDouble()
        {
            double testnumber = 5.5;
            string expected = $"!= {testnumber}";

            ISearchParameter searchparam = new GenericParamNotEqual<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanDouble()
        {
            double testnumber = 5.5;
            string expected = $">= {testnumber}";
            ISearchParameter searchparam = new GenericParamLargerThan<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanDouble()
        {
            double testnumber = 5.5;
            string expected = $"!> {testnumber}";
            ISearchParameter searchparam = new GenericParamNotLargerThan<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanDouble()
        {
            double testnumber = 5.5;
            string expected = $"<= {testnumber}";
            ISearchParameter searchparam = new GenericParamSmallerThan<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanDouble()
        {
            double testnumber = 5.5;
            string expected = $"!< {testnumber}";
            ISearchParameter searchparam = new GenericParamNotSmallerThan<double>(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenDouble()
        {
            double low = 5.5;
            double high = 9.8;
            string expected = $"BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamBetween<double>(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenDouble()
        {
            double low = 5.5;
            double high = 9.8;
            string expected = $"NOT BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamNotBetween<double>(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstDouble()
        {
            double low = 5.5;
            double high = 9.8;
            string expected = $"BETWEEN {low} AND {high}";
            ISearchParameter searchparam = new GenericParamBetween<double>(high, low);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberDouble()
        {
            double testnumber = 5.5;
            string expected = $"= {testnumber}";
            ISearchParameter searchparam = new GenericParamBetween<double>(testnumber, testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        // Testing for Dates

        [TestMethod]
        public void TestGenericParamEqualDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamEqual<DateAsParam>(dateAsParam);

            string expected = $"= '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotEqualDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamNotEqual<DateAsParam>(dateAsParam);

            string expected = $"!= '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamLargerThanDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamLargerThan<DateAsParam>(dateAsParam);

            string expected = $">= '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotLargerThanDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamNotLargerThan<DateAsParam>(dateAsParam);

            string expected = $"!> '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamSmallerThanDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamSmallerThan<DateAsParam>(dateAsParam);

            string expected = $"<= '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotSmallerThanDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamNotSmallerThan<DateAsParam>(dateAsParam);

            string expected = $"!< '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenDate()
        {
            string lowDate = "2010-01-01";
            string highDate = "2020-12-30";
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            ISearchParameter searchparam = new GenericParamBetween<DateAsParam>(low, high);

            string expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamNotBetweenDate()
        {
            string lowDate = "2010-01-01";
            string highDate = "2020-12-30";
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);


            ISearchParameter searchparam = new GenericParamNotBetween<DateAsParam>(low, high);

            string expected = $"NOT BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenHighFirstDate()
        {
            string lowDate = "2010-01-01";
            string highDate = "2020-12-30";
            DateAsParam low = new DateAsParam(lowDate);
            DateAsParam high = new DateAsParam(highDate);

            ISearchParameter searchparam = new GenericParamBetween<DateAsParam>(high, low);

            string expected = $"BETWEEN '{lowDate}' AND '{highDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestGenericParamBetweenSameNumberDate()
        {
            string testDate = "2020-12-30";
            DateAsParam dateAsParam = new DateAsParam(testDate);
            ISearchParameter searchparam = new GenericParamEqual<DateAsParam>(dateAsParam);

            string expected = $"= '{testDate}'";

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }
    }
}

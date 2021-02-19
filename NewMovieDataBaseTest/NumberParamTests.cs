using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase.SearchParameters;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class NumberParamTests
    {
        [TestMethod]
        public void TestNumberParamEqual()
        {
            int testnumber = 1234;
            string expected = "= 1234";
            ISearchParameter searchparam = new NumberParamEqual(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamNotEqual()
        {
            int testnumber = 1234;
            string expected = "!= 1234";
            ISearchParameter searchparam = new NumberParamNotEqual(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamLargerThan()
        {
            int testnumber = 1234;
            string expected = "> 1234";
            ISearchParameter searchparam = new NumberParamLargerThan(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamNotLargerThan()
        {
            int testnumber = 1234;
            string expected = "!> 1234";
            ISearchParameter searchparam = new NumberParamNotLargerThan(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamSmallerThan()
        {
            int testnumber = 1234;
            string expected = "< 1234";
            ISearchParameter searchparam = new NumberParamSmallerThan(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamNotSmallerThan()
        {
            int testnumber = 1234;
            string expected = "!< 1234";
            ISearchParameter searchparam = new NumberParamNotSmallerThan(testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamBetween()
        {
            int low = 1234;
            int high = 5000;
            string expected = "BETWEEN 1234 AND 5000";
            ISearchParameter searchparam = new NumberParamBetween(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamNotBetween()
        {
            int low = 1234;
            int high = 5000;
            string expected = "NOT BETWEEN 1234 AND 5000";
            ISearchParameter searchparam = new NumberParamNotBetween(low, high);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamBetweenHighFirst()
        {
            int low = 1234;
            int high = 5000;
            string expected = "BETWEEN 1234 AND 5000";
            ISearchParameter searchparam = new NumberParamBetween(high, low);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }

        [TestMethod]
        public void TestNumberParamBetweenSameNumber()
        {
            int testnumber = 1234;
            string expected = "= 1234";
            ISearchParameter searchparam = new NumberParamBetween(testnumber, testnumber);

            Assert.AreEqual(expected, searchparam.ReturnAsSQLParameter);
        }


    }
}

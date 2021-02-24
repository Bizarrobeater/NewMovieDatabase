using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewMovieDatabase.VerifyNames;

namespace NewMovieDataBaseTest
{
    [TestClass]
    public class ColumnTableNameCheckTests
    {
        static string testName;
        string partExpectedNamingConventionMessage = $" does not satisfy naming conventions." +
                $"\nIt must start with a letter, and contain only letters(a-z), numbers or underscore.";

        string partKeywordExceptionMessage = $" is a reserved keyword in the database language, and cannot be used";

        string succesMessage = "";

        [TestMethod]
        public void TestNameConventionException1()
        {
            testName = " asdsa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException2()
        {
            testName = "1asdsa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException3()
        {
            testName = "_asdsa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException4()
        {
            testName = "Øasdsa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException5()
        {
            testName = "ads asd";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException6()
        {
            testName = "as^dsa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameConventionException7()
        {
            testName = "asd_-_aa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partExpectedNamingConventionMessage, message);
        }

        [TestMethod]
        public void TestNameKeywordException1()
        {
            testName = "JOIN";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partKeywordExceptionMessage, message);
        }

        [TestMethod]
        public void TestNameKeywordException2()
        {
            testName = "collate";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsFalse(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(testName + partKeywordExceptionMessage, message);
        }

        [TestMethod]
        public void TestNameSucces()
        {
            testName = "asdAA123_aa";
            IDataBaseNameRules rules = new VerifySQLiteName();
            string message;

            Assert.IsTrue(rules.VerifyColumnName(testName, out message));
            Assert.AreEqual(succesMessage, message);
        }








    }
}

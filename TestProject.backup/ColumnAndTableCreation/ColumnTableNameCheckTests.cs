using NUnit.Framework;
using NewMovieDatabase.VerifyNames;

namespace TestProject
{
    [TestFixture]
    class ColumnTableNameCheckTests
    {
        string partExpectedNamingConventionMessage = $" does not satisfy naming conventions." +
                $"\nIt must start with a letter, and contain only letters(a-z), numbers or underscore " +
                "and can be no longer than 30 characters.";

        string partKeywordExceptionMessage = $" is a reserved keyword in the database language, and cannot be used";

        string succesMessage = "";

        IDataBaseNameRules rules;

        [SetUp]
        public void SetupMethod()
        {
            rules = new VerifySQLiteName();
        }

        [TestCase(" asdsa")]
        [TestCase("1asdsa")]
        [TestCase("_asdsa")]
        [TestCase("Øasdsa")]
        [TestCase("ads asd")]
        [TestCase("as^dsa")]
        [TestCase("asd_-_aa")]
        [TestCase("abcdefghijklmnopqrstuvxyz123456789")]
        public void TestNameConventionException(string name)
        {
            string message;

            Assert.IsFalse(rules.VerifyColumnName(name, out message));
            Assert.AreEqual(name + partExpectedNamingConventionMessage, message);
        }

        [TestCase("JOIN")]
        [TestCase("collate")]
        public void TestNameKeywordException(string name)
        {
            string message;

            Assert.IsFalse(rules.VerifyColumnName(name, out message));
            Assert.AreEqual(name + partKeywordExceptionMessage, message);
        }

        [TestCase("asdAA123_aa")]
        public void TestColumnNameSucces(string name)
        {
            string message;

            Assert.IsTrue(rules.VerifyColumnName(name, out message));
            Assert.AreEqual(succesMessage, message);
        }

        [TestCase("asdAA123_aa")]
        public void TestTableNameSucces(string name)
        {
            string message;

            Assert.IsTrue(rules.VerifyTableName(name, out message));
            Assert.AreEqual(succesMessage, message);
        }

    }
}

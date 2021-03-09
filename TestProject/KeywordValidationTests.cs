using NUnit.Framework;
using NewMovieDatabase.Keywords;

namespace TestProject
{
    public class KeywordValidationTests
    {
        KeywordNameValidation testValidation;

        [SetUp]
        public void SetupMethod()
        {
            testValidation = new KeywordNameValidation();
        }

        [TestCase ("name")]
        [TestCase("a")]
        [TestCase("abcdefghijklmno")]
        [TestCase("ABASAS")]
        public void RegexTestsPass(string name)
        {
            Assert.IsTrue(testValidation.VerifyKeywordName(name));
        }


        [TestCase("")]
        [TestCase("as as")]
        [TestCase("1asdb")]
        [TestCase("sdfs!!")]
        [TestCase("abcdefghijklmnopq")]
        public void RegexTestsFail(string name)
        {
            Assert.IsFalse(testValidation.VerifyKeywordName(name));
        }

    }
}

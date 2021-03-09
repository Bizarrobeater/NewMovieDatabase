using System.Collections.Generic;
using NUnit.Framework;
using NewMovieDatabase.TableClasses;

namespace TestProject
{
    [TestFixture]
    public class TableCreationTests
    {
        string tableName = "testTable";
        Table table;


        // Tests related to the basic creation of tables
        [SetUp]
        public void SetupMethod()
        {
            table = new Table(tableName);
        }

        [Test]
        public void TableToString()
        {
            Assert.AreEqual(tableName, table.ToString());
            Assert.AreEqual(tableName, table.TableName);
        }

        [Test]
        public void TableEmptyCollection()
        {
            Assert.AreEqual(0, table.ColumnCount);
        }

        [Test]
        public void TableNoPrimaryKey()
        {
            Assert.IsFalse(table.HasPrimaryKey);
        }
    }
}

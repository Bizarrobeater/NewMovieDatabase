//using System.Collections.Generic;
//using NUnit.Framework;
//using NewMovieDatabase.TableClasses;

//namespace TestProject
//{
//    public class ColumnCreationTests
//    {
//        string tableName = "testTable";

//        List<string> columnNamesNoExceptions = new List<string>
//        {
//            "column1",
//            "column2",
//            "column3",
//        };


//        // Tests related to the basic creation of tables
//        private Table CreateTable(string tableName)
//        {
//            return new Table(tableName);
//        }

//        [TestMethod]
//        public void TestTableToString()
//        {
//            Table table = CreateTable(tableName);

//            Assert.AreEqual(tableName, table.ToString());
//            Assert.AreEqual(tableName, table.TableName);
//        }

//        [TestMethod]
//        public void TestTableEmptyCollection()
//        {
//            Table table = CreateTable(tableName);

//            Assert.AreEqual(0, table.ColumnCount);
//        }

//        [TestMethod]
//        public void TestTableNoPrimaryKey()
//        {
//            Table table = CreateTable(tableName);

//            Assert.IsFalse(table.HasPrimaryKey);
//        }

//        // Test regarding the creation of columns
//        private Column CreateColumnNoDataType(string ColumnName) => new Column(ColumnName);



//        private TableColumnCollection CreateColumnCollection(List<string> columnNames)
//        {
//            TableColumnCollection columns = new TableColumnCollection();
//            Column temp;
//            foreach (string columnName in columnNames)
//            {
//                temp = CreateColumnNoDataType(columnName);
//                columns.Add(temp);
//            }
//            return columns;
//        }



//    }
//}

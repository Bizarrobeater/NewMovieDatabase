using System.Collections.Generic;
using NUnit.Framework;
using NewMovieDatabase.TableClasses;

namespace TestProject
{
    [TestFixture]
    public class ColumnCreationTests
    {
        string columnName = "testColumn";
        Column column;


        string tableName = "testTable";
        Table table;

        [SetUp]
        public void SetupBasic()
        {
            table = new Table(tableName);
            column = new Column(columnName);
        }


        [TestCaseSource(nameof(ColumnNamesNoExceptions))]
        public void TestCreateColumnOnlyName(string name)
        {
            Column column = new Column(name);

            Assert.AreEqual(name, column.ColumnName);
            Assert.AreEqual(ColumnDataType.Text, column.DataType);
            Assert.AreEqual(null, column.Table);
        }


        [TestCaseSource(nameof(ColumnNameNoExceptionWDatatype))]
        public void TestCreateColumnNameAndDatatype(string name, ColumnDataType dataType)
        {
            Column column = new Column(name, dataType);

            Assert.AreEqual(name, column.ColumnName);
            Assert.AreEqual(dataType, column.DataType);
            Assert.AreEqual(null, column.Table);
        }

        [Test]
        public void TestAddTableToColumn()
        {
            Column column = new Column(columnName);
            column.AddTable(table);

            Assert.AreEqual(table, column.Table);
            Assert.AreEqual($"{tableName}-{columnName}", column.FullName);
        }

        [TestCaseSource(nameof(ColumnNameNoExceptionWDatatype))]
        public void TestCompareColumns(string name, ColumnDataType dataType)
        {
            Column compColumn = new Column(name, dataType);
            
            // sets same datatype
            column.SetDataType(dataType);

            // Adds same table
            compColumn.AddTable(table);
            column.AddTable(table);

            Assert.IsFalse(column == compColumn);
            Assert.IsTrue(column.Equals(compColumn.DataType));
            Assert.IsTrue(column.Equals(compColumn.Table));
            Assert.IsFalse(column.Equals(compColumn.ColumnName));
        }

        [Test]
        public void TestAddRemoveReplaceTable()
        {
            Table table2 = new Table("table2");

            // no table on column
            Assert.AreEqual(null, column.Table);

            // adds table
            column.AddTable(table);
            Assert.AreEqual(table, column.Table);

            // replaces original table
            column.ReplaceTable(table2);
            Assert.AreEqual(table2, column.Table);

            // removes the table
            column.RemoveTable();
            Assert.AreEqual(null, column.Table);
        }


        #region DATASOURCE_METHODS
        private static string[] ColumnNamesNoExceptions()
        {
            return 
                new string[]
                {
                    "column1",
                    "column2",
                    "column3",
                };
        }

        private static IEnumerable<object[]> ColumnNameNoExceptionWDatatype()
        {
            string[] columnNames = ColumnNamesNoExceptions();
            ColumnDataType[] dataTypes = GetColumnDataTypes();

            foreach (string columnName in columnNames)
            {
                foreach (ColumnDataType dataType in dataTypes)
                {
                    yield return
                        new object[]
                        {
                            columnName, dataType
                        };
                }
            }
        }

        private static ColumnDataType[] GetColumnDataTypes()
        {
            return 
                new ColumnDataType[]
                {
                    ColumnDataType.Bool,
                    ColumnDataType.Date,
                    ColumnDataType.SecondaryKey,
                    ColumnDataType.Double,
                    ColumnDataType.Integer,
                    ColumnDataType.PrimaryKey,
                    ColumnDataType.Text,
                    ColumnDataType.Double,
                };
        }
        #endregion DATASOURCE_METHODS
    }
}

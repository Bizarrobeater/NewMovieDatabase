using System.Collections.Generic;
using NUnit.Framework;
using NewMovieDatabase.TableClasses;

namespace TestProject
{
    [TestFixture]
    public class ColumnCreationTests
    {
        string tableName = "testTable";

        [TestCaseSource(nameof(ColumnNamesNoExceptions))]
        public void TestCreateColumnOnlyName(string columnName)
        {
            Column column = new Column(columnName);

            Assert.AreEqual(columnName, column.ColumnName);
            Assert.AreEqual(ColumnDataType.Text, column.DataType);
            Assert.AreEqual(null, column.Table);
        }


        [TestCaseSource(nameof(ColumnNameNoExceptionWDatatype))]
        public void TestCreateColumnNameAndDatatype(string columnName, ColumnDataType dataType)
        {
            Column column = new Column(columnName, dataType);

            Assert.AreEqual(columnName, column.ColumnName);
            Assert.AreEqual(dataType, column.DataType);
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

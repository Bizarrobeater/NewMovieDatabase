using NUnit.Framework;
using NewMovieDatabase.TableClasses;
using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestFixture]
    class ColumnCollectionTest
    {

        ColumnCollection columns;
        private static Column[] basicColumns;
        private static Table[] basicTables;
        private static ColumnDataType[] dataTypes;

        [SetUp]
        public void Setup()
        {
            columns = null;
            basicColumns = SetupColumns();
            basicTables = SetupTables();
            dataTypes = GetColumnDataTypes();
        }


        [Test]
        public void TestBasicEmptyInstantiation()
        {
            columns = new ColumnCollection();

            Assert.IsTrue(columns.Count == 0);
        }

        [Test]
        public void TestBasicInstantiationWColumns()
        {
            columns = new ColumnCollection(basicColumns);

            Assert.AreEqual(columns.Count, basicColumns.Length);
        }

        [TestCaseSource(nameof(SetupColumns))]
        public void TestContainMethod(Column column)
        {
            columns = new ColumnCollection(basicColumns);

            Assert.IsTrue(columns.Contains(column));
        }

        [Test]
        public void TestDoesNotContain()
        {
            columns = new ColumnCollection(basicColumns);
            Column falseColumn = new Column("falseColumn");

            Assert.IsFalse(columns.Contains(falseColumn));
        }

        [Test]
        public void TestAddMethodSimple()
        {
            columns = new ColumnCollection(basicColumns);
            Column newColumn = new Column("TestColumn");

            Assert.IsFalse(columns.Contains(newColumn));

            columns.Add(newColumn);
            
            Assert.IsTrue(columns.Contains(newColumn));
        }

        [TestCaseSource(nameof(GetColumnsAndTables))]
        public void TestAddColumnWTable(Column column, Table table)
        {
            columns = new ColumnCollection();
            Column testColumn = new Column(column.ColumnName);

            Assert.AreEqual(column, testColumn);

            columns.Add(column, table);

            Assert.IsTrue(columns.Contains(column));
            Assert.AreNotEqual(column, testColumn);
            Assert.AreEqual(table, column.Table);
        }

        [TestCaseSource(nameof(GetColumnAndIndex))]
        public void TestColumnIndex(Column column, int index)
        {
            columns = new ColumnCollection(basicColumns);

            Assert.AreEqual(column, columns[index]);
        }

        #region DATASOURCE_METHODS

        private static string[] columnNames = 
            new string[]
                {
                "Column1",
                "Column2",
                "Column3",
                "Column4",
                "Column5",
                };

        private static Column[] SetupColumns()
        {
            Column[] columns = new Column[columnNames.Length];

            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = new Column(columnNames[i]);
            }
            return columns;
        }


        private static string[] tableNames =
            new string[]
            {
                "Table1",
                "Table2",
                "Table3",
                "Table4",
            };

        private static Table[] SetupTables()
        {
            Table[] tables = new Table[tableNames.Length];
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = new Table(tableNames[i]);
            }
            return tables;
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

        private static IEnumerable<object[]> GetColumnsAndTables()
        {
            Column[] basicColumns = SetupColumns();
            Table[] basicTables = SetupTables();

            foreach (Column column in basicColumns)
            {
                foreach (Table table in basicTables)
                {
                    yield return
                        new object[]
                        {
                            new Column(column.ColumnName), table
                        };
                }
            }
        }

        private static IEnumerable<object[]> GetColumnAndIndex()
        {
            Column[] basicColumns = SetupColumns();

            for (int i = 0; i < basicColumns.Length; i++)
            {
                yield return
                    new object[]
                    {
                        basicColumns[i], i
                    };
            }
        }






        #endregion DATASOURCE_METHODS


    }
}

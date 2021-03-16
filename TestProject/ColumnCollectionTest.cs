using NUnit.Framework;
using NewMovieDatabase.TableClasses;
using System;

namespace TestProject
{
    [TestFixture]
    class ColumnCollectionTest
    {

        ColumnCollection columns;
        private static Column[] basicColumns { get => SetupColumns(); }
        private static Table[] basicTables { get => SetupTables(); }
        private static ColumnDataType[] dataTypes { get => GetColumnDataTypes(); }

        [SetUp]
        public void Setup()
        {
            columns = null;
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

        [TestCaseSource(nameof(basicColumns))]
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






        #endregion DATASOURCE_METHODS


    }
}

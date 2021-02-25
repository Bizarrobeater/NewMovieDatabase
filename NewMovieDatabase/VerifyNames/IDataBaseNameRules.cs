namespace NewMovieDatabase.VerifyNames
{
    /// <summary>
    /// Defines methods for the verification of column/table names
    /// </summary>
    public interface IDataBaseNameRules 
    {
        /// <summary>
        /// Verifies a given column name.
        /// </summary>
        /// <param name="columnName">Name that should be verified.</param>
        /// <param name="message">For giving users a message regarding exceptions.</param>
        /// <returns>
        /// True if the name is verified, else false.
        /// </returns>
        bool VerifyColumnName(string columnName, out string message);
        /// <summary>
        /// Verifies a given table name.
        /// </summary>
        /// <param name="name">Name that should be verified.</param>
        /// <param name="message">For giving users a message regarding exceptions.</param>
        /// <returns>
        /// True if the name is verified, else false.
        /// </returns>
        bool VerifyTableName(string name, out string message);
    }
}

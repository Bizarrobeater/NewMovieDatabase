namespace NewMovieDatabase.SQLBuilder
{
    /// <summary>
    /// Interface used to contruct SQL strings.
    /// </summary>
    public interface ISQLCommandBuilder
    {
        /// <summary>
        /// Returns a string corresponding to an SQL command string.
        /// </summary>
        string ToSQLString { get; }
    }
}
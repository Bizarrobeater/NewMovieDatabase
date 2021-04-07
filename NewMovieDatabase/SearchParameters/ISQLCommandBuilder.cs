namespace NewMovieDatabase.SearchParameters
{
    /// <summary>
    /// Interface used to contruct SQL strings.
    /// </summary>
    public interface ISQLCommandBuilder
    {
        /// <summary>
        /// Returns a string corresponding to an SQL string.
        /// </summary>
        string ToSQLString { get; }
    }
}
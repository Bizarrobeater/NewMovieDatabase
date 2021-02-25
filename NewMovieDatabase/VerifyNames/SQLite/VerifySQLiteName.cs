namespace NewMovieDatabase.VerifyNames
{
    /// <summary>
    /// Represents a verification procedure of column and table names for SQLite.
    /// </summary>
    public class VerifySQLiteName : VerifySQLLanguageName
    {
        /// <summary>
        /// Initialises the filename.
        /// </summary>
        public VerifySQLiteName()
        {
            _keywordFilename = "SQLiteKeywords.txt";
        }

        /// <inheritdoc/>
        public override bool VerifyColumnName(string name, out string message)
        {
            bool verified = false;
            try
            {
                if (!SimpleVerify(name))
                    throw new BasicNameConstraintException(name);
                else if (_keywordList.Value.Contains(name.ToUpper()))
                    throw new KeywordNameException(name);
                message = "";
                verified = true;
            }
            catch (BasicNameConstraintException bncE)
            {
                message = bncE.Message;
            }
            catch (KeywordNameException knE)
            {
                message = knE.Message;
            }
            return verified;
        }

        /// <inheritdoc/>
        /// <remarks>No different rules for tables and columns in SQLite</remarks>
        public override bool VerifyTableName(string name, out string message)
        {
            return VerifyColumnName(name, out message);
        }
    }
}

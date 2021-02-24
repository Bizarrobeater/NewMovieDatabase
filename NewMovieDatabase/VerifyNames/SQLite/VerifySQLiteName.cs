namespace NewMovieDatabase.VerifyNames
{
    public class VerifySQLiteName : VerifySQLLanguageName
    {
        public VerifySQLiteName()
        {
            keywordFilename = "SQLiteKeywords.txt";
        }
        public override bool VerifyColumnName(string name, out string message)
        {
            bool verified = false;
            try
            {
                if (!SimpleVerify(name))
                    throw new BasicNameConstraintException(name);
                else if (keywordList.Value.Contains(name.ToUpper()))
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


        // No different rules for tables and columns in SQLite
        public override bool VerifyTableName(string name, out string message)
        {
            return VerifyColumnName(name, out message);
        }
    }
}

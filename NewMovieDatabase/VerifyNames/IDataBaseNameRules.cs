namespace NewMovieDatabase.VerifyNames
{
    public interface IDataBaseNameRules 
    {
        bool VerifyColumnName(string columnName, out string message);
        bool VerifyTableName(string name, out string message);
    }
}

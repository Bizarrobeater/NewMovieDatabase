namespace NewMovieDatabase.SearchParameters
{
    public interface ISearchParameter
    {
        string ReturnAsSQLParameter { get; }
    }
}
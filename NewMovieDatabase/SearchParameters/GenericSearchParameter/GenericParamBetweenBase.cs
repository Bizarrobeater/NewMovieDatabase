namespace NewMovieDatabase.SearchParameters
{
    abstract class GenericParamBetweenBase<T> : GenericParam<T>
    {
        internal T _secondSearchParameter { get; private set; }
        internal bool _equal { get; private set; }
        protected GenericParamBetweenBase(T firstParameter, T secondParameter) : base(firstParameter)
        {
            _secondSearchParameter = secondParameter;
            SortParameters();
            _equal = firstParameter.Equals(secondParameter);
        }

        internal abstract void SortParameters();
    }
}

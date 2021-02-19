namespace NewMovieDatabase.SearchParameters
{
    public abstract class NumberParamBetweenBase : NumberParam
    {
        internal int _secondSearchParameter { get; private set; }
        internal bool _equal { get; private set; }

      
        public NumberParamBetweenBase(int firstParam, int secondParam) : base(firstParam)
        {
            _secondSearchParameter = secondParam;
            SortParameters();
            _equal = _searchParameter == _secondSearchParameter;
        }

        private void SortParameters()
        {
            if (_searchParameter > _secondSearchParameter)
            {
                int temp = _searchParameter;
                _searchParameter = _secondSearchParameter;
                _secondSearchParameter = temp;
            }
        } 
    }
}

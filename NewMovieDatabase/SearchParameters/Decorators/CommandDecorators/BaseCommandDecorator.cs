//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NewMovieDatabase.SearchParameters.Decorators.CommandDecorators
//{
//    class BaseCommandDecorator : SQLCommandDecorator
//    {
//        public BaseCommandDecorator(IEnumerable<ISQLCommandBuilder> searchParameters)
//        {
//            _commandBuilder = searchParameters.ToList();
//        }

//        public BaseCommandDecorator(ISQLCommandBuilder searchParameter)
//        {
//            _commandBuilder = new List<ISQLCommandBuilder>() { searchParameter };
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMovieDatabase.TableClasses 
{
    // TODO: Comment
    interface IColumnCollection : ICollection<Column>
    {
        void Add(Column column, Table table);
    }
}

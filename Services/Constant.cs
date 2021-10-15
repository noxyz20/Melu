using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Constant:Functoid
    {
        public override List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            var val = parameters[0].value;
            columnList.Select(@col => @col.cells.Select(
                @cell => @cell.content = val));

            return columnList;
        }
    }
}

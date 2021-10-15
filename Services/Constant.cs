using DataContracts;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Constant:Functoid
    {
        public override List<Column> Transform()
        {
            var val = parameters[0].value;
            inColumns.Select(@col => @col.cells.Select(
                @cell => @cell.content = val));

            return inColumns;
        }
    }
}

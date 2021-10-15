using DataContracts;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Merge : Functoid
    {
        public override List<Column> Transform()
        {
            var separator = parameters[0].value;
            var columnToReturn = inColumns[0];
            inColumns.RemoveAt(0);
            inColumns.Select(@col => @col.cells.Select(
                (@cell, index) => columnToReturn.cells[index].content += separator + @cell.content));
            return new List<Column>() { columnToReturn };

        }
    }
}

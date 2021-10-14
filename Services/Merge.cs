using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Merge : Functoid
    {
        public override List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            var separator = parameters[0].value;
            var columnToReturn = columnList[0];
            columnList.RemoveAt(0);
            columnList.Select(@col => col.cells.Select(
                (@cell, index) => columnToReturn.cells[index].content += separator + cell.content));
            var test = new List<Column>() { columnToReturn };
            return test;

        }
    }
}

using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Split : Functoid
    {
        public override List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            var columns = new List<Column>();

            var cell1 = new Cell() { content = "1"};
            var cell2 = new Cell() { content = "2" };
            var cell3 = new Cell() { content = "3" };
            var cell4 = new Cell() { content = "4" };
            var cell5 = new Cell() { content = "5" };

            var cells = new List<Cell>();
            cells.Add(cell1);
            cells.Add(cell2);
            cells.Add(cell3);
            cells.Add(cell4);
            cells.Add(cell5);

            

            var c1 = new Column() { id = Guid.NewGuid(), cells = cells, name = "Column name 1 " };
            cells.Reverse();
            var c2 = new Column() { id = Guid.NewGuid(), cells = cells, name = "Column name 2 " };

            columns.Add(c1);
            columns.Add(c2);

            return columns;
        }
    }
}

using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Split:Functoid
    {
        public override List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            //max d'element dans le tableau
            int nbElement = 0;
            Column c = columnList[0];
            string delimiter = parameters[0].value;
            List<Column> columns = new List<Column>();
            List<Cell> cellules = new List<Cell>();

            foreach (Cell ce in c.cells)
            {
                string[] subs = ce.content.Split(delimiter);
                if (subs.Length > nbElement)
                {
                    nbElement = subs.Length;
                }
            }

            for (int i = 0; i < nbElement; i++)
            {
                foreach (Cell ce in c.cells)
                {
                    string[] subs = ce.content.Split(delimiter);
                    foreach (string s in subs)
                    {
                        Cell cell = new Cell()
                        {
                            content = s
                        };
                        cellules.Add(cell);
                    }
                }
                columns.Add(new Column()
                {
                    cells = cellules,
                    id = Guid.NewGuid(),
                    name = c.name + " " + i + 1
                });
            }

            return columns;
        }
    }
}

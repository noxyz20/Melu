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
            var colList = new List<Column>()
            {
                new Column()
                {
                    id = Guid.Parse("4b128087-cbf1-4140-a542-e81bbd590320"),
                    name = "nomPrenom",
                    cells = new List<Cell>()
                    {
                        new Cell()
                        {
                            content = "David:Rosich"
                        },
                        new Cell()
                        {
                            content = "Mickael:Lanfranchi"
                        },
                        new Cell()
                        {
                            content = "Mohamed:Dib"
                        } 
                    } 
                }                
            };
            return colList;

        }
    }
}

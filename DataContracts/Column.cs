using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class Column
    {
       private List<Cell> cells { get; set; }
       private Guid id { get; set; }
       private String name { get; set; }

    }
}

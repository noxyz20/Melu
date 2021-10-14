using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class Column
    {
       public List<Cell> cells { get; set; }
       public Guid id { get; set; }
       public String name { get; set; }

    }
}

using DataContracts;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Duplicate : Functoid
    {
        public override  List<Column> Transform()
        {
            return new List<Column>(inColumns);
           
        }
    }
}

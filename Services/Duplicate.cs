using DataContracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Duplicate : Functoid
    {
        public override  List<Column> Transform(List<Column> columnList, List<Parameter> parameters)
        {
            return new List<Column>(columnList);
           
        }
    }
}

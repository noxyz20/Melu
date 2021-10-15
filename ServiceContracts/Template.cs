using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public class Template
    {
        public Guid id { get; set; }
        public String name { get; set; }
        public List<Functoid> functoids { get; set; }
        
    }
}

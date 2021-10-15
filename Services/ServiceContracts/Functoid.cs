using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataContracts;

namespace Services.ServiceContracts
{
    [Serializable()]
    [XmlInclude(typeof(Split))]
    public abstract class Functoid

    {
        public List<Column> columnList { get; set; }
        public List<Parameter> parameters { get; set; }
        public abstract List<Column> Transform();

    }
}


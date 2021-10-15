﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataContracts;

namespace ServiceContracts
{
    [Serializable()]
    [XmlInclude(typeof(Split))]
    public abstract class Functoid

    {
        public abstract List<Column> Transform(List<Column> columnList, List<Parameter> parameters);

    }
}


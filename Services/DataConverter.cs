using DataContracts;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class DataConverter
    {
        public List<Column> inData { get; set; }
        public List<Column> outData { get; set; }
        public Template template { get; set; }

        public void Converter()
        {
            
            foreach (Column col in inData)
            {
                foreach (Functoid f in template.functoids)
                {
                    outData.AddRange(f.Transform());
                }
            }
            
        }
    }

}

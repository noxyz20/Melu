using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Services
{
    public class TemplateService
    {
        public Template template { get; set; }

        

        public Template DeSerialize()
        {
            var serial = new XmlSerializer(typeof(Template));
            var deserializedTemplate = new Template();

            using (var st = File.Open(template.name + ".xml", FileMode.Open))
            {
                try
                {
                    Console.WriteLine("Deserializing ... ");

                    deserializedTemplate = (Template) serial.Deserialize(st);
                }
                catch (Exception ex)
                {
                    Console.Write("Deserialization error:" + ex.Message);
                }
                /*finally
                {
                    Console.Write("Re-try with a different number.");
                }*/

                
            }
            return deserializedTemplate;
        }

        public void Serialize()
        {
            var serial = new XmlSerializer(typeof(Template));
            using (var st = File.Create(template.name + ".xml")) 
            {
                serial.Serialize(st, template);
            }
            
            
        }
    }
}

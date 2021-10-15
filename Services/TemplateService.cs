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

        

        public List<Template> DeSerialize()
        {
            var templates = new List<Template>();
            var serial = new XmlSerializer(typeof(List<Template>));
            

            using (var st = File.Open("templates.xml", FileMode.Open))
            {
                try
                {
                    Console.WriteLine("Deserializing ... ");

                    templates = (List<Template>)serial.Deserialize(st);
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
            return templates;
        }

        public void Serialize()
        {
            var serial = new XmlSerializer(typeof(List<Template>));
            var templateList = DeSerialize();
            using (var st = File.Create("templates.xml")) 
            {
                
                templateList.Add(template);
                serial.Serialize(st, templateList);
            }
            
            
        }
    }
}

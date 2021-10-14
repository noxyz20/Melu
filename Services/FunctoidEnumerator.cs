using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class FunctoidEnumerator
    {
        static FunctoidEnumerator() { }

        public static List<System.Type> GetFunctoidClasses()
        {
            var objects = (
                    from domainAssembly in AppDomain.CurrentDomain.GetAssemblies()
                    from assemblyType in domainAssembly.GetTypes()
                    where
                    typeof(ServiceContracts.Functoid).IsAssignableFrom(assemblyType)
                    && !assemblyType.IsAbstract
                    select assemblyType).ToList();
            return objects;
        }
    }
}

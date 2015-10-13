using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.DependencyResolution
{
    public class IoC
    {

        public void Init()
        {
            ObjectFactory.Configure(config =>
            {
                config.Scan(scan =>
                {
                    scan.WithDefaultConventions();
                });

                // the last entry wins if there's more than one - generally it's a good idea to only have one mapping per type

            });
        }
    }
}

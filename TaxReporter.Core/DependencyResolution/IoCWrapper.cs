using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace TaxReporter.Core.DependencyResolution
{
    public static class IoCWrapper
    {
        public static IContainer Container { get; set; }

        public static T Get<T>()
        {
            return Container.GetInstance<T>();
        }

        public static T Get<T>(string instanceName)
        {
            return Container.GetInstance<T>(instanceName);
        }
    }
}

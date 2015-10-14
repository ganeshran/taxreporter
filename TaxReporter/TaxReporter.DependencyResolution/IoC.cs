using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;
using TaxReporter.Services.Input;

namespace TaxReporter.DependencyResolution
{
    public static class IoCWrapper
    {
        static IContainer _container;
        public static void InitContainer()
        {
            _container = new Container(x =>
            {
                x.For<IInvoiceReaderService>().Use<CsvInvoiceReaderService>();
            });
        }

        public static T Get<T>()
        {
            return _container.GetInstance<T>();
        }
    }
}

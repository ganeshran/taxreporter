using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;
using TaxReporter.Services;
using TaxReporter.Services.Calculator;
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
                    x.For<ITaxCalculatorService>()
                     .Use<DomesticTaxCalculatorService>()
                     .Named(ClientType.Domestic.ToString());

                    x.For<ITaxCalculatorService>()
                     .Use<InternationalTaxCalculatorService>()
                     .Named(ClientType.International.ToString());

                    x.For<ITaxDue>().Use<ForeignRemitanceTax>().Named("FRT");

                    x.For<ITaxDue>().Use<ServiceTax>().Named("ST");

                    x.For<ITaxDue>().Use<EducationCess>().Named("EC");
                });
        }

        public static T Get<T>()
        {
            return _container.GetInstance<T>();
        }

        public static T Get<T>(string instanceName)
        {
            return _container.GetInstance<T>(instanceName);
        }
    }
}

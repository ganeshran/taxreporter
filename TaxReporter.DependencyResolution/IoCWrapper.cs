using StructureMap;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Services;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;
using TaxReporter.Services.Calculator;
using TaxReporter.Services.Input;
using TaxReporter.Services.ReportService;

namespace TaxReporter.DependencyResolution
{
    public static class IoCWrapper
    {
        private static IContainer _container;

        public static void InitContainer()
        {
            _container = new Container(x =>
                {
                    x.For<IInvoiceReaderService>().Use<CsvInvoiceReaderService>();

                    x.For<IDomesticTaxCalculatorService>().Use<DomesticTaxCalculatorService>();
                    x.For<IInternationalTaxCalculatorService>().Use<InternationalTaxCalculatorService>();
                    x.For<ITaxDue>().Use<ForeignRemitanceTax>().Named("FRT");

                    x.For<ITaxDue>().Use<ServiceTax>().Named("ST");

                    x.For<ITaxDue>().Use<EducationCess>().Named("EC");

                    x.For<IOutputReportService>().Use<MonthlyReporterService>();
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
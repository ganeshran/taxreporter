using StructureMap;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Services;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;
using TaxReporter.Services.Calculator;
using TaxReporter.Services.Input;
using TaxReporter.Services.ReportService;

namespace TaxReporter.DependencyResolution
{
    public static class BootStrapper
    {

        public static void InitContainer()
        {
            IoCWrapper.Container = new Container(x =>
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

    }
}
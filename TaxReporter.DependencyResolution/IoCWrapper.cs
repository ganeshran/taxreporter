using StructureMap;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;
using TaxReporter.Services.Calculator;
using TaxReporter.Services.Input;
using TaxReporter.Services.ReportService;
using TaxReporter.Services.Taxes;

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
                    x.For<ITaxDue>().Use<ForeignRemitanceTax>().Named(TaxTypes.ForeignRemittanceTax.ToString());

                    x.For<ITaxDue>().Use<ServiceTax>().Named(TaxTypes.ServiceTax.ToString());

                    x.For<ITaxDue>().Use<EducationCess>().Named(TaxTypes.EducationCess.ToString());

                    x.For<IOutputReportService>().Use<MonthlyReporterService>();
                });
        }

    }
}
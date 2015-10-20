using StructureMap;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;
using TaxReporter.Services.Calculator;
using TaxReporter.Services.Factories;
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
                    x.For<ITaxDue>().Use<EducationCess>().Named(TaxTypes.EducationCess.ToString());
                    x.For<ISimplePercentTaxDue>().Use<SimplePercentageTax>();
                    x.For<ITaxFactory>().Use<TaxFactory>();
                    x.For<ITaxCalculatorService>().Use<DomesticTaxCalculatorService>().Named("Domestic");
                    x.For<ITaxCalculatorService>().Use<InternationalTaxCalculatorService>().Named("International");
                    x.For<IOutputReportService>().Use<MonthlyReporterService>();
                });
        }

    }
}
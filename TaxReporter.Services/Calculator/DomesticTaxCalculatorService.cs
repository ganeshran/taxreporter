using System.Collections.Generic;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class DomesticTaxCalculatorService : TaxCalculatorService
    {
        public DomesticTaxCalculatorService(ITaxFactory taxFactory)
        {
            TaxesDue = new List<ITaxDue>
                {
                    taxFactory.GetTaxInstance(TaxTypes.ServiceTax),
                    taxFactory.GetTaxInstance(TaxTypes.EducationCess),
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
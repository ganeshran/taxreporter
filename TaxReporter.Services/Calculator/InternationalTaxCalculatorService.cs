using System.Collections.Generic;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class InternationalTaxCalculatorService : TaxCalculatorService, IInternationalTaxCalculatorService
    {
        public InternationalTaxCalculatorService(ITaxFactory taxFactory)
        {
            TaxesDue = new List<ITaxDue>
                {
                    taxFactory.GetTaxInstance(TaxTypes.ForeignRemittanceTax)
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
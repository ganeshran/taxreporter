using System.Collections.Generic;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class InternationalTaxCalculatorService : TaxCalculatorService, IInternationalTaxCalculatorService
    {
        public InternationalTaxCalculatorService()
        {
            TaxesDue = new List<ITaxDue>
                {
                    IoCWrapper.Get<ITaxDue>(TaxTypes.ForeignRemittanceTax.ToString())
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
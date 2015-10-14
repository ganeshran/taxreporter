using System.Collections.Generic;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class InternationalTaxCalculatorService : TaxCalculatorService
    {
        public InternationalTaxCalculatorService()
        {
            TaxesDue = new List<ITaxDue>
                {
                    new ForeignRemitanceTax()
                };
        }

        protected override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
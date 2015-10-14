using System.Collections.Generic;
using TaxReporter.Core.Services;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class DomesticTaxCalculatorService : TaxCalculatorService, IDomesticTaxCalculatorService
    {
        public DomesticTaxCalculatorService()
        {
            TaxesDue = new List<ITaxDue>
                {
                    new ServiceTax(),
                    new EducationCess()
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
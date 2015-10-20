using System.Collections.Generic;
using TaxReporter.Core.DependencyResolution;
using TaxReporter.Core.Enums;
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
                    IoCWrapper.Get<ITaxDue>(TaxTypes.ServiceTax.ToString()),
                    IoCWrapper.Get<ITaxDue>(TaxTypes.EducationCess.ToString())
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
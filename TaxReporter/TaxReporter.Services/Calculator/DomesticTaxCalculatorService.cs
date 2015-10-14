using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class DomesticTaxCalculatorService : TaxCalculatorService
    {
        protected override IEnumerable<ITaxDue> TaxesDue { get; set; }

        public DomesticTaxCalculatorService()
        {
            this.TaxesDue = new List<ITaxDue>()
                {
                    new ServiceTax(),
                    new EducationCess()
                };
        }
    }
}

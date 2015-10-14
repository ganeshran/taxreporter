using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class InternationalTaxCalculatorService: TaxCalculatorService
    {
        protected override IEnumerable<ITaxDue> TaxesDue { get; set; }


        public InternationalTaxCalculatorService()
        {
            this.TaxesDue = new List<ITaxDue>()
                {
                    new ForeignRemitanceTax()
                };
        }
    }
}

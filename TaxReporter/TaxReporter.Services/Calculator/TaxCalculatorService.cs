using System.Collections.Generic;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    abstract public class TaxCalculatorService: ITaxCalculatorService 
    {
        protected abstract IEnumerable<ITaxDue> TaxesDue { get; set; }  

        public double DueTax(IInvoiceEntry invoice)
        {
            throw new System.NotImplementedException();
        }
    }
}

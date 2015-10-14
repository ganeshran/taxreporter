using System.Collections.Generic;
using System.Linq;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public abstract class TaxCalculatorService : ITaxCalculatorService
    {
        protected abstract IEnumerable<ITaxDue> TaxesDue { get; set; }

        public int DueTax(IInvoiceEntry invoice)
        {
            return TaxesDue.Sum(taxDue => taxDue.CalculateTaxDue(invoice.Amount));
        }
    }
}
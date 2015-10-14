using System.Collections.Generic;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.Services
{
    public interface ITaxCalculatorService
    {

        IEnumerable<ITaxDue> TaxesDue { get; set; }

        int DueTax(IInvoiceEntry invoice);
    }
}
using TaxReporter.Core.Entities;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.Calculator
{
    abstract public class TaxCalculatorService: ITaxCalculatorService 
    {
        public double DueTax(IInvoiceEntry invoice)
        {
            throw new System.NotImplementedException();
        }
    }
}

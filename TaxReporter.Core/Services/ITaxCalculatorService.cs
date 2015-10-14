using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Services
{
    public interface ITaxCalculatorService
    {
        int DueTax(IInvoiceEntry invoice);
    }
}
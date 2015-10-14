using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Services
{
    public interface ITaxCalculatorService
    {
        double DueTax(IInvoiceEntry invoice);
    }
}

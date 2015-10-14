namespace TaxReporter.Core.Entities
{
    public interface IParseInvoiceStatus
    {
        IInvoiceEntry InvoiceEntry { get; set; }

        bool IsSuccess { get; set; }

        string ErrorMessage { get; set; }
    }
}
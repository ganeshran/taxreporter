using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    public class ParseInvoiceStatus : IParseInvoiceStatus
    {
        public ParseInvoiceStatus(string input)
        {
            string[] line = input.Split(',');
            if (line.Length != 4)
            {
                ErrorMessage = "Incorrect number of Columns";
                IsSuccess = false;
                InvoiceEntry = null;
            }
            InvoiceEntry = new InvoiceEntry();
            if (!InvoiceEntry.PopulateObject(line))
            {
                IsSuccess = false;
                ErrorMessage = InvoiceEntry.ErrorMessage;
            }

            IsSuccess = true;
        }

        public IInvoiceEntry InvoiceEntry { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}
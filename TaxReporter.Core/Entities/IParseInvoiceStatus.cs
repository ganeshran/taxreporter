using System.Collections.Generic;

namespace TaxReporter.Core.Entities
{
    public interface IParseInvoiceStatus
    {
        List<IInvoiceEntry> Entries { get; set; }

        bool IsSuccess { get; set; }

        void AddEntry(string line);
    }
}
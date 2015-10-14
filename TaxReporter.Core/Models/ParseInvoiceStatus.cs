using System.Collections.Generic;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    public class ParseInvoiceStatus : IParseInvoiceStatus
    {

        public ParseInvoiceStatus()
        {
            this.IsSuccess = true;
            this.Entries = new List<IInvoiceEntry>();
        }

        public List<IInvoiceEntry> Entries { get; set; }
        public bool IsSuccess { get; set; }
        public void AddEntry(string line)
        {
            var entry = new InvoiceEntry();
            if (!entry.PopulateObject(line.Split(',')))
                this.IsSuccess = false;
            this.Entries.Add(entry);
        }
    }
}
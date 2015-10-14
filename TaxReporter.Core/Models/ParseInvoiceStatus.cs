using System.Collections.Generic;
using TaxReporter.Core.Entities;
using System.Linq;

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
            if (!entry.PopulateObject(line.Split(',').Select(x=>x.Trim()).ToArray()))
                this.IsSuccess = false;
            this.Entries.Add(entry);
        }
    }
}
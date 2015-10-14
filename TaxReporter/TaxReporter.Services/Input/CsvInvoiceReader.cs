using System.Collections.Generic;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.Input 
{
    public class CsvInvoiceReaderService: IInvoiceReaderService
    {
        public List<IInvoiceEntry> GetInvoiceInputs()
        {
            //dummy implementation 
            return new List<IInvoiceEntry>()
            {
                new InvoiceEntry(){InvoiceNumber = 1}
            };
        }
    }
}

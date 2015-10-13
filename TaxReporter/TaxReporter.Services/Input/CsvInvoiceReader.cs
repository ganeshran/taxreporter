using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;
using TaxReporter.Core.Models;
using TaxReporter.Core.Services;

namespace TaxReporter.Services.Input 
{
    public class CsvInvoiceReader: IInvoiceReader
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

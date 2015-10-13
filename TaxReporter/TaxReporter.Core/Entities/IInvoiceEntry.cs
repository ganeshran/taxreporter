using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Entities
{
    public interface IInvoiceEntry
    {
        int InvoiceNumber { get; set; }

        IClient Client { get; set; }

        DateTime InvoiceDate { get; set; }

        double Amount { get; set; }
    }
}

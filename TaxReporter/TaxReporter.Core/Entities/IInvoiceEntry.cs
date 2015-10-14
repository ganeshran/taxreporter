using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Entities
{
    public interface IInvoiceEntry
    {
        IInvoiceField<int> Number { get; set; }

        IInvoiceField<string> Client { get; set; }
            
        IInvoiceField<DateTime> InvoiceDate { get; set; }

        IInvoiceField<double> Amount { get; set; }
    }
}

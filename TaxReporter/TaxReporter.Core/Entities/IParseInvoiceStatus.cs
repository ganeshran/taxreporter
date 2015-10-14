using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Entities
{
    public interface IParseInvoiceStatus
    {
        IInvoiceEntry InvoiceEntry { get; set; }

        bool IsSuccess { get; set; }

        string ErrorMessage { get; set; }
    }
}

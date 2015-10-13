using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Entities
{
    public interface IInvoiceEntry
    {
        public int InvoiceNumber { get; set; }

        public IClient Client { get; set; }


    }
}

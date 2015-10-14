using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    public class InvoiceField<T>: IInvoiceField<T>
    {
        public T Value { get; set; }
        public int Index { get; set; }
        public Func<string, bool> Validate { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Entities
{
    public interface IInvoiceField<T>
    {
        T Value { get; set; }

        int Index { get; set; }

        Func<string, bool> Validate { get; set; } 
    }
}

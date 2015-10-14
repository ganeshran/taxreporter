using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReporter.Core.Taxes
{
    public interface IDerivedTaxDue: ITaxDue
    {
        ITaxDue ChildTax { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxReporter.Core.Taxes
{
    public interface ISimplePercentTaxDue: ITaxDue
    {
        double PercentageTax { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.Factories
{
    public interface ITaxFactory
    {
        ITaxDue GetTaxInstance(TaxTypes type);
    }
}

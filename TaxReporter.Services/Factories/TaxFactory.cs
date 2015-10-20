using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.Enums;
using TaxReporter.Core.Factories;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Factories
{
    public class TaxFactory: ITaxFactory
    {
        public ITaxDue GetTaxInstance(TaxTypes type)
        {
            throw new NotImplementedException();
        }
    }
}

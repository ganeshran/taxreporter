﻿using System.Collections.Generic;
using TaxReporter.Core.Services;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class InternationalTaxCalculatorService : TaxCalculatorService, IInternationalTaxCalculatorService
    {
        public InternationalTaxCalculatorService()
        {
            TaxesDue = new List<ITaxDue>
                {
                    new ForeignRemitanceTax()
                };
        }

        public override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
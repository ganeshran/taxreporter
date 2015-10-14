﻿using System.Collections.Generic;
using TaxReporter.Core.TaxImplementation;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Calculator
{
    public class DomesticTaxCalculatorService : TaxCalculatorService
    {
        public DomesticTaxCalculatorService()
        {
            TaxesDue = new List<ITaxDue>
                {
                    new ServiceTax(),
                    new EducationCess()
                };
        }

        protected override IEnumerable<ITaxDue> TaxesDue { get; set; }
    }
}
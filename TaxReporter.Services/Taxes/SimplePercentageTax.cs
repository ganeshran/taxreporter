using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Taxes
{
    public class SimplePercentageTax: ISimplePercentTaxDue
    {

        public double PercentageTax { get; set; }
        public string Name { get; set; }

        public SimplePercentageTax()
        {
            
        }
        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(invoiceAmount*this.PercentageTax);
        }
    }
}

using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class ForeignRemitanceTax : ITaxDue
    {
        public string Name { get; set; }

        public ForeignRemitanceTax()
        {
            this.Name = "Foreign Remittance Tax";
        }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int)Math.Round(invoiceAmount*0.05);
        }
    }
}

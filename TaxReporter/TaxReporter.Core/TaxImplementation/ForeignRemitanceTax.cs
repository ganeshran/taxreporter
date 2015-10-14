using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class ForeignRemitanceTax : ITaxDue
    {
        public ForeignRemitanceTax()
        {
            Name = "Foreign Remittance Tax";
        }

        public string Name { get; set; }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(invoiceAmount*0.05);
        }
    }
}
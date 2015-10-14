using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Core.TaxImplementation
{
    public class ServiceTax : ITaxDue
    {
        public string Name { get; set; }

        public ServiceTax()
        {
            this.Name = "Service Tax";
        }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int)Math.Round(invoiceAmount*0.10);
        }
    }
}

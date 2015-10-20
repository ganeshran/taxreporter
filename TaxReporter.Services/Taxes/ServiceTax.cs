using System;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Taxes
{
    public class ServiceTax : ITaxDue
    {
        public ServiceTax()
        {
            Name = "Service Tax";
        }

        public string Name { get; set; }

        public int CalculateTaxDue(double invoiceAmount)
        {
            return (int) Math.Round(invoiceAmount*0.10);
        }
    }
}
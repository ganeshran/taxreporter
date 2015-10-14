using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Taxes;

namespace TaxReporter.Services.Taxes
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

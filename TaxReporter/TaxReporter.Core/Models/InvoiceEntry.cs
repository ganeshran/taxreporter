using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxReporter.Core.Entities;

namespace TaxReporter.Core.Models
{
    /// <summary>
    /// Only the implementations for the entities should be in the CoreProject - which are 
    /// pure data entities without behaviour
    /// </summary>
    public class InvoiceEntry: IInvoiceEntry 
    {
        public IInvoiceField<int> Number { get; set; }
        public IInvoiceField<string> Client { get; set; }
        public IInvoiceField<DateTime> InvoiceDate { get; set; }
        public IInvoiceField<double> Amount { get; set; }

        public InvoiceEntry()
        {
            int res;
            DateTime date;
            double d;
            this.Number = new InvoiceField<int>() {Index = 0, Validate = num => int.TryParse(num,out res)};
            this.Client = new InvoiceField<string>()
                {
                    Index = 1,
                    Validate = num => num.StartsWith("D") || num.StartsWith("I")
                };
            this.InvoiceDate = new InvoiceField<DateTime>()
                {
                    Index = 2,
                    Validate = num => DateTime.TryParse(num, out date)
                };
            this.Amount = new InvoiceField<double>()
                {
                    Index = 3,
                    Validate = num => Double.TryParse(num, out d)
                };
        }
    }
}

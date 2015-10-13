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
        public int InvoiceNumber
        {
            get;
            set;
        }

        public IClient Client
        {
            get;
            set;
        }

        public DateTime InvoiceDate
        {
            get;
            set;
        }

        public double Amount
        {
            get;
            set;
        }
    }
}
